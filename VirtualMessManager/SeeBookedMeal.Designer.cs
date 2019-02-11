namespace VirtualMessManager
{
    partial class SeeBookedMeal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeBookedMeal));
            this.gv_MealHistory = new System.Windows.Forms.DataGridView();
            this.dt_FromMealHistory = new System.Windows.Forms.DateTimePicker();
            this.dt_ToMealHistory = new System.Windows.Forms.DateTimePicker();
            this.bt_LoadMeal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Back = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gv_MealHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_MealHistory
            // 
            this.gv_MealHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_MealHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_MealHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_MealHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_MealHistory.Location = new System.Drawing.Point(23, 109);
            this.gv_MealHistory.Name = "gv_MealHistory";
            this.gv_MealHistory.Size = new System.Drawing.Size(743, 281);
            this.gv_MealHistory.TabIndex = 1;
            this.toolTip1.SetToolTip(this.gv_MealHistory, "This will show all the current booked meals in the chart.");
            // 
            // dt_FromMealHistory
            // 
            this.dt_FromMealHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FromMealHistory.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FromMealHistory.Location = new System.Drawing.Point(189, 66);
            this.dt_FromMealHistory.Name = "dt_FromMealHistory";
            this.dt_FromMealHistory.Size = new System.Drawing.Size(122, 24);
            this.dt_FromMealHistory.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dt_FromMealHistory, "Starting Date of Search");
            this.dt_FromMealHistory.Value = new System.DateTime(2018, 8, 1, 0, 0, 0, 0);
            // 
            // dt_ToMealHistory
            // 
            this.dt_ToMealHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ToMealHistory.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ToMealHistory.Location = new System.Drawing.Point(371, 66);
            this.dt_ToMealHistory.Name = "dt_ToMealHistory";
            this.dt_ToMealHistory.Size = new System.Drawing.Size(120, 24);
            this.dt_ToMealHistory.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dt_ToMealHistory, "Ending Date of Search");
            // 
            // bt_LoadMeal
            // 
            this.bt_LoadMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_LoadMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_LoadMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LoadMeal.ForeColor = System.Drawing.Color.White;
            this.bt_LoadMeal.Location = new System.Drawing.Point(508, 62);
            this.bt_LoadMeal.Name = "bt_LoadMeal";
            this.bt_LoadMeal.Size = new System.Drawing.Size(126, 35);
            this.bt_LoadMeal.TabIndex = 3;
            this.bt_LoadMeal.Text = "L&oad";
            this.toolTip1.SetToolTip(this.bt_LoadMeal, "This will give you a view of selected days from the date boxes.\r\n*Choose your des" +
        "ire dates to see the booked meals in between them.");
            this.bt_LoadMeal.UseVisualStyleBackColor = false;
            this.bt_LoadMeal.Click += new System.EventHandler(this.bt_LoadMeal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(330, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // bt_Back
            // 
            this.bt_Back.BackColor = System.Drawing.Color.Red;
            this.bt_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Back.ForeColor = System.Drawing.Color.White;
            this.bt_Back.Location = new System.Drawing.Point(544, 410);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(108, 39);
            this.bt_Back.TabIndex = 3;
            this.bt_Back.Text = "B&ack";
            this.toolTip1.SetToolTip(this.bt_Back, "Takes you back in the previous page.");
            this.bt_Back.UseVisualStyleBackColor = false;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.ForeColor = System.Drawing.Color.White;
            this.bt_Exit.Location = new System.Drawing.Point(658, 410);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(108, 39);
            this.bt_Exit.TabIndex = 3;
            this.bt_Exit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.bt_Exit, "Exits from the System");
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(295, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "Booked Meals";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(640, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update/&Delete";
            this.toolTip1.SetToolTip(this.button1, "This will take you to the Edit/Delete option of Booked Meals.\r\n*Only Manger can e" +
        "nter in this section.\r\n*Members can only view.\r\n");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Hint !";
            // 
            // SeeBookedMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.bt_LoadMeal);
            this.Controls.Add(this.dt_ToMealHistory);
            this.Controls.Add(this.dt_FromMealHistory);
            this.Controls.Add(this.gv_MealHistory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeeBookedMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeeBookedMeal";
            this.Load += new System.EventHandler(this.SeeBookedMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_MealHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gv_MealHistory;
        private System.Windows.Forms.DateTimePicker dt_FromMealHistory;
        private System.Windows.Forms.DateTimePicker dt_ToMealHistory;
        private System.Windows.Forms.Button bt_LoadMeal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}