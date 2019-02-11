namespace VirtualMessManager
{
    partial class Calculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mealRate = new System.Windows.Forms.TextBox();
            this.cb_Member = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_totalBazar = new System.Windows.Forms.TextBox();
            this.tb_totalMeal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Deposit = new System.Windows.Forms.TextBox();
            this.tb_MealAmount = new System.Windows.Forms.TextBox();
            this.tb_Others = new System.Windows.Forms.TextBox();
            this.tb_Remarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_Calculate = new System.Windows.Forms.Button();
            this.bt_Next = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1104, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(746, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Meal Amount Calculation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Bazar Amount Calculation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 223);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(689, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(358, 226);
            this.dataGridView2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Per Meal Rate";
            // 
            // tb_mealRate
            // 
            this.tb_mealRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mealRate.Location = new System.Drawing.Point(501, 144);
            this.tb_mealRate.Multiline = true;
            this.tb_mealRate.Name = "tb_mealRate";
            this.tb_mealRate.Size = new System.Drawing.Size(116, 30);
            this.tb_mealRate.TabIndex = 3;
            this.tb_mealRate.TextChanged += new System.EventHandler(this.tb_mealRate_TextChanged);
            // 
            // cb_Member
            // 
            this.cb_Member.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Member.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Member.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Member.FormattingEnabled = true;
            this.cb_Member.Location = new System.Drawing.Point(125, 378);
            this.cb_Member.Name = "cb_Member";
            this.cb_Member.Size = new System.Drawing.Size(166, 28);
            this.cb_Member.TabIndex = 4;
            this.cb_Member.SelectedIndexChanged += new System.EventHandler(this.cb_Member_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Grand Total";
            // 
            // tb_totalBazar
            // 
            this.tb_totalBazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalBazar.Location = new System.Drawing.Point(285, 294);
            this.tb_totalBazar.Multiline = true;
            this.tb_totalBazar.Name = "tb_totalBazar";
            this.tb_totalBazar.Size = new System.Drawing.Size(116, 30);
            this.tb_totalBazar.TabIndex = 3;
            // 
            // tb_totalMeal
            // 
            this.tb_totalMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalMeal.Location = new System.Drawing.Point(827, 293);
            this.tb_totalMeal.Multiline = true;
            this.tb_totalMeal.Name = "tb_totalMeal";
            this.tb_totalMeal.Size = new System.Drawing.Size(116, 30);
            this.tb_totalMeal.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(716, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Meal";
            // 
            // tb_Deposit
            // 
            this.tb_Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Deposit.Location = new System.Drawing.Point(332, 376);
            this.tb_Deposit.Multiline = true;
            this.tb_Deposit.Name = "tb_Deposit";
            this.tb_Deposit.Size = new System.Drawing.Size(116, 30);
            this.tb_Deposit.TabIndex = 7;
            this.tb_Deposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Deposit_KeyPress);
            // 
            // tb_MealAmount
            // 
            this.tb_MealAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MealAmount.Location = new System.Drawing.Point(487, 376);
            this.tb_MealAmount.Multiline = true;
            this.tb_MealAmount.Name = "tb_MealAmount";
            this.tb_MealAmount.Size = new System.Drawing.Size(116, 30);
            this.tb_MealAmount.TabIndex = 8;
            this.tb_MealAmount.TextChanged += new System.EventHandler(this.tb_MealAmount_TextChanged);
            this.tb_MealAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_MealAmount_KeyPress);
            // 
            // tb_Others
            // 
            this.tb_Others.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Others.Location = new System.Drawing.Point(670, 376);
            this.tb_Others.Multiline = true;
            this.tb_Others.Name = "tb_Others";
            this.tb_Others.Size = new System.Drawing.Size(116, 30);
            this.tb_Others.TabIndex = 9;
            this.tb_Others.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Others_KeyPress);
            // 
            // tb_Remarks
            // 
            this.tb_Remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Remarks.Location = new System.Drawing.Point(827, 376);
            this.tb_Remarks.Multiline = true;
            this.tb_Remarks.Name = "tb_Remarks";
            this.tb_Remarks.Size = new System.Drawing.Size(116, 30);
            this.tb_Remarks.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Deposit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(486, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Meal Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(670, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Others";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(829, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Remarks";
            // 
            // bt_Calculate
            // 
            this.bt_Calculate.BackColor = System.Drawing.Color.DarkRed;
            this.bt_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Calculate.Location = new System.Drawing.Point(379, 432);
            this.bt_Calculate.Name = "bt_Calculate";
            this.bt_Calculate.Size = new System.Drawing.Size(123, 36);
            this.bt_Calculate.TabIndex = 16;
            this.bt_Calculate.Text = "Calculate";
            this.bt_Calculate.UseVisualStyleBackColor = false;
            this.bt_Calculate.Click += new System.EventHandler(this.bt_Calculate_Click);
            // 
            // bt_Next
            // 
            this.bt_Next.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Next.Location = new System.Drawing.Point(836, 432);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(123, 36);
            this.bt_Next.TabIndex = 17;
            this.bt_Next.Text = "B&ack";
            this.bt_Next.UseVisualStyleBackColor = false;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(965, 432);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(123, 36);
            this.bt_Exit.TabIndex = 18;
            this.bt_Exit.Text = "E&xit";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 481);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.bt_Calculate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Remarks);
            this.Controls.Add(this.tb_Others);
            this.Controls.Add(this.tb_MealAmount);
            this.Controls.Add(this.tb_Deposit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_totalMeal);
            this.Controls.Add(this.cb_Member);
            this.Controls.Add(this.tb_totalBazar);
            this.Controls.Add(this.tb_mealRate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculation";
            this.Load += new System.EventHandler(this.Calculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mealRate;
        private System.Windows.Forms.ComboBox cb_Member;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_totalBazar;
        private System.Windows.Forms.TextBox tb_totalMeal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Deposit;
        private System.Windows.Forms.TextBox tb_MealAmount;
        private System.Windows.Forms.TextBox tb_Others;
        private System.Windows.Forms.TextBox tb_Remarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_Calculate;
        private System.Windows.Forms.Button bt_Next;
        private System.Windows.Forms.Button bt_Exit;
    }
}