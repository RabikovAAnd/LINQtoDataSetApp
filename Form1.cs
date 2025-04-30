using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LINQtoDataSetApp
{
    public partial class Form1 : Form
    {
        private DataTable employeesTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database3DataSet1.Работники". При необходимости она может быть перемещена или удалена.
            this.работникиTableAdapter.Fill(this.database3DataSet1.Работники);
            try
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EmployeesDB.accdb;";
                OleDbConnection connection = new OleDbConnection(connectionString);

                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Сотрудники", connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Сотрудники");

                employeesTable = dataSet.Tables["Сотрудники"];
                dataGridView1.DataSource = employeesTable;

                // Заполнение ListBox должностями
                var positions = employeesTable.AsEnumerable()
                    .Select(row => row.Field<string>("Должность"))
                    .Distinct()
                    .ToList();
                listBoxPositions.DataSource = positions;

                // Настройка столбцов для dataGridView2
                dataGridView2.Columns.Add("Column1", "Фамилия");
                dataGridView2.Columns.Add("Column2", "Имя");
                dataGridView2.Columns.Add("Column3", "Должность");
                dataGridView2.Columns.Add("Column4", "Дата рождения");
                dataGridView2.Columns.Add("Column5", "Оклад");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayQueryResult(IEnumerable<DataRow> query)
        {
            dataGridView2.Rows.Clear();

            foreach (DataRow row in query)
            {
                dataGridView2.Rows.Add(
                    row.Field<string>("Фамилия"),
                    row.Field<string>("Имя"),
                    row.Field<string>("Должность"),
                    row.Field<DateTime>("ДатаРождения").ToShortDateString(),
                    row.Field<decimal>("Оклад")
                );
            }
        }

        private void btnAvgSalary_Click(object sender, EventArgs e)
        {
            decimal avgSalary = employeesTable.AsEnumerable()
                .Average(row => row.Field<decimal>("Оклад"));

            MessageBox.Show($"Средний оклад по компании: {avgSalary:F2} руб.", "Результат",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя сотрудника", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var query = employeesTable.AsEnumerable()
                .Where(row => row.Field<string>("Имя").Contains(name));

            DisplayQueryResult(query);
        }

        private void btnFindByPosition_Click(object sender, EventArgs e)
        {
            if (listBoxPositions.SelectedItem == null)
            {
                MessageBox.Show("Выберите должность", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string position = listBoxPositions.SelectedItem.ToString();
            var query = employeesTable.AsEnumerable()
                .Where(row => row.Field<string>("Должность") == position);

            DisplayQueryResult(query);
        }

        private void btnPensionAge_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime pensionDateMen = now.AddYears(-65);
            DateTime pensionDateWomen = now.AddYears(-60);

            var query = employeesTable.AsEnumerable()
                .Where(row => row.Field<DateTime>("ДатаРождения") <= pensionDateMen ||
                             row.Field<DateTime>("ДатаРождения") <= pensionDateWomen);

            DisplayQueryResult(query);
        }

        private void btnAboveAvgSalary_Click(object sender, EventArgs e)
        {
            decimal avgSalary = employeesTable.AsEnumerable()
                .Average(row => row.Field<decimal>("Оклад"));

            var query = employeesTable.AsEnumerable()
                .Where(row => row.Field<decimal>("Оклад") > avgSalary);

            DisplayQueryResult(query);
        }

        private void btnYounger30OnPosition_Click(object sender, EventArgs e)
        {
            if (listBoxPositions.SelectedItem == null)
            {
                MessageBox.Show("Выберите должность", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string position = listBoxPositions.SelectedItem.ToString();
            DateTime thresholdDate = DateTime.Now.AddYears(-30);

            var query = employeesTable.AsEnumerable()
                .Where(row => row.Field<string>("Должность") == position &&
                             row.Field<DateTime>("ДатаРождения") > thresholdDate);

            DisplayQueryResult(query);
        }

        private void btnSortByLastName_Click(object sender, EventArgs e)
        {
            var query = employeesTable.AsEnumerable()
                .OrderBy(row => row.Field<string>("Фамилия"));

            DisplayQueryResult(query);
        }

        private void btnSortBySalaryDesc_Click(object sender, EventArgs e)
        {
            var query = employeesTable.AsEnumerable()
                .OrderByDescending(row => row.Field<decimal>("Оклад"));

            DisplayQueryResult(query);
        }

        private void btnGroupByPosition_Click(object sender, EventArgs e)
        {
            var query = employeesTable.AsEnumerable()
                .GroupBy(row => row.Field<string>("Должность"));

            dataGridView2.Rows.Clear();

            foreach (var group in query)
            {
                dataGridView2.Rows.Add($"Должность: {group.Key}", "", "", "", "");

                foreach (var row in group)
                {
                    dataGridView2.Rows.Add(
                        row.Field<string>("Фамилия"),
                        row.Field<string>("Имя"),
                        row.Field<string>("Должность"),
                        row.Field<DateTime>("ДатаРождения").ToShortDateString(),
                        row.Field<decimal>("Оклад")
                    );
                }
                dataGridView2.Rows.Add("", "", "", "", ""); // Пустая строка между группами
            }
        }

        private void btnAvgSalaryByPosition_Click(object sender, EventArgs e)
        {
            var query = employeesTable.AsEnumerable()
                .GroupBy(row => row.Field<string>("Должность"))
                .Select(group => new {
                    Position = group.Key,
                    AvgSalary = group.Average(row => row.Field<decimal>("Оклад"))
                });

            dataGridView2.Rows.Clear();

            foreach (var item in query)
            {
                dataGridView2.Rows.Add(
                    item.Position,
                    $"Средний оклад: {item.AvgSalary:F2} руб.",
                    "", "", ""
                );
            }
        }

        private void btnSalaryReport_Click(object sender, EventArgs e)
        {
            var query = employeesTable.AsEnumerable()
                .OrderByDescending(row => row.Field<decimal>("Оклад"))
                .Select(row => new {
                    FullName = $"{row.Field<string>("Фамилия")} {row.Field<string>("Имя")}",
                    Salary = row.Field<decimal>("Оклад")
                });

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            dataGridView2.Columns.Add("Column1", "ФИО");
            dataGridView2.Columns.Add("Column2", "Оклад");

            foreach (var item in query)
            {
                dataGridView2.Rows.Add(item.FullName, item.Salary);
            }
        }
    }
}