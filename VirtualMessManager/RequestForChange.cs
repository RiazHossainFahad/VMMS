using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vmmBAL;
using vmmBLL;
using vmmDAL;

namespace VirtualMessManager
{
    public partial class RequestForChange : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        public DBConnection db = new DBConnection();
        public BookMeal bm = new BookMeal();
        public Bazar ba = new Bazar();
        static int x;

        public RequestForChange()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member m = new Member();
            m.Show();
        }

        private void RequestForChange_Load(object sender, EventArgs e)
        {
            label7.Text += Login.loginName;

            db.connection.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = db.connection;
            string query = "select Date from vmmBazarChart where UserId='"+Login.userId+"' ";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                comboBox1.Items.Add(reader["Date"].ToString());

            }
            x++;
            db.connection.Close();
            if (x == 1)
            {

                db.connection.Open();

                cmd.Connection = db.connection;
                string query1 = "select Date from vmmMealChart where MemberId='"+Login.userId+"' ";
                cmd.CommandText = query1;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    cb_Date.Items.Add(reader["Date"].ToString());

                }
                db.connection.Close();

                x = 0;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxBreak.Text != "" && textBoxLunch.Text != "" && textBoxDinner.Text != "") {
                try
                {
                    bm.breakfast = Convert.ToSingle(textBoxBreak.Text);
                    bm.lunch = Convert.ToInt32(textBoxLunch.Text);
                    bm.dinner = Convert.ToInt32(textBoxDinner.Text);
                    bm.userName = Login.logInUserName1;
                    bm.date = Convert.ToDateTime(cb_Date.Text);
                    ba.amount = 0;
                    ba.quantity = null;
                    ba.items = null;


                    
                    int rowAffected = opr.insertRequest(bm);
                    if (rowAffected > 0) { MessageBox.Show("Request Successful"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }


            if (cb_Items.Text != "" && textBoxQuantity.Text != "" && textBoxPrice.Text != "")
            {
                try
                {
                    bm.breakfast = 0;
                    bm.lunch = 0;
                    bm.dinner = 0;
                    ba.userName = Login.logInUserName1;
                    ba.date = Convert.ToDateTime(comboBox1.Text);
                    ba.amount = Convert.ToInt32(textBoxPrice.Text);
                    ba.quantity = textBoxQuantity.Text;
                    ba.items = cb_Items.Text;



                    int rowAffected = opr.insertRequest1(ba);
                    if (rowAffected > 0) { MessageBox.Show("Request Successful"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
