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
    public partial class ForgotPassword : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        Random rnd = new Random();

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {

                Application.Exit();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = rnd.Next(1000, 9999);
            bool flag = true;
            if (textBoxUserName.Text.Trim() == "")
            {
                flag = false;
            }
            else if (textBoxPhoneNum.Text.Trim() == "")
            {
                flag = false;
            }
            else flag = true;
            if (flag == true)
            {
            
           
                    string UserName = textBoxUserName.Text;
                    string phoneNum = textBoxPhoneNum.Text;
                    info.userName = UserName;
                    info.phone = int.Parse(phoneNum);
                    info.password = x.ToString();

                int rowaffected = opr.ForgotPassword(info);

                if (rowaffected > 0)
                {
                    textBoxTempPass.Text = x.ToString();
                    if (MessageBox.Show("Password Change SuccessFully" + "\nYour password is: " + x.ToString(), "Sucess", MessageBoxButtons.OK) == DialogResult.OK) {

                        this.Hide();
                        new Login().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or phone.\nEnter Correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxUserName;
            textBoxUserName.Focus();
        }
    }
}
