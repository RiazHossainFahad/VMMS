using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vmmBAL;
using vmmBLL;
using vmmDAL;

namespace VirtualMessManager
{
    public partial class DeleteMember : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        public DBConnection db = new DBConnection();
        byte[] pic = null;

        public DeleteMember()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_loginStatusMan_TextChanged(object sender, EventArgs e)
        {

        }

        private void EventLoader()
        {
            tb_loginStatusMan.Text = Login.loginName;
            textBox1.Text = Login.uType;

            if (Login.picture == null) { pictureBox1.Image = null; }
            else
            {

                MemoryStream ms = new MemoryStream(Login.picture);
                pictureBox1.Image = Image.FromStream(ms);
            }

            db.connection.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = db.connection;
            string query = "select UserName from vmmUser1 ";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                cb_UserName.Items.Add(reader["UserName"]);

            }

            db.connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EventLoader();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cb_UserName.Text != "")
            {
                if (textBoxType.Text == "Member"|| textBoxType.Text=="member")
                {
                    if (MessageBox.Show("Do you really want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        info.userName = cb_UserName.Text;
                        //info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);

                        opr.DeleteMember(info);
                        MessageBox.Show("Member Deleted");
                        cb_UserName.Text = null;
                        pictureBox2.Image = VirtualMessManager.Properties.Resources.person_icon_8;
                        textBoxId.Text = null;
                        textBoxType.Text = null;
                        textBoxPhone.Text = null;
                        //comboBox1.SelectedIndex = -1;
                        cb_UserName.DataSource = null;
                        cb_UserName.Items.Clear();
                        EventLoader();




                    }

                }
                else MessageBox.Show("Manager can't be deleted.\n\nHint!\nIf you want to delete manager,Switch his account to menber","Can't Perform Action",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { MessageBox.Show("UserName Is Empty !!"); }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSession AS = new AdminSession();
            AS.Show();
            this.Hide();
        }

        

        private void MemInfo_ValueChange(object sender, EventArgs e)
        {

            try
            {
                //info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);
                DataTable dt = new DataTable();
                dt = opr.MemberInfoDelete(info);
                textBoxId.Text = dt.Rows[0][0].ToString();
                textBoxType.Text = dt.Rows[0][1].ToString();
                textBoxPhone.Text = dt.Rows[0][2].ToString();
                pic = (byte[])(dt.Rows[0][3]);

            }
            catch (Exception ex) {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("UserName is Not Selected !");

            }
          

                MemoryStream ms = new MemoryStream(pic);
                pictureBox2.Image = Image.FromStream(ms);

        }

        private void MemInfo_TextChange(object sender, EventArgs e)
        {
            if (cb_UserName.Text != "")
            {
                try
                {
                    info.userName = cb_UserName.Text;

                    DataTable dt = opr.GetId(info);
                    info.ID = Convert.ToInt32(dt.Rows[0][0]);
                }
                catch (Exception ex) {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("UserName is Not Selected !");
                }
            }
        }

       
    }
}