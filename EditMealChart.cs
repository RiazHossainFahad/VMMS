using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using vmmBAL;
using vmmBLL;

namespace VirtualMessManager
{
    public partial class EditMealChart : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        public BookMeal book = new BookMeal();

        private AdminSession managerBack = null;

        public EditMealChart()
        {
            InitializeComponent();
            ChangeGridColor(gv_EditMealSheet);
        }

        public EditMealChart(AdminSession adminBack)
            : this()
        {
            this.managerBack = adminBack;
        }

        private void EditMealChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.vmmMealChart' table. You can move, or remove it, as needed.
            this.vmmMealChartTableAdapter1.Fill(this.dataSet2.vmmMealChart);
            // TODO: This line of code loads data into the 'vMMDataSet.vmmMealChart' table. You can move, or remove it, as needed.
            //this.vmmMealChartTableAdapter.Fill(this.vMMDataSet.vmmMealChart);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gv_EditMealSheet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_EditMealSheet.CurrentCell.ColumnIndex.Equals(10))
            {
                if (MessageBox.Show("Are you Sure want to delete this records ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var row = gv_EditMealSheet.CurrentRow;
                    gv_EditMealSheet.Rows.Remove(row);
                }

            }
            else if (gv_EditMealSheet.CurrentCell.ColumnIndex.Equals(9))
            {
                try
                {

                    if (MessageBox.Show("Are you Sure want to Update this records ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection("Data Source=ROKY\\SQLEXPRESS;Initial Catalog=VMM;User ID=sa;Password=123456");
                        con.Open();
                        SqlDataAdapter sda1 = new SqlDataAdapter("Select * from vmmMealSheet", con);
                        DataTable dt = new DataTable();
                        SqlCommandBuilder scb = new SqlCommandBuilder(sda1);
                        sda1.Update(this.vMMDataSet.vmmMealChart);
                        con.Close();
                        MessageBox.Show("Your Data Updated !");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }


            }
        }

        private void AddUpdate()
        {

            MessageBox.Show("i am here.");
            book.date = Convert.ToDateTime(dt_AddAgainMealDate.Value.ToShortDateString());
            book.memberId = Login.userId;
            book.name = tb_Name.Text;
            book.breakfast = float.Parse(cb_BreakfastMealSheet.Text);
            book.dinner = Convert.ToInt32(cb_lunchMealSheet.Text);
            book.lunch = Convert.ToInt32(cb_DinnerMealSheet.Text);
            book.refManager = Login.refManagerName;
            book.TotalMeal = book.breakfast + book.dinner + book.lunch;

            book.mealPerDay = book.breakfast + book.dinner + book.lunch;

            int rowAffected = opr.BookMeal(book);
            if (rowAffected > 0)
            {
                MessageBox.Show("Data Saved SuccessFull.");
                LoadPatientRecords();
            }
            else
            {
                MessageBox.Show("Something wrong.");
            }

        }

        private void LoadPatientRecords()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=ROKY\\SQLEXPRESS;Initial Catalog=VMM;User ID=sa;Password=123456");
                con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter("Select * from vmmMealChart", con);
                DataTable dt = new DataTable();
                SqlCommandBuilder scb = new SqlCommandBuilder(sda1);
                sda1.Fill(this.vMMDataSet.vmmMealChart);
                con.Close();
                MessageBox.Show("Your Data Updated !");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUpdate();
            tb_Name.Text = "";
            cb_BreakfastMealSheet.Text = "";
            cb_lunchMealSheet.Text = "";
            cb_DinnerMealSheet.Text = "";
        }

        public void ChangeGridColor(DataGridView grid)
        {
            grid.RowsDefaultCellStyle.BackColor = Color.MintCream;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat;
        }

        private void gv_EditMealSheet_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (gv_EditMealSheet.CurrentCell.ColumnIndex.Equals(10))
            {
                if (MessageBox.Show("Are you Sure want to delete this records ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var row = gv_EditMealSheet.CurrentRow;
                    gv_EditMealSheet.Rows.Remove(row);
                }

            }
            else if (gv_EditMealSheet.CurrentCell.ColumnIndex.Equals(9))
            {
                try
                {

                    if (MessageBox.Show("Are you Sure want to Update this records ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection("Data Source=ROKY\\SQLEXPRESS;Initial Catalog=VMM;User ID=sa;Password=123456");
                        con.Open();
                        SqlDataAdapter sda1 = new SqlDataAdapter("Select * from vmmMealChart", con);
                        DataTable dt = new DataTable();
                        SqlCommandBuilder scb = new SqlCommandBuilder(sda1);
                        sda1.Update(this.vMMDataSet.vmmMealChart);
                        con.Close();
                        MessageBox.Show("Your Data Updated !");
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }


            }

        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerBack.Show();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        } 
    }
}
