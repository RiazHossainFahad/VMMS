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
    public partial class EditMealChart : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        public DBConnection db = new DBConnection();
        public BookMeal bm = new BookMeal();
        bool backToAdmin, backToSeaBM = false;
        static int x;

        public EditMealChart(AdminSession adminSession)
        {
            InitializeComponent();
            backToAdmin = true;
        }
        public EditMealChart(SeeBookedMeal seeBookedMeal)
        {
            InitializeComponent();
            backToSeaBM = true;
        }

        public EditMealChart()
        {
            InitializeComponent();
        }

        private void EditMealChartnew_Load(object sender, EventArgs e)
        {
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
            x++;
            db.connection.Close();
            if (x == 1)
            {

                db.connection.Open();

                cmd.Connection = db.connection;
                string query1 = "select Date from vmmMealChart ";
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (backToAdmin == true)
            {
                this.Hide();
                AdminSession AS = new AdminSession();
                AS.Show();
            }
            else if (backToSeaBM == true)
            {
              
                this.Hide();
                SeeBookedMeal sbm = new SeeBookedMeal(new Manager());
                sbm.Show();
            }
            else {
                this.Hide();
                Notification nf = new Notification();
                nf.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_Date.Text != "" && cb_UserName.Text != "") {
           
                if (textBoxBreak.Text != "" && textBoxLunch.Text != "" && textBoxDinner.Text != "")
                {
                    
                    try
                    {
                        bm.breakfast = Convert.ToSingle(textBoxBreak.Text);
                        bm.lunch = Convert.ToInt32(textBoxLunch.Text);
                        bm.dinner = Convert.ToInt32(textBoxDinner.Text);
                        info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);
                        info.userName = cb_UserName.Text;

                        int rowAffected = opr.UpdateMealChart(bm);
                        
                        if (rowAffected >0) {
                            opr.DeleteRequestMeal(info);
                            MessageBox.Show(cb_Date.Text+" "+"\nUserName: "+cb_UserName.Text+"\n"+"Breakfast: "+textBoxBreak.Text+" "+"Lunch: "+textBoxLunch.Text+" "+"Dinner: "+textBoxDinner.Text+"\nData Update successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch(Exception ex) { MessageBox.Show("Breakfast/Lunch/Dinner field must be Numbers(0-9) ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else MessageBox.Show("Breakfast/Lunch/Dinner field is empty.\nPlease Enter these Field correctly. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("Empty User Name or Date field.\nPlease select these Field correctly. ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cb_UserName.Text != "" && cb_Date.Text != "")
            {
                info.userName = cb_UserName.Text;
                info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);
                
                opr.DeleteInfo(info);
                MessageBox.Show("Row Deleted");


            }
            else { MessageBox.Show("No row selected."); }

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
            x++;
            db.connection.Close();
            if (x == 1)
            {

                db.connection.Open();

                cmd.Connection = db.connection;
                string query1 = "select Date from vmmMealChart ";
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

        private void cb_UserName_TextChanged(object sender, EventArgs e)
        {
            if (cb_UserName.Text != "")
            {
                try
                {
                    info.userName = cb_UserName.Text;
                    DataTable dt = opr.GetId(info);
                    info.ID = Convert.ToInt32(dt.Rows[0][0]);
                    bm.id = info.ID;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void cb_UserName_SelectedValueChanged(object sender, EventArgs e)
        {
            
            try
            {
                info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);
                bm.date = info.dateFromMeal;
                DataTable dt = new DataTable();
                dt = opr.GetBreakLunDin(info);
                textBoxBreak.Text = dt.Rows[0][0].ToString();
                textBoxLunch.Text = dt.Rows[0][1].ToString();
                textBoxDinner.Text = dt.Rows[0][2].ToString();
     
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void cb_Date_TextChanged(object sender, EventArgs e)
        {
            if (cb_UserName.Text != "") {
                try
                {
                    info.dateFromMeal = Convert.ToDateTime(cb_Date.Text);
                    DataTable dt = new DataTable();
                    dt = opr.GetBreakLunDin(info);
                    textBoxBreak.Text = dt.Rows[0][0].ToString();
                    textBoxLunch.Text = dt.Rows[0][1].ToString();
                    textBoxDinner.Text = dt.Rows[0][2].ToString();

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }

        private void cb_Date_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}