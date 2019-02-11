using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vmmBAL;
using vmmBLL;

namespace VirtualMessManager
{
    public partial class ChangePassword : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        string userType;
        public ChangePassword(string u_Type)
        {
            this.userType = u_Type;
            InitializeComponent();
            textBoxOldPass.PasswordChar = '*';
            textBoxNewPass.PasswordChar = '*';
            textBoxConfirmPass.PasswordChar = '*';
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxOldPass.Focus();
            }
        }
        private void textBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxNewPass.Focus();
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            textBoxUserName.Text = Login.logInUserName1;
            this.ActiveControl = textBoxOldPass;
            textBoxOldPass.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userType == "Member") {
                this.Hide();
                new Member().Show();
            }
            else if (userType=="Manager")
            {
                this.Hide();
                new Manager().Show();


            }
      
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do You want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string np = textBoxNewPass.Text;
            string cp = textBoxConfirmPass.Text;
            bool flag = true;
            if (textBoxUserName.Text.Trim() == "")
            {
                flag = false;
            }
            else if (textBoxOldPass.Text.Trim() == "")
            {
                flag = false;
            }
            else if (textBoxNewPass.Text.Trim() == "")
            {
                flag = false;
            }
            else if (textBoxConfirmPass.Text.Trim() == "")
            {
                flag = false;
            }
            else flag = true;
            if (flag == true)
            {
                if (np.Equals(cp))
                {
                    string UserName = textBoxUserName.Text;
                    string oldPass = textBoxOldPass.Text;

                    info.password = cp;
                    info.userName = UserName;
                    info.oldPass = oldPass;
                    int rowaffected = opr.changePassword(info);

                    if (rowaffected > 0)
                    {

                        MessageBox.Show("Password Change SuccessFully");
                    }
                    else
                    {
                        MessageBox.Show("Wrong Old Password.\nEnter Correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }



            }


        }

        private void textBoxConfirmPass_Leave(object sender, EventArgs e)
        {
            //string np = textBoxNewPass.Text;
            //string cp = textBoxConfirmPass.Text;
            //if (np != cp)
            //{
            //    label6.Text = "*Password Missmatched";
            //    label6.ForeColor = Color.Red;
            //    //textBoxConfirmPass.Focus();
            //    // MessageBox.Show("Password didn't match.\n New password and Confirm password must be same. ","Wrong ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //}
            //else label6.Text = "";
        }

        private void textBoxConfirmPass_TextChanged(object sender, EventArgs e)
        {
            string np = textBoxNewPass.Text;
            string cp = textBoxConfirmPass.Text;
            if (np != cp)
            {
                label6.Text = "*Password Missmatched";
                label6.ForeColor = Color.Red;
                // textBoxConfirmPass.Focus();
            }
            else label6.Text = "";
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxConfirmPass.Focus();
            }
        }
    }
}
