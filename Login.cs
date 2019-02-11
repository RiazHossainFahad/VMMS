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

        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();

            signUsername.GotFocus += new EventHandler(TextGotFocus);
            signUsername.LostFocus += new EventHandler(TextLostFocus);

            loginPassword.GotFocus += new EventHandler(TextGotFocus1);
            loginPassword.LostFocus += new EventHandler(TextLostFocus1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm rm = new RegistrationForm();
            this.Hide();
            rm.Show();
        }

        private void TextGotFocus(Object sender, EventArgs e)
        {
            if (signUsername.Text.Trim().Equals("USERNAME"))
            signUsername.Text = "";
            signUsername.ForeColor = System.Drawing.Color.Brown;


        }

        private void TextGotFocus1(Object sender, EventArgs e)
        {
            if (loginPassword.Text.Trim().Equals("PASSWORD"))
            loginPassword.Text = "";
            loginPassword.ForeColor = System.Drawing.Color.Brown;
            loginPassword.PasswordChar = 'x';


        }
        private void TextLostFocus(Object sender, EventArgs e)
        {
            if (signUsername.Text.Trim().Equals(""))
                signUsername.Text = "USERNAME";

        }

        private void TextLostFocus1(Object sender, EventArgs e)
        {
            if (loginPassword.Text.Trim().Equals(""))
                loginPassword.Text = "PASSWORD";
        }

        private void signUsername_Validating(object sender, CancelEventArgs e)
        {
            if (signUsername.Text.Trim().Equals("USERNAME"))
            {
                e.Cancel = true;
                signUsername.Focus();
                errorUsername.SetError(signUsername, "Please Enter your Username ");

            }
            else
            {
                e.Cancel = false;
                errorUsername.SetError(signUsername, null);

            }
        }

        private void loginPassword_Validating(object sender, CancelEventArgs e)
        {
            if (loginPassword.Text.Trim().Equals("PASSWORD"))
            {
                e.Cancel = true;
                loginPassword.Focus();
                errorPassword.SetError(loginPassword, "Please Enter your Password ");

            }
            else
            {
                e.Cancel = false;
                errorPassword.SetError(loginPassword, null);

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tb_login_Click(object sender, EventArgs e)
        {
            info.userName = signUsername.Text;
            info.password = loginPassword.Text;

            dt = opr.Login(info);

            if (dt.Rows.Count > 0)
            {
                logInUserName1=dt.Rows[0][7].ToString();
                logInPassword1=dt.Rows[0][8].ToString();
                uType = dt.Rows[0][2].ToString();
                loginName = dt.Rows[0][1].ToString();
                refManagerName=dt.Rows[0][3].ToString();
                string tempid = dt.Rows[0][0].ToString();
                userId = Convert.ToInt32(tempid);
                //bazar.userID = userId;

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
            else {
                MessageBox.Show("Invalid User.");
                //signUsername.Text = "";
                //loginPassword.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
