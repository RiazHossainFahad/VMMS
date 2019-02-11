namespace VirtualMessManager
{
    partial class EditMealChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMealChart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gv_EditMealSheet = new System.Windows.Forms.DataGridView();
            this.vmmMealChartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vMMDataSet = new VirtualMessManager.VMMDataSet();
            this.vmmMealChartTableAdapter = new VirtualMessManager.VMMDataSetTableAdapters.vmmMealChartTableAdapter();
            this.dt_AddAgainMealDate = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.cb_BreakfastMealSheet = new System.Windows.Forms.ComboBox();
            this.cb_lunchMealSheet = new System.Windows.Forms.ComboBox();
            this.cb_DinnerMealSheet = new System.Windows.Forms.ComboBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.dataSet2 = new VirtualMessManager.DataSet2();
            this.vmmMealChartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vmmMealChartTableAdapter1 = new VirtualMessManager.DataSet2TableAdapters.vmmMealChartTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakfastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refManagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_EditMealSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmmMealChartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmmMealChartBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1093, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gv_EditMealSheet
            // 
            this.gv_EditMealSheet.AutoGenerateColumns = false;
            this.gv_EditMealSheet.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_EditMealSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_EditMealSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_EditMealSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.memberIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.breakfastDataGridViewTextBoxColumn,
            this.lunchDataGridViewTextBoxColumn,
            this.dinnerDataGridViewTextBoxColumn,
            this.refManagerDataGridViewTextBoxColumn,
            this.totalMealDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.gv_EditMealSheet.DataSource = this.vmmMealChartBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_EditMealSheet.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_EditMealSheet.Location = new System.Drawing.Point(14, 87);
            this.gv_EditMealSheet.Name = "gv_EditMealSheet";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_EditMealSheet.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_EditMealSheet.Size = new System.Drawing.Size(1063, 320);
            this.gv_EditMealSheet.TabIndex = 1;
            this.gv_EditMealSheet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_EditMealSheet_CellClick_1);
            // 
            // vmmMealChartBindingSource
            // 
            this.vmmMealChartBindingSource.DataMember = "vmmMealChart";
            this.vmmMealChartBindingSource.DataSource = this.vMMDataSet;
            // 
            // vMMDataSet
            // 
            this.vMMDataSet.DataSetName = "VMMDataSet";
            this.vMMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vmmMealChartTableAdapter
            // 
            this.vmmMealChartTableAdapter.ClearBeforeFill = true;
            // 
            // dt_AddAgainMealDate
            // 
            this.dt_AddAgainMealDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_AddAgainMealDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_AddAgainMealDate.Location = new System.Drawing.Point(218, 40);
            this.dt_AddAgainMealDate.Name = "dt_AddAgainMealDate";
            this.dt_AddAgainMealDate.Size = new System.Drawing.Size(125, 24);
            this.dt_AddAgainMealDate.TabIndex = 2;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(361, 35);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(164, 32);
            this.tb_Name.TabIndex = 3;
            // 
            // cb_BreakfastMealSheet
            // 
            this.cb_BreakfastMealSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BreakfastMealSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BreakfastMealSheet.FormattingEnabled = true;
            this.cb_BreakfastMealSheet.Items.AddRange(new object[] {
            "0.5",
            "0"});
            this.cb_BreakfastMealSheet.Location = new System.Drawing.Point(553, 38);
            this.cb_BreakfastMealSheet.Name = "cb_BreakfastMealSheet";
            this.cb_BreakfastMealSheet.Size = new System.Drawing.Size(121, 26);
            this.cb_BreakfastMealSheet.TabIndex = 4;
            // 
            // cb_lunchMealSheet
            // 
            this.cb_lunchMealSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lunchMealSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_lunchMealSheet.FormattingEnabled = true;
            this.cb_lunchMealSheet.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cb_lunchMealSheet.Location = new System.Drawing.Point(710, 38);
            this.cb_lunchMealSheet.Name = "cb_lunchMealSheet";
            this.cb_lunchMealSheet.Size = new System.Drawing.Size(121, 26);
            this.cb_lunchMealSheet.TabIndex = 4;
            // 
            // cb_DinnerMealSheet
            // 
            this.cb_DinnerMealSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DinnerMealSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DinnerMealSheet.FormattingEnabled = true;
            this.cb_DinnerMealSheet.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cb_DinnerMealSheet.Location = new System.Drawing.Point(871, 40);
            this.cb_DinnerMealSheet.Name = "cb_DinnerMealSheet";
            this.cb_DinnerMealSheet.Size = new System.Drawing.Size(121, 26);
            this.cb_DinnerMealSheet.TabIndex = 4;
            // 
            // bt_Add
            // 
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(1017, 36);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(58, 31);
            this.bt_Add.TabIndex = 5;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Breakfast";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(873, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dinner";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(711, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lunch";
            // 
            // bt_exit
            // 
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(967, 425);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(87, 35);
            this.bt_exit.TabIndex = 7;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_back
            // 
            this.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(874, 425);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(87, 35);
            this.bt_back.TabIndex = 7;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vmmMealChartBindingSource1
            // 
            this.vmmMealChartBindingSource1.DataMember = "vmmMealChart";
            this.vmmMealChartBindingSource1.DataSource = this.dataSet2;
            // 
            // vmmMealChartTableAdapter1
            // 
            this.vmmMealChartTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // memberIdDataGridViewTextBoxColumn
            // 
            this.memberIdDataGridViewTextBoxColumn.DataPropertyName = "MemberId";
            this.memberIdDataGridViewTextBoxColumn.HeaderText = "MemberId";
            this.memberIdDataGridViewTextBoxColumn.Name = "memberIdDataGridViewTextBoxColumn";
            this.memberIdDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // breakfastDataGridViewTextBoxColumn
            // 
            this.breakfastDataGridViewTextBoxColumn.DataPropertyName = "Breakfast";
            this.breakfastDataGridViewTextBoxColumn.HeaderText = "Breakfast";
            this.breakfastDataGridViewTextBoxColumn.Name = "breakfastDataGridViewTextBoxColumn";
            // 
            // lunchDataGridViewTextBoxColumn
            // 
            this.lunchDataGridViewTextBoxColumn.DataPropertyName = "Lunch";
            this.lunchDataGridViewTextBoxColumn.HeaderText = "Lunch";
            this.lunchDataGridViewTextBoxColumn.Name = "lunchDataGridViewTextBoxColumn";
            // 
            // dinnerDataGridViewTextBoxColumn
            // 
            this.dinnerDataGridViewTextBoxColumn.DataPropertyName = "Dinner";
            this.dinnerDataGridViewTextBoxColumn.HeaderText = "Dinner";
            this.dinnerDataGridViewTextBoxColumn.Name = "dinnerDataGridViewTextBoxColumn";
            // 
            // refManagerDataGridViewTextBoxColumn
            // 
            this.refManagerDataGridViewTextBoxColumn.DataPropertyName = "refManager";
            this.refManagerDataGridViewTextBoxColumn.HeaderText = "refManager";
            this.refManagerDataGridViewTextBoxColumn.Name = "refManagerDataGridViewTextBoxColumn";
            // 
            // totalMealDataGridViewTextBoxColumn
            // 
            this.totalMealDataGridViewTextBoxColumn.DataPropertyName = "TotalMeal";
            this.totalMealDataGridViewTextBoxColumn.HeaderText = "TotalMeal";
            this.totalMealDataGridViewTextBoxColumn.Name = "totalMealDataGridViewTextBoxColumn";
            // 
            // Update
            // 
            this.Update.DataPropertyName = "Id";
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Id";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // EditMealChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 478);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.cb_DinnerMealSheet);
            this.Controls.Add(this.cb_lunchMealSheet);
            this.Controls.Add(this.cb_BreakfastMealSheet);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.dt_AddAgainMealDate);
            this.Controls.Add(this.gv_EditMealSheet);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMealChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMealChart";
            this.Load += new System.EventHandler(this.EditMealChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_EditMealSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmmMealChartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vmmMealChartBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gv_EditMealSheet;
        private VMMDataSet vMMDataSet;
        private System.Windows.Forms.BindingSource vmmMealChartBindingSource;
        private VMMDataSetTableAdapters.vmmMealChartTableAdapter vmmMealChartTableAdapter;
        private System.Windows.Forms.DateTimePicker dt_AddAgainMealDate;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox cb_BreakfastMealSheet;
        private System.Windows.Forms.ComboBox cb_lunchMealSheet;
        private System.Windows.Forms.ComboBox cb_DinnerMealSheet;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_back;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource vmmMealChartBindingSource1;
        private DataSet2TableAdapters.vmmMealChartTableAdapter vmmMealChartTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refManagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}