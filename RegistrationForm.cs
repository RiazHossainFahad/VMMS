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

        bool confirmFlag = true;

        //string phone = tb_Phone.Text;
        public RegistrationForm()
        {
            InitializeComponent();
            this.ActiveControl = tb_Name;
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            Login log = new Login();
            log.Show();
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
            cb_ManagerName.Enabled = true;
            cb_MessName.Focus();

        }

        private void rb_Member_CheckedChanged(object sender, EventArgs e)
        {
            cb_MessName.Enabled = true;
            cb_ManagerName.Focus();

        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string picPath = dialog.FileName.ToString();
                tb_imagePath.Text = picPath;
                profilePic.ImageLocation = picPath;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            //byte[] imageBt = null;
            //try
            //{
            //    FileStream fstream = new FileStream(this.tb_imagePath.Text, FileMode.Open, FileAccess.Read);
            //    BinaryReader br = new BinaryReader(fstream);
            //    imageBt = br.ReadBytes((int)fstream.Length);
            //}
            //catch (Exception ex)
            //{
            //   // MessageBox.Show(e);
            //}

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
            } if (rb_Manager.Checked == true)
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

            if (confirmFlag == true)
            {

                int rowAffected = opr.insertUser(info);
                if (rowAffected > 0)
                {
                    MessageBox.Show("Data Saved SuccessFull.");

                    Login log = new Login();
                    log.Show();
                    this.Hide();

                    //tb_Name.Text = "";
                    //rb_Member.Checked = false;
                    //rb_Manager.Checked = false;
                    //tb_userName.Text = "";
                    //tb_Password.Text = "";
                    //tb_Phone.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Please Fill Every Field Properly");
                tb_Name.Focus();
            }





        }

        private void tb_Name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Name.Text))
            {
                e.Cancel = true;
                tb_Name.Focus();
                errorName.SetError(tb_Name, "Please Enter your Name ");

            }
            else
            {
                e.Cancel = false;
                errorName.SetError(tb_Name, null);

            }
        }

        private void tb_messName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_MessName.Text))
            {
                e.Cancel = true;
                cb_MessName.Focus();
                errorMessName.SetError(cb_MessName, "Please Enter your Mess Name ");

            }
            else
            {
                e.Cancel = false;
                errorMessName.SetError(cb_MessName, null);

            }

        }

        private void tb_userName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_userName.Text))
            {
                e.Cancel = true;
                tb_userName.Focus();
                errorUsername.SetError(tb_userName, "Please Enter your User Name ");

            }
            else
            {
                e.Cancel = false;
                errorUsername.SetError(tb_userName, null);

            }

        }

        private void cb_MessName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }


}