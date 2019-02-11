namespace VirtualMessManager
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_loginStatusMem = new System.Windows.Forms.TextBox();
            this.pictureBoxMem = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.memBazarHistory = new System.Windows.Forms.Button();
            this.memMealHistory = new System.Windows.Forms.Button();
            this.memBookMeal = new System.Windows.Forms.Button();
            this.memMemberInfo = new System.Windows.Forms.Button();
            this.memAddBazar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb_loginStatusMem);
            this.panel1.Controls.Add(this.pictureBoxMem);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.memBazarHistory);
            this.panel1.Controls.Add(this.memMealHistory);
            this.panel1.Controls.Add(this.memBookMeal);
            this.panel1.Controls.Add(this.memMemberInfo);
            this.panel1.Controls.Add(this.memAddBazar);
            this.panel1.Location = new System.Drawing.Point(42, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 344);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tb_loginStatusMem
            // 
            this.tb_loginStatusMem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tb_loginStatusMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_loginStatusMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loginStatusMem.Location = new System.Drawing.Point(141, 8);
            this.tb_loginStatusMem.Name = "tb_loginStatusMem";
            this.tb_loginStatusMem.Size = new System.Drawing.Size(116, 14);
            this.tb_loginStatusMem.TabIndex = 10;
            // 
            // pictureBoxMem
            // 
            this.pictureBoxMem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMem.Image")));
            this.pictureBoxMem.Location = new System.Drawing.Point(25, 3);
            this.pictureBoxMem.Name = "pictureBoxMem";
            this.pictureBoxMem.Size = new System.Drawing.Size(113, 120);
            this.pictureBoxMem.TabIndex = 9;
            this.pictureBoxMem.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(349, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sign&Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // memBazarHistory
            // 
            this.memBazarHistory.BackColor = System.Drawing.Color.SpringGreen;
            this.memBazarHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memBazarHistory.Location = new System.Drawing.Point(216, 203);
            this.memBazarHistory.Name = "memBazarHistory";
            this.memBazarHistory.Size = new System.Drawing.Size(208, 68);
            this.memBazarHistory.TabIndex = 4;
            this.memBazarHistory.Text = "See Bazar History";
            this.memBazarHistory.UseVisualStyleBackColor = false;
            this.memBazarHistory.Click += new System.EventHandler(this.memBazarHistory_Click);
            // 
            // memMealHistory
            // 
            this.memMealHistory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.memMealHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memMealHistory.Location = new System.Drawing.Point(25, 203);
            this.memMealHistory.Name = "memMealHistory";
            this.memMealHistory.Size = new System.Drawing.Size(191, 68);
            this.memMealHistory.TabIndex = 3;
            this.memMealHistory.Text = "See Booked Meal";
            this.memMealHistory.UseVisualStyleBackColor = false;
            this.memMealHistory.Click += new System.EventHandler(this.memMealHistory_Click);
            // 
            // memBookMeal
            // 
            this.memBookMeal.BackColor = System.Drawing.Color.Teal;
            this.memBookMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memBookMeal.Location = new System.Drawing.Point(180, 134);
            this.memBookMeal.Name = "memBookMeal";
            this.memBookMeal.Size = new System.Drawing.Size(117, 69);
            this.memBookMeal.TabIndex = 2;
            this.memBookMeal.Text = "Book Meal";
            this.memBookMeal.UseVisualStyleBackColor = false;
            this.memBookMeal.Click += new System.EventHandler(this.memBookMeal_Click);
            // 
            // memMemberInfo
            // 
            this.memMemberInfo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.memMemberInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memMemberInfo.Location = new System.Drawing.Point(297, 134);
            this.memMemberInfo.Name = "memMemberInfo";
            this.memMemberInfo.Size = new System.Drawing.Size(127, 69);
            this.memMemberInfo.TabIndex = 2;
            this.memMemberInfo.Text = "Member Info";
            this.memMemberInfo.UseVisualStyleBackColor = false;
            this.memMemberInfo.Click += new System.EventHandler(this.memMemberInfo_Click);
            // 
            // memAddBazar
            // 
            this.memAddBazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.memAddBazar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memAddBazar.Location = new System.Drawing.Point(25, 134);
            this.memAddBazar.Name = "memAddBazar";
            this.memAddBazar.Size = new System.Drawing.Size(155, 69);
            this.memAddBazar.TabIndex = 0;
            this.memAddBazar.Text = "Add Bazar";
            this.memAddBazar.UseVisualStyleBackColor = false;
            this.memAddBazar.Click += new System.EventHandler(this.memAddBazar_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(547, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button memBazarHistory;
        private System.Windows.Forms.Button memMealHistory;
        private System.Windows.Forms.Button memBookMeal;
        private System.Windows.Forms.Button memMemberInfo;
        private System.Windows.Forms.Button memAddBazar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxMem;
        private System.Windows.Forms.TextBox tb_loginStatusMem;
    }
}