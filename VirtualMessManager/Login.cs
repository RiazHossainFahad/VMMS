using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vmmBLL;
using vmmBAL;
using System.IO;

namespace VirtualMessManager
{
    public partial class Login : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        public Bazar bazar = new Bazar();

        public static string uType;
        public static string loginName;
        public static string refManagerName;
        public static int userId;
        public static string logInUserName1;
        public static string logInPassword1;
        public static byte[] picture = null;

        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();
            loginPassword.PasswordChar = '*';

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm rm = new RegistrationForm();
            this.Hide();
            rm.Show();
        }


        

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = signUsername;
            signUsername.Focus();
            //this.ActiveControl = us;
            //textBox1.Focus();
        }

        private void tb_login_Click(object sender, EventArgs e)
        {
            if (loginPassword.Text != "")
            {
                info.userName = signUsername.Text;
                info.password = loginPassword.Text;

                dt = opr.Login(info);

                if (dt.Rows.Count ==1)
                {
                    logInUserName1 = dt.Rows[0][7].ToString();
                    logInPassword1 = dt.Rows[0][8].ToString();
                    uType = dt.Rows[0][2].ToString();
                    loginName = dt.Rows[0][1].ToString();
                    refManagerName = dt.Rows[0][3].ToString();
                    string tempid = dt.Rows[0][0].ToString();
                    userId = Convert.ToInt32(tempid);
                    if (dt.Rows[0][10] != null)
                    {
                        picture = (byte[])(dt.Rows[0][10]);
                    }
                    bazar.userID = userId;

                    //MessageBox.Show(bazar.userID+"");
                    //bazar.userName = loginName;
                    //MessageBox.Show(bazar.userName);
                    if (uType.Trim() == "Manager")
                    {
                        Manager m = new Manager();
                        this.Hide();
                        m.Show();

                    }
                    else
                    {
                        Member mb = new Member();
                        this.Hide();
                        mb.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid User.");
                    //signUsername.Text = "";
                    //loginPassword.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void signUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            //ChangePassword cp = new ChangePassword();
            //cp.Show();
            new ForgotPassword().Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RegistrationForm rm = new RegistrationForm();
            this.Hide();
            rm.Show();
        }

        private void signUsername_Leave(object sender, EventArgs e)
        {
            if (signUsername.Text == "")
            {
                signUsername.Focus();
                label5.Text = "*User Name can't Empty..";

            }
            else 
                label5.Text = "";
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginPassword_Leave(object sender, EventArgs e)
        {
            if (loginPassword.Text == "")
            {
                loginPassword.Focus();
                label6.Text = "*Password can't Empty..";

            }
            else
                label6.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private void signUsername_TextChanged_1(object sender, EventArgs e)
        {
            label5.Text = "";
        }

        private void tb_login_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void UserName_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginPassword.Focus();
            }
        }

        //private void loginPassword_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //}

        private void LoginPassword_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_login.Focus();
            }
        }
    }
}
