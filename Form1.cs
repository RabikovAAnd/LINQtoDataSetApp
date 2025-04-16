using System;
using System.Collections.Generic;
using System.Data;
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
            // Инициализация таблицы (в реальном приложении здесь будет загрузка из БД)
            InitializeSampleData();

            // Привязка основного DataGridView
            dataGridView1.DataSource = employeesTable;

            // Заполнение ListBox должностями
            var positions = employeesTable.AsEnumerable()
                .Select(row => row.Field<string>("Должность"))
                .Distinct()
                .ToList();
            listBoxPositions.DataSource = positions;
        }

        private void InitializeSampleData()
        {
            employeesTable = new DataTable("Сотрудники");

            // Создание колонок
            employeesTable.Columns.Add("Код", typeof(int));
            employeesTable.Columns.Add("Имя", typeof(string));
            employeesTable.Columns.Add("Фамилия", typeof(string));
            employeesTable.Columns.Add("Должность", typeof(string));
            employeesTable.Columns.Add("ДатаРождения", typeof(DateTime));
            employeesTable.Columns.Add("Оклад", typeof(decimal));

            // Добавление тестовых данных
            employeesTable.Rows.Add(1, "Иван", "Иванов", "Менеджер", new DateTime(1980, 5, 15), 50000);
            employeesTable.Rows.Add(2, "Петр", "Петров", "Разработчик", new DateTime(1990, 8, 22), 75000);
            employeesTable.Rows.Add(3, "Сергей", "Сергеев", "Разработчик", new DateTime(1995, 3, 10), 80000);
            employeesTable.Rows.Add(4, "Анна", "Смирнова", "Дизайнер", new DateTime(1985, 11, 5), 60000);
            employeesTable.Rows.Add(5, "Мария", "Кузнецова", "Менеджер", new DateTime(1975, 7, 30), 55000);
            employeesTable.Rows.Add(6, "Алексей", "Васильев", "Тестировщик", new DateTime(1992, 9, 18), 45000);
            employeesTable.Rows.Add(7, "Дмитрий", "Попов", "Разработчик", new DateTime(1988, 12, 3), 85000);
            employeesTable.Rows.Add(8, "Елена", "Новикова", "Дизайнер", new DateTime(1993, 4, 25), 65000);
        }

        private void DisplayQueryResult(IEnumerable<DataRow> query)
        {
            dataGridView2.Rows.Clear();

            foreach (DataRow row in query)
            {
                dataGridView2.Rows.Add(
                    row.Field<int>("Код"),
                    row.Field<string>("Фамилия"),
                    row.Field<string>("Имя"),
                    row.Field<string>("Должность"),
                    row.Field<DateTime>("ДатаРождения").ToShortDateString(),
                    row.Field<decimal>("Оклад")
                );
            }
        }

        // Обработчики кнопок для различных запросов
        private void btnAvgSalary_Click(object sender, EventArgs e)
        {
            decimal avgSalary = employeesTable.AsEnumerable()
                .Average(row => row.Field<decimal>("Оклад"));

            MessageBox.Show($"Средний оклад по компании: {avgSalary:F2}", "Результат");
        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите имя сотрудника", "Ошибка");
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
                MessageBox.Show("Выберите должность", "Ошибка");
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
            DateTime pensionDateMen = now.AddYears(-65); // Пенсионный возраст для мужчин
            DateTime pensionDateWomen = now.AddYears(-60); // Пенсионный возраст для женщин

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
                MessageBox.Show("Выберите должность", "Ошибка");
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
                dataGridView2.Rows.Add($"Должность: {group.Key}", "", "", "", "", "");

                foreach (var row in group)
                {
                    dataGridView2.Rows.Add(
                        row.Field<int>("Код"),
                        row.Field<string>("Фамилия"),
                        row.Field<string>("Имя"),
                        row.Field<string>("Должность"),
                        row.Field<DateTime>("ДатаРождения").ToShortDateString(),
                        row.Field<decimal>("Оклад")
                    );
                }
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
                    $"Средний оклад: {item.AvgSalary:F2}",
                    "", "", "", ""
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

            foreach (var item in query)
            {
                dataGridView2.Rows.Add(item.FullName, item.Salary, "", "", "", "");
            }
        }
    }
}