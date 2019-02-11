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
using vmmDAL;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using System;

namespace VirtualMessManager
{

    public partial class RegistrationForm : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        public DBConnection db = new DBConnection();
        string _userType;
        bool mStatus;
        bool confirmFlag = true;
        bool backOpt = false;

        //string phone = tb_Phone.Text;
        public RegistrationForm()
        {
            InitializeComponent();
            this.ActiveControl = tb_Name;
            tb_Name.Focus();
            tb_Password.PasswordChar = '*';
        }
        public RegistrationForm(AdminSession a)
        {
            InitializeComponent();
            this.ActiveControl = tb_Name;
            tb_Name.Focus();
            tb_Password.PasswordChar = '*';
            backOpt = true;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            //this.Hide();
            //Login log = new Login();
            //log.Show();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            tb_Name.Focus();
            //cb_ManagerName.Enabled = false;
            //cb_MessName.Enabled = false;

            db.connection.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = db.connection;
            string query = "select * from vmmUser1 where userType='Manager'";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb_ManagerName.Items.Add(reader["UserName"]);
                cb_MessName.Items.Add(reader["MessName"]);

            }
            db.connection.Close();

        }

        private void rb_Manager_CheckedChanged_1(object sender, EventArgs e)
        {
            
                db.connection.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = db.connection;
                string query = "select userType from vmmUser1";
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if ( reader["userType"].ToString()!= "Member")
                {
                    mStatus = true;
                    break;
                    
                }

            }
            if (mStatus)
            {
                MessageBox.Show("Already a Manager Exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.connection.Close();
                rb_Member.Focus();

            }
            else
            {
                cb_ManagerName.Enabled = true;
                cb_MessName.Focus();
            }

        }

        private void rb_Member_CheckedChanged(object sender, EventArgs e)
        {
            cb_MessName.Enabled = true;
            cb_ManagerName.Focus();

        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
       
                try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                dialog.Title = "Select Your Picture";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string picPath = dialog.FileName.ToString();
                    tb_imagePath.Text = picPath;
                    profilePic.ImageLocation = picPath;
                }
            }
            catch (Exception p) { MessageBox.Show(p.Message); }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "" && tb_Password.Text != "" && tb_Phone.Text != "" && tb_userName.Text != "" && cb_bloodGroup.Text != "" && cb_ManagerName.Text != "" && cb_MessName.Text != "" && tb_imagePath.Text != "")
            {
                byte[] img = null;
                try
                {
                    FileStream fs = new FileStream(tb_imagePath.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (tb_Name.Text.Trim() == "") { confirmFlag = false; }
                //else if (rb_Manager.Checked == false && rb_Member.Checked == false) { confirmFlag = false; }
                //else if (rb_Member.Checked == false) { confirmFlag = false; }
                else if (cb_ManagerName.Text.Trim() == "") { confirmFlag = false; }
                else if (cb_MessName.Text.Trim() == "") { confirmFlag = false; }
                else if (cb_ManagerName.Text.Trim() == "") { confirmFlag = false; }
                else if (cb_bloodGroup.Text.Trim() == "") { confirmFlag = false; }
                else if (tb_userName.Text.Trim() == "") { confirmFlag = false; }
                else if (tb_Password.Text.Trim() == "") { confirmFlag = false; }
                else if (tb_Phone.Text.Trim() == "") { confirmFlag = false; }


                info.name = tb_Name.Text;

                if (rb_Member.Checked == true)
                {
                    _userType = "Member";
                }
                if (rb_Manager.Checked == true)
                {
                    _userType = "Manager";
                }
                info.userType = _userType;
                info.refManagrtName = cb_ManagerName.Text;
                info.messName = cb_MessName.Text;
                info.dob = Convert.ToDateTime(date_dob.Value.ToShortDateString());
                info.bloodGroup = cb_bloodGroup.Text;
                info.userName = tb_userName.Text;
                info.password = tb_Password.Text;
                info.phone = Convert.ToInt32(tb_Phone.Text);
                info.pic = img;
                if (confirmFlag == true)
                {

                    int rowAffected = opr.insertUser(info);
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Data Saved SuccessFull.");
                        if (backOpt == true)
                        {
                            this.Hide();
                            AdminSession ads = new AdminSession(new Manager());
                            ads.Show();
                        }
                        else
                        {
                            this.Hide();
                            Login log = new Login();
                            log.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill Every Field Properly");
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (backOpt == true)
            {
                this.Hide();
                AdminSession ads = new AdminSession(new Manager());
                ads.Show();
            }
            else
            {
                this.Hide();
                Login log = new Login();
                log.Show();
            }
        }

        private void tb_Name_Leave(object sender, EventArgs e)
        {
            if (tb_Name.Text == "")
            {

                labelName.Text = "*Empty name is not posiible.";
                tb_Name.Focus();
            }
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            if (tb_Name.Text.Trim() != "")
            {

                labelName.Text = "";
            }
        }

        private void cb_ManagerName_Leave(object sender, EventArgs e)
        {
            if (cb_ManagerName.Text == "")
            {
                cb_ManagerName.Focus();
                labelManagerName.Text = "*Please select/Enter manager name.";
            }
        }

        private void cb_ManagerName_TextChanged(object sender, EventArgs e)
        {
            if (cb_ManagerName.Text.Trim() != "")
            {

                labelManagerName.Text = "";
            }
        }

        private void cb_MessName_Leave(object sender, EventArgs e)
        {
            if (cb_MessName.Text == "")
            {
                cb_MessName.Focus();
                labelMessName.Text = "*Please select/Enter Mess name.";

            }
        }

        private void cb_MessName_TextChanged(object sender, EventArgs e)
        {
            if (cb_MessName.Text.Trim() != "")
            {

                labelMessName.Text = "";
            }

        }

        private void date_dob_ValueChanged(object sender, EventArgs e)
        {
            if (date_dob.Text.Trim() != "")
            {

                labelDOB.Text = "";
            }
        }

        private void date_dob_Leave(object sender, EventArgs e)
        {
            DateTime to = DateTime.Now;
            if (Convert.ToDateTime(date_dob.Text) == to)
            {
                labelDOB.Text = "*Select your Date Of Birth.";
                  date_dob.Focus();
            }
            if (date_dob.Text != "")
            {
                int Age;
                DateTime from = date_dob.Value;
                //DateTime to = DateTime.Now;
                TimeSpan TSpan = to - from;
                double days = TSpan.TotalDays;
                Age = Convert.ToInt32(days / 365);
                if(Age <  17)
                {
                    MessageBox.Show("Your Age is "+ Age.ToString()+ "." + " \nYour Age is below 18.\nYou can't Register in this Mess System.\nContact to the Manager for Asistance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    date_dob.Focus();
                }
                

            }

        }

        private void cb_bloodGroup_Leave(object sender, EventArgs e)
        {
            if (cb_bloodGroup.Text == "")
            {

                cb_bloodGroup.Focus();
                labelBloodGrp.Text = "Select your blood group";
            }

        }

        private void cb_bloodGroup_TextChanged(object sender, EventArgs e)
        {
            if (cb_bloodGroup.Text.Trim()!="") { labelBloodGrp.Text = ""; }
        }

        private void tb_userName_TextChanged(object sender, EventArgs e)
        {
            if (tb_userName.Text.Trim() != "") {

                labelUserName.Text = "";
            }

        }

        private void tb_userName_Leave(object sender, EventArgs e)
        {
            if (tb_userName.Text == "")
            {

                tb_userName.Focus();
                labelUserName.Text = "*Empty Username field";
            }
            if (tb_userName.Text != "")
            {
                db.connection.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = db.connection;
                string query = "select UserName from vmmUser1";
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (tb_userName.Text == reader["UserName"].ToString())
                    {
                        MessageBox.Show("UserName is already taken.\nPlease change your User Name.\nUser Name must be unique.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        tb_userName.Focus();
                    }

                }
                db.connection.Close();

            }
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (tb_Password.Text == "")
            {

                tb_Password.Focus();
                labelPassword.Text = "*Empty password field.";
            }

        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            if (tb_Password.Text.Trim() != "")
            {
                labelPassword.Text = "";

            }

        }

        private void tb_Phone_Leave(object sender, EventArgs e)
        {
            if (tb_Phone.Text == "") {

                tb_Phone.Focus();
                labelPhoneNmbr.Text = "*Empty phone number field.";
            }
        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {
            if(tb_Phone.Text.Trim()!="")
            labelPhoneNmbr.Text = "";
        }

        private void rb_Manager_Click(object sender, EventArgs e)
        {

        }
    }
}