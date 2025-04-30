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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database3DataSet = new LINQtoDataSetApp.Database3DataSet();
            this.database3DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYounger30OnPosition = new System.Windows.Forms.Button();
            this.btnAboveAvgSalary = new System.Windows.Forms.Button();
            this.btnPensionAge = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxPositions = new System.Windows.Forms.ListBox();
            this.btnFindByPosition = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.btnAvgSalary = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalaryReport = new System.Windows.Forms.Button();
            this.btnAvgSalaryByPosition = new System.Windows.Forms.Button();
            this.btnGroupByPosition = new System.Windows.Forms.Button();
            this.btnSortBySalaryDesc = new System.Windows.Forms.Button();
            this.btnSortByLastName = new System.Windows.Forms.Button();
            this.работникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLINQ = new LINQtoDataSetApp.DataSetLINQ();
            this.database3DataSet1 = new LINQtoDataSetApp.Database3DataSet1();
            this.работникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.работникиTableAdapter = new LINQtoDataSetApp.Database3DataSet1TableAdapters.РаботникиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLINQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.database3DataSetBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(800, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // database3DataSetBindingSource
            // 
            this.database3DataSetBindingSource.DataSource = this.database3DataSet;
            this.database3DataSetBindingSource.Position = 0;
            // 
            // database3DataSet
            // 
            this.database3DataSet.DataSetName = "Database3DataSet";
            this.database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database3DataSetBindingSource1
            // 
            this.database3DataSetBindingSource1.DataSource = this.database3DataSet;
            this.database3DataSetBindingSource1.Position = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 335);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(800, 246);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходные данные:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Location = new System.Drawing.Point(824, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(333, 492);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запросы";
            // 
            // btnYounger30OnPosition
            // 
            this.btnYounger30OnPosition.Location = new System.Drawing.Point(8, 394);
            this.btnYounger30OnPosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnYounger30OnPosition.Name = "btnYounger30OnPosition";
            this.btnYounger30OnPosition.Size = new System.Drawing.Size(317, 37);
            this.btnYounger30OnPosition.TabIndex = 9;
            this.btnYounger30OnPosition.Text = "Моложе 30 на выбранной должности";
            this.btnYounger30OnPosition.UseVisualStyleBackColor = true;
            this.btnYounger30OnPosition.Click += new System.EventHandler(this.btnYounger30OnPosition_Click);
            // 
            // btnAboveAvgSalary
            // 
            this.btnAboveAvgSalary.Location = new System.Drawing.Point(8, 358);
            this.btnAboveAvgSalary.Margin = new System.Windows.Forms.Padding(4);
            this.btnAboveAvgSalary.Name = "btnAboveAvgSalary";
            this.btnAboveAvgSalary.Size = new System.Drawing.Size(317, 37);
            this.btnAboveAvgSalary.TabIndex = 8;
            this.btnAboveAvgSalary.Text = "Сотрудники с окладом выше среднего";
            this.btnAboveAvgSalary.UseVisualStyleBackColor = true;
            this.btnAboveAvgSalary.Click += new System.EventHandler(this.btnAboveAvgSalary_Click);
            // 
            // btnPensionAge
            // 
            this.btnPensionAge.Location = new System.Drawing.Point(8, 322);
            this.btnPensionAge.Margin = new System.Windows.Forms.Padding(4);
            this.btnPensionAge.Name = "btnPensionAge";
            this.btnPensionAge.Size = new System.Drawing.Size(317, 37);
            this.btnPensionAge.TabIndex = 7;
            this.btnPensionAge.Text = "Сотрудники пенсионного возраста";
            this.btnPensionAge.UseVisualStyleBackColor = true;
            this.btnPensionAge.Click += new System.EventHandler(this.btnPensionAge_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Должность:";
            // 
            // listBoxPositions
            // 
            this.listBoxPositions.FormattingEnabled = true;
            this.listBoxPositions.ItemHeight = 16;
            this.listBoxPositions.Location = new System.Drawing.Point(8, 198);
            this.listBoxPositions.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPositions.Name = "listBoxPositions";
            this.listBoxPositions.Size = new System.Drawing.Size(316, 116);
            this.listBoxPositions.TabIndex = 5;
            // 
            // btnFindByPosition
            // 
            this.btnFindByPosition.Location = new System.Drawing.Point(8, 137);
            this.btnFindByPosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindByPosition.Name = "btnFindByPosition";
            this.btnFindByPosition.Size = new System.Drawing.Size(317, 37);
            this.btnFindByPosition.TabIndex = 4;
            this.btnFindByPosition.Text = "Найти сотрудников по должности";
            this.btnFindByPosition.UseVisualStyleBackColor = true;
            this.btnFindByPosition.Click += new System.EventHandler(this.btnFindByPosition_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(8, 100);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(316, 22);
            this.txtName.TabIndex = 2;
            // 
            // btnFindByName
            // 
            this.btnFindByName.Location = new System.Drawing.Point(8, 59);
            this.btnFindByName.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(317, 37);
            this.btnFindByName.TabIndex = 1;
            this.btnFindByName.Text = "Найти сотрудника по имени";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // btnAvgSalary
            // 
            this.btnAvgSalary.Location = new System.Drawing.Point(8, 23);
            this.btnAvgSalary.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvgSalary.Name = "btnAvgSalary";
            this.btnAvgSalary.Size = new System.Drawing.Size(317, 37);
            this.btnAvgSalary.TabIndex = 0;
            this.btnAvgSalary.Text = "Средний оклад по компании";
            this.btnAvgSalary.UseVisualStyleBackColor = true;
            this.btnAvgSalary.Click += new System.EventHandler(this.btnAvgSalary_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSalaryReport);
            this.groupBox2.Controls.Add(this.btnAvgSalaryByPosition);
            this.groupBox2.Controls.Add(this.btnGroupByPosition);
            this.groupBox2.Controls.Add(this.btnSortBySalaryDesc);
            this.groupBox2.Controls.Add(this.btnSortByLastName);
            this.groupBox2.Location = new System.Drawing.Point(824, 521);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(333, 222);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции";
            // 
            // btnSalaryReport
            // 
            this.btnSalaryReport.Location = new System.Drawing.Point(8, 166);
            this.btnSalaryReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalaryReport.Name = "btnSalaryReport";
            this.btnSalaryReport.Size = new System.Drawing.Size(317, 37);
            this.btnSalaryReport.TabIndex = 4;
            this.btnSalaryReport.Text = "Справка об окладах";
            this.btnSalaryReport.UseVisualStyleBackColor = true;
            this.btnSalaryReport.Click += new System.EventHandler(this.btnSalaryReport_Click);
            // 
            // btnAvgSalaryByPosition
            // 
            this.btnAvgSalaryByPosition.Location = new System.Drawing.Point(8, 130);
            this.btnAvgSalaryByPosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvgSalaryByPosition.Name = "btnAvgSalaryByPosition";
            this.btnAvgSalaryByPosition.Size = new System.Drawing.Size(317, 37);
            this.btnAvgSalaryByPosition.TabIndex = 3;
            this.btnAvgSalaryByPosition.Text = "Средний оклад по должностям";
            this.btnAvgSalaryByPosition.UseVisualStyleBackColor = true;
            this.btnAvgSalaryByPosition.Click += new System.EventHandler(this.btnAvgSalaryByPosition_Click);
            // 
            // btnGroupByPosition
            // 
            this.btnGroupByPosition.Location = new System.Drawing.Point(8, 95);
            this.btnGroupByPosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupByPosition.Name = "btnGroupByPosition";
            this.btnGroupByPosition.Size = new System.Drawing.Size(317, 37);
            this.btnGroupByPosition.TabIndex = 2;
            this.btnGroupByPosition.Text = "Группировать по должностям";
            this.btnGroupByPosition.UseVisualStyleBackColor = true;
            this.btnGroupByPosition.Click += new System.EventHandler(this.btnGroupByPosition_Click);
            // 
            // btnSortBySalaryDesc
            // 
            this.btnSortBySalaryDesc.Location = new System.Drawing.Point(8, 59);
            this.btnSortBySalaryDesc.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortBySalaryDesc.Name = "btnSortBySalaryDesc";
            this.btnSortBySalaryDesc.Size = new System.Drawing.Size(317, 37);
            this.btnSortBySalaryDesc.TabIndex = 1;
            this.btnSortBySalaryDesc.Text = "Сортировать по убыванию оклада";
            this.btnSortBySalaryDesc.UseVisualStyleBackColor = true;
            this.btnSortBySalaryDesc.Click += new System.EventHandler(this.btnSortBySalaryDesc_Click);
            // 
            // btnSortByLastName
            // 
            this.btnSortByLastName.Location = new System.Drawing.Point(8, 23);
            this.btnSortByLastName.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortByLastName.Name = "btnSortByLastName";
            this.btnSortByLastName.Size = new System.Drawing.Size(317, 37);
            this.btnSortByLastName.TabIndex = 0;
            this.btnSortByLastName.Text = "Сортировать по фамилии";
            this.btnSortByLastName.UseVisualStyleBackColor = true;
            this.btnSortByLastName.Click += new System.EventHandler(this.btnSortByLastName_Click);
            // 
            // работникиBindingSource
            // 
            this.работникиBindingSource.DataMember = "Работники";
            this.работникиBindingSource.DataSource = this.dataSetLINQ;
            // 
            // dataSetLINQ
            // 
            this.dataSetLINQ.DataSetName = "DataSetLINQ";
            this.dataSetLINQ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database3DataSet1
            // 
            this.database3DataSet1.DataSetName = "Database3DataSet1";
            this.database3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // работникиBindingSource1
            // 
            this.работникиBindingSource1.DataMember = "Работники";
            this.работникиBindingSource1.DataSource = this.database3DataSet1;
            // 
            // работникиTableAdapter
            // 
            this.работникиTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 757);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1189, 794);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINQ to DataSet - Анализ сотрудников";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLINQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource работникиBindingSource;
        private DataSetLINQ dataSetLINQ;
        private System.Windows.Forms.BindingSource database3DataSetBindingSource;
        private Database3DataSet database3DataSet;
        private System.Windows.Forms.BindingSource database3DataSetBindingSource1;
        private Database3DataSet1 database3DataSet1;
        private System.Windows.Forms.BindingSource работникиBindingSource1;
        private Database3DataSet1TableAdapters.РаботникиTableAdapter работникиTableAdapter;
    }
}