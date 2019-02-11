namespace VirtualMessManager
{
    partial class Book_Meal
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
            this.dateTime_BookMeal = new System.Windows.Forms.DateTimePicker();
            this.cb_Breakfast = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Lunch = new System.Windows.Forms.ComboBox();
            this.cb_Dinner = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_book = new System.Windows.Forms.Button();
            this.bt_Back = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTime_BookMeal
            // 
            this.dateTime_BookMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_BookMeal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_BookMeal.Location = new System.Drawing.Point(22, 114);
            this.dateTime_BookMeal.Name = "dateTime_BookMeal";
            this.dateTime_BookMeal.Size = new System.Drawing.Size(110, 26);
            this.dateTime_BookMeal.TabIndex = 0;
            // 
            // cb_Breakfast
            // 
            this.cb_Breakfast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Breakfast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Breakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Breakfast.FormattingEnabled = true;
            this.cb_Breakfast.Items.AddRange(new object[] {
            "0.5",
            "0"});
            this.cb_Breakfast.Location = new System.Drawing.Point(157, 114);
            this.cb_Breakfast.Name = "cb_Breakfast";
            this.cb_Breakfast.Size = new System.Drawing.Size(80, 28);
            this.cb_Breakfast.TabIndex = 1;
            this.cb_Breakfast.SelectedIndexChanged += new System.EventHandler(this.cb_Breakfast_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Your Meal Before 12AM of any Current Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // cb_Lunch
            // 
            this.cb_Lunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Lunch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Lunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Lunch.FormattingEnabled = true;
            this.cb_Lunch.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cb_Lunch.Location = new System.Drawing.Point(277, 117);
            this.cb_Lunch.Name = "cb_Lunch";
            this.cb_Lunch.Size = new System.Drawing.Size(80, 28);
            this.cb_Lunch.TabIndex = 1;
            // 
            // cb_Dinner
            // 
            this.cb_Dinner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Dinner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Dinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Dinner.FormattingEnabled = true;
            this.cb_Dinner.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cb_Dinner.Location = new System.Drawing.Point(396, 117);
            this.cb_Dinner.Name = "cb_Dinner";
            this.cb_Dinner.Size = new System.Drawing.Size(80, 28);
            this.cb_Dinner.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Breakfast";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lunch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dinner";
            // 
            // bt_book
            // 
            this.bt_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_book.Location = new System.Drawing.Point(322, 178);
            this.bt_book.Name = "bt_book";
            this.bt_book.Size = new System.Drawing.Size(93, 36);
            this.bt_book.TabIndex = 4;
            this.bt_book.Text = "B&ook";
            this.bt_book.UseVisualStyleBackColor = true;
            this.bt_book.Click += new System.EventHandler(this.bt_book_Click);
            // 
            // bt_Back
            // 
            this.bt_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Back.Location = new System.Drawing.Point(303, 246);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(93, 36);
            this.bt_Back.TabIndex = 4;
            this.bt_Back.Text = "B&ack";
            this.bt_Back.UseVisualStyleBackColor = true;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(405, 246);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(93, 36);
            this.bt_Exit.TabIndex = 4;
            this.bt_Exit.Text = "E&xit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Book_Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(533, 312);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.bt_book);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Dinner);
            this.Controls.Add(this.cb_Lunch);
            this.Controls.Add(this.cb_Breakfast);
            this.Controls.Add(this.dateTime_BookMeal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Book_Meal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Meal";
            this.Load += new System.EventHandler(this.Book_Meal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime_BookMeal;
        private System.Windows.Forms.ComboBox cb_Breakfast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Lunch;
        private System.Windows.Forms.ComboBox cb_Dinner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_book;
        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.Button bt_Exit;
    }
}