namespace VirtualMessManager
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.pictureBoxManager = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_loginStatusMan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.manSeeBazar = new System.Windows.Forms.Button();
            this.manSeeBookedMeal = new System.Windows.Forms.Button();
            this.manBookMeal = new System.Windows.Forms.Button();
            this.manMemberInfo = new System.Windows.Forms.Button();
            this.manAddBazar = new System.Windows.Forms.Button();
            this.bt_signOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManager)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxManager
            // 
            this.pictureBoxManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxManager.BackgroundImage")));
            this.pictureBoxManager.Location = new System.Drawing.Point(0, 2);
            this.pictureBoxManager.Name = "pictureBoxManager";
            this.pictureBoxManager.Size = new System.Drawing.Size(449, 108);
            this.pictureBoxManager.TabIndex = 0;
            this.pictureBoxManager.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(450, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 108);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go to Admin Session";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bt_signOut);
            this.panel1.Controls.Add(this.tb_loginStatusMan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.manSeeBazar);
            this.panel1.Controls.Add(this.manSeeBookedMeal);
            this.panel1.Controls.Add(this.manBookMeal);
            this.panel1.Controls.Add(this.manMemberInfo);
            this.panel1.Controls.Add(this.manAddBazar);
            this.panel1.Location = new System.Drawing.Point(44, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 351);
            this.panel1.TabIndex = 2;
            // 
            // tb_loginStatusMan
            // 
            this.tb_loginStatusMan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tb_loginStatusMan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_loginStatusMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loginStatusMan.Location = new System.Drawing.Point(141, 8);
            this.tb_loginStatusMan.Name = "tb_loginStatusMan";
            this.tb_loginStatusMan.Size = new System.Drawing.Size(116, 14);
            this.tb_loginStatusMan.TabIndex = 6;
            this.tb_loginStatusMan.TextChanged += new System.EventHandler(this.tb_loginStatusMan_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 120);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // manSeeBazar
            // 
            this.manSeeBazar.BackColor = System.Drawing.Color.SpringGreen;
            this.manSeeBazar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manSeeBazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manSeeBazar.Location = new System.Drawing.Point(215, 204);
            this.manSeeBazar.Name = "manSeeBazar";
            this.manSeeBazar.Size = new System.Drawing.Size(206, 68);
            this.manSeeBazar.TabIndex = 4;
            this.manSeeBazar.Text = "See Bazar History";
            this.manSeeBazar.UseVisualStyleBackColor = false;
            this.manSeeBazar.Click += new System.EventHandler(this.manSeeBazar_Click);
            // 
            // manSeeBookedMeal
            // 
            this.manSeeBookedMeal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.manSeeBookedMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manSeeBookedMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manSeeBookedMeal.Location = new System.Drawing.Point(26, 204);
            this.manSeeBookedMeal.Name = "manSeeBookedMeal";
            this.manSeeBookedMeal.Size = new System.Drawing.Size(192, 68);
            this.manSeeBookedMeal.TabIndex = 3;
            this.manSeeBookedMeal.Text = "See Booked Meal";
            this.manSeeBookedMeal.UseVisualStyleBackColor = false;
            this.manSeeBookedMeal.Click += new System.EventHandler(this.manSeeBookedMeal_Click);
            // 
            // manBookMeal
            // 
            this.manBookMeal.BackColor = System.Drawing.Color.Teal;
            this.manBookMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manBookMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manBookMeal.Location = new System.Drawing.Point(179, 135);
            this.manBookMeal.Name = "manBookMeal";
            this.manBookMeal.Size = new System.Drawing.Size(117, 69);
            this.manBookMeal.TabIndex = 2;
            this.manBookMeal.Text = "Book Meal";
            this.manBookMeal.UseVisualStyleBackColor = false;
            this.manBookMeal.Click += new System.EventHandler(this.manBookMeal_Click);
            // 
            // manMemberInfo
            // 
            this.manMemberInfo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.manMemberInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manMemberInfo.Location = new System.Drawing.Point(294, 135);
            this.manMemberInfo.Name = "manMemberInfo";
            this.manMemberInfo.Size = new System.Drawing.Size(127, 69);
            this.manMemberInfo.TabIndex = 2;
            this.manMemberInfo.Text = "Member Info";
            this.manMemberInfo.UseVisualStyleBackColor = false;
            this.manMemberInfo.Click += new System.EventHandler(this.manMemberInfo_Click);
            // 
            // manAddBazar
            // 
            this.manAddBazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.manAddBazar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manAddBazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manAddBazar.Location = new System.Drawing.Point(26, 135);
            this.manAddBazar.Name = "manAddBazar";
            this.manAddBazar.Size = new System.Drawing.Size(155, 69);
            this.manAddBazar.TabIndex = 0;
            this.manAddBazar.Text = "Add Bazar";
            this.manAddBazar.UseVisualStyleBackColor = false;
            this.manAddBazar.Click += new System.EventHandler(this.manAddBazar_Click);
            // 
            // bt_signOut
            // 
            this.bt_signOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_signOut.Location = new System.Drawing.Point(352, 4);
            this.bt_signOut.Name = "bt_signOut";
            this.bt_signOut.Size = new System.Drawing.Size(90, 30);
            this.bt_signOut.TabIndex = 7;
            this.bt_signOut.Text = "Si&gnOut";
            this.bt_signOut.UseVisualStyleBackColor = false;
            this.bt_signOut.Click += new System.EventHandler(this.bt_signOut_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(548, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxManager);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManager)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button manSeeBazar;
        private System.Windows.Forms.Button manSeeBookedMeal;
        private System.Windows.Forms.Button manBookMeal;
        private System.Windows.Forms.Button manMemberInfo;
        private System.Windows.Forms.Button manAddBazar;
        private System.Windows.Forms.TextBox tb_loginStatusMan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_signOut;
    }
}