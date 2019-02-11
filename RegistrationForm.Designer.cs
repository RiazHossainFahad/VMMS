namespace VirtualMessManager
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_imagePath = new System.Windows.Forms.TextBox();
            this.rb_Manager = new System.Windows.Forms.RadioButton();
            this.rb_Member = new System.Windows.Forms.RadioButton();
            this.cb_bloodGroup = new System.Windows.Forms.ComboBox();
            this.cb_ManagerName = new System.Windows.Forms.ComboBox();
            this.cb_MessName = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.date_dob = new System.Windows.Forms.DateTimePicker();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMessName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.tb_imagePath);
            this.panel1.Controls.Add(this.rb_Manager);
            this.panel1.Controls.Add(this.rb_Member);
            this.panel1.Controls.Add(this.cb_bloodGroup);
            this.panel1.Controls.Add(this.cb_ManagerName);
            this.panel1.Controls.Add(this.cb_MessName);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_Confirm);
            this.panel1.Controls.Add(this.date_dob);
            this.panel1.Controls.Add(this.tb_Phone);
            this.panel1.Controls.Add(this.tb_Password);
            this.panel1.Controls.Add(this.tb_userName);
            this.panel1.Controls.Add(this.tb_Name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Browse);
            this.panel1.Controls.Add(this.profilePic);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 483);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tb_imagePath
            // 
            this.tb_imagePath.Location = new System.Drawing.Point(363, 147);
            this.tb_imagePath.Name = "tb_imagePath";
            this.tb_imagePath.Size = new System.Drawing.Size(99, 22);
            this.tb_imagePath.TabIndex = 13;
            this.tb_imagePath.Visible = false;
            // 
            // rb_Manager
            // 
            this.rb_Manager.AutoSize = true;
            this.rb_Manager.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Manager.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rb_Manager.Location = new System.Drawing.Point(150, 117);
            this.rb_Manager.Name = "rb_Manager";
            this.rb_Manager.Size = new System.Drawing.Size(80, 21);
            this.rb_Manager.TabIndex = 12;
            this.rb_Manager.TabStop = true;
            this.rb_Manager.Text = "Manager";
            this.rb_Manager.UseVisualStyleBackColor = true;
            this.rb_Manager.CheckedChanged += new System.EventHandler(this.rb_Manager_CheckedChanged_1);
            // 
            // rb_Member
            // 
            this.rb_Member.AutoSize = true;
            this.rb_Member.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Member.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rb_Member.Location = new System.Drawing.Point(25, 117);
            this.rb_Member.Name = "rb_Member";
            this.rb_Member.Size = new System.Drawing.Size(77, 21);
            this.rb_Member.TabIndex = 12;
            this.rb_Member.TabStop = true;
            this.rb_Member.Text = "Member";
            this.rb_Member.UseVisualStyleBackColor = true;
            this.rb_Member.CheckedChanged += new System.EventHandler(this.rb_Member_CheckedChanged);
            // 
            // cb_bloodGroup
            // 
            this.cb_bloodGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_bloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_bloodGroup.FormattingEnabled = true;
            this.cb_bloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cb_bloodGroup.Location = new System.Drawing.Point(150, 289);
            this.cb_bloodGroup.Name = "cb_bloodGroup";
            this.cb_bloodGroup.Size = new System.Drawing.Size(148, 21);
            this.cb_bloodGroup.TabIndex = 11;
            // 
            // cb_ManagerName
            // 
            this.cb_ManagerName.FormattingEnabled = true;
            this.cb_ManagerName.Location = new System.Drawing.Point(150, 152);
            this.cb_ManagerName.Name = "cb_ManagerName";
            this.cb_ManagerName.Size = new System.Drawing.Size(191, 21);
            this.cb_ManagerName.TabIndex = 11;
            // 
            // cb_MessName
            // 
            this.cb_MessName.FormattingEnabled = true;
            this.cb_MessName.Location = new System.Drawing.Point(150, 196);
            this.cb_MessName.Name = "cb_MessName";
            this.cb_MessName.Size = new System.Drawing.Size(191, 21);
            this.cb_MessName.TabIndex = 11;
            this.cb_MessName.SelectedIndexChanged += new System.EventHandler(this.cb_MessName_SelectedIndexChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancel.Location = new System.Drawing.Point(220, 439);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(117, 32);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Confirm.Location = new System.Drawing.Point(337, 439);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(117, 32);
            this.btn_Confirm.TabIndex = 10;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // date_dob
            // 
            this.date_dob.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_dob.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.date_dob.CalendarMonthBackground = System.Drawing.Color.DodgerBlue;
            this.date_dob.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.date_dob.CalendarTrailingForeColor = System.Drawing.Color.DodgerBlue;
            this.date_dob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_dob.Location = new System.Drawing.Point(150, 241);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(148, 23);
            this.date_dob.TabIndex = 9;
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.Color.DodgerBlue;
            this.tb_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Phone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tb_Phone.Location = new System.Drawing.Point(150, 394);
            this.tb_Phone.Multiline = true;
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(148, 28);
            this.tb_Phone.TabIndex = 8;
            this.tb_Phone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tb_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Phone_KeyPress);
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.DodgerBlue;
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tb_Password.Location = new System.Drawing.Point(150, 360);
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = 'x';
            this.tb_Password.Size = new System.Drawing.Size(148, 28);
            this.tb_Password.TabIndex = 8;
            // 
            // tb_userName
            // 
            this.tb_userName.BackColor = System.Drawing.Color.DodgerBlue;
            this.tb_userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_userName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tb_userName.Location = new System.Drawing.Point(150, 326);
            this.tb_userName.Multiline = true;
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(148, 28);
            this.tb_userName.TabIndex = 8;
            this.tb_userName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_userName_Validating);
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.DodgerBlue;
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.ForeColor = System.Drawing.Color.AliceBlue;
            this.tb_Name.Location = new System.Drawing.Point(150, 71);
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(194, 27);
            this.tb_Name.TabIndex = 4;
            this.tb_Name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Name_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(22, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "D. O. B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(16, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(16, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Password";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(16, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(16, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Blood Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(22, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mess Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(22, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Manager Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Browse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Browse.Location = new System.Drawing.Point(363, 114);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(102, 27);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // profilePic
            // 
            this.profilePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePic.BackgroundImage")));
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profilePic.Location = new System.Drawing.Point(361, 9);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(101, 102);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 1;
            this.profilePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Form";
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorMessName
            // 
            this.errorMessName.ContainerControl = this;
            // 
            // errorUsername
            // 
            this.errorUsername.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(533, 507);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_dob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.RadioButton rb_Manager;
        private System.Windows.Forms.RadioButton rb_Member;
        private System.Windows.Forms.ComboBox cb_MessName;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_bloodGroup;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorMessName;
        private System.Windows.Forms.ErrorProvider errorUsername;
        private System.Windows.Forms.TextBox tb_imagePath;
        private System.Windows.Forms.ComboBox cb_ManagerName;
    }
}

