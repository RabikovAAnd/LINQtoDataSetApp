namespace LINQtoDataSetApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAvgSalary = new System.Windows.Forms.Button();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFindByPosition = new System.Windows.Forms.Button();
            this.listBoxPositions = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPensionAge = new System.Windows.Forms.Button();
            this.btnAboveAvgSalary = new System.Windows.Forms.Button();
            this.btnYounger30OnPosition = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSortByLastName = new System.Windows.Forms.Button();
            this.btnSortBySalaryDesc = new System.Windows.Forms.Button();
            this.btnGroupByPosition = new System.Windows.Forms.Button();
            this.btnAvgSalaryByPosition = new System.Windows.Forms.Button();
            this.btnSalaryReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 200);
            this.dataGridView1.TabIndex = 0;

            // dataGridView2
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(600, 200);
            this.dataGridView2.TabIndex = 1;

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходные данные:";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат:";

            // groupBox1
            this.groupBox1.Controls.Add(this.btnYounger30OnPosition);
            this.groupBox1.Controls.Add(this.btnAboveAvgSalary);
            this.groupBox1.Controls.Add(this.btnPensionAge);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBoxPositions);
            this.groupBox1.Controls.Add(this.btnFindByPosition);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnFindByName);
            this.groupBox1.Controls.Add(this.btnAvgSalary);
            this.groupBox1.Location = new System.Drawing.Point(618, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 400);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запросы";

            // btnAvgSalary
            this.btnAvgSalary.Location = new System.Drawing.Point(6, 19);
            this.btnAvgSalary.Name = "btnAvgSalary";
            this.btnAvgSalary.Size = new System.Drawing.Size(238, 23);
            this.btnAvgSalary.TabIndex = 0;
            this.btnAvgSalary.Text = "Средний оклад по компании";
            this.btnAvgSalary.UseVisualStyleBackColor = true;
            this.btnAvgSalary.Click += new System.EventHandler(this.btnAvgSalary_Click);

            // btnFindByName
            this.btnFindByName.Location = new System.Drawing.Point(6, 77);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(238, 23);
            this.btnFindByName.TabIndex = 1;
            this.btnFindByName.Text = "Найти сотрудника по имени";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);

            // txtName
            this.txtName.Location = new System.Drawing.Point(6, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 20);
            this.txtName.TabIndex = 2;

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя:";

            // btnFindByPosition
            this.btnFindByPosition.Location = new System.Drawing.Point(6, 161);
            this.btnFindByPosition.Name = "btnFindByPosition";
            this.btnFindByPosition.Size = new System.Drawing.Size(238, 23);
            this.btnFindByPosition.TabIndex = 4;
            this.btnFindByPosition.Text = "Найти сотрудников по должности";
            this.btnFindByPosition.UseVisualStyleBackColor = true;
            this.btnFindByPosition.Click += new System.EventHandler(this.btnFindByPosition_Click);

            // listBoxPositions
            this.listBoxPositions.FormattingEnabled = true;
            this.listBoxPositions.Location = new System.Drawing.Point(6, 187);
            this.listBoxPositions.Name = "listBoxPositions";
            this.listBoxPositions.Size = new System.Drawing.Size(238, 69);
            this.listBoxPositions.TabIndex = 5;

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Должность:";

            // btnPensionAge
            this.btnPensionAge.Location = new System.Drawing.Point(6, 262);
            this.btnPensionAge.Name = "btnPensionAge";
            this.btnPensionAge.Size = new System.Drawing.Size(238, 23);
            this.btnPensionAge.TabIndex = 7;
            this.btnPensionAge.Text = "Сотрудники пенсионного возраста";
            this.btnPensionAge.UseVisualStyleBackColor = true;
            this.btnPensionAge.Click += new System.EventHandler(this.btnPensionAge_Click);

            // btnAboveAvgSalary
            this.btnAboveAvgSalary.Location = new System.Drawing.Point(6, 291);
            this.btnAboveAvgSalary.Name = "btnAboveAvgSalary";
            this.btnAboveAvgSalary.Size = new System.Drawing.Size(238, 23);
            this.btnAboveAvgSalary.TabIndex = 8;
            this.btnAboveAvgSalary.Text = "Сотрудники с окладом выше среднего";
            this.btnAboveAvgSalary.UseVisualStyleBackColor = true;
            this.btnAboveAvgSalary.Click += new System.EventHandler(this.btnAboveAvgSalary_Click);

            // btnYounger30OnPosition
            this.btnYounger30OnPosition.Location = new System.Drawing.Point(6, 320);
            this.btnYounger30OnPosition.Name = "btnYounger30OnPosition";
            this.btnYounger30OnPosition.Size = new System.Drawing.Size(238, 23);
            this.btnYounger30OnPosition.TabIndex = 9;
            this.btnYounger30OnPosition.Text = "Моложе 30 на выбранной должности";
            this.btnYounger30OnPosition.UseVisualStyleBackColor = true;
            this.btnYounger30OnPosition.Click += new System.EventHandler(this.btnYounger30OnPosition_Click);

            // groupBox2
            this.groupBox2.Controls.Add(this.btnSalaryReport);
            this.groupBox2.Controls.Add(this.btnAvgSalaryByPosition);
            this.groupBox2.Controls.Add(this.btnGroupByPosition);
            this.groupBox2.Controls.Add(this.btnSortBySalaryDesc);
            this.groupBox2.Controls.Add(this.btnSortByLastName);
            this.groupBox2.Location = new System.Drawing.Point(618, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 180);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции";

            // btnSortByLastName
            this.btnSortByLastName.Location = new System.Drawing.Point(6, 19);
            this.btnSortByLastName.Name = "btnSortByLastName";
            this.btnSortByLastName.Size = new System.Drawing.Size(238, 23);
            this.btnSortByLastName.TabIndex = 0;
            this.btnSortByLastName.Text = "Сортировать по фамилии";
            this.btnSortByLastName.UseVisualStyleBackColor = true;
            this.btnSortByLastName.Click += new System.EventHandler(this.btnSortByLastName_Click);

            // btnSortBySalaryDesc
            this.btnSortBySalaryDesc.Location = new System.Drawing.Point(6, 48);
            this.btnSortBySalaryDesc.Name = "btnSortBySalaryDesc";
            this.btnSortBySalaryDesc.Size = new System.Drawing.Size(238, 23);
            this.btnSortBySalaryDesc.TabIndex = 1;
            this.btnSortBySalaryDesc.Text = "Сортировать по убыванию оклада";
            this.btnSortBySalaryDesc.UseVisualStyleBackColor = true;
            this.btnSortBySalaryDesc.Click += new System.EventHandler(this.btnSortBySalaryDesc_Click);

            // btnGroupByPosition
            this.btnGroupByPosition.Location = new System.Drawing.Point(6, 77);
            this.btnGroupByPosition.Name = "btnGroupByPosition";
            this.btnGroupByPosition.Size = new System.Drawing.Size(238, 23);
            this.btnGroupByPosition.TabIndex = 2;
            this.btnGroupByPosition.Text = "Группировать по должностям";
            this.btnGroupByPosition.UseVisualStyleBackColor = true;
            this.btnGroupByPosition.Click += new System.EventHandler(this.btnGroupByPosition_Click);

            // btnAvgSalaryByPosition
            this.btnAvgSalaryByPosition.Location = new System.Drawing.Point(6, 106);
            this.btnAvgSalaryByPosition.Name = "btnAvgSalaryByPosition";
            this.btnAvgSalaryByPosition.Size = new System.Drawing.Size(238, 23);
            this.btnAvgSalaryByPosition.TabIndex = 3;
            this.btnAvgSalaryByPosition.Text = "Средний оклад по должностям";
            this.btnAvgSalaryByPosition.UseVisualStyleBackColor = true;
            this.btnAvgSalaryByPosition.Click += new System.EventHandler(this.btnAvgSalaryByPosition_Click);

            // btnSalaryReport
            this.btnSalaryReport.Location = new System.Drawing.Point(6, 135);
            this.btnSalaryReport.Name = "btnSalaryReport";
            this.btnSalaryReport.Size = new System.Drawing.Size(238, 23);
            this.btnSalaryReport.TabIndex = 4;
            this.btnSalaryReport.Text = "Справка об окладах";
            this.btnSalaryReport.UseVisualStyleBackColor = true;
            this.btnSalaryReport.Click += new System.EventHandler(this.btnSalaryReport_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "LINQ to DataSet - Работа с сотрудниками";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYounger30OnPosition;
        private System.Windows.Forms.Button btnAboveAvgSalary;
        private System.Windows.Forms.Button btnPensionAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxPositions;
        private System.Windows.Forms.Button btnFindByPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.Button btnAvgSalary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalaryReport;
        private System.Windows.Forms.Button btnAvgSalaryByPosition;
        private System.Windows.Forms.Button btnGroupByPosition;
        private System.Windows.Forms.Button btnSortBySalaryDesc;
        private System.Windows.Forms.Button btnSortByLastName;
    }
}