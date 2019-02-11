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

namespace VirtualMessManager
{
    public partial class Calculation : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        public DBConnection db = new DBConnection();
        DataTable dt = new DataTable();

        private AdminSession managerBack = null;

        float sumation = 0;
        float mealsumation = 0;
        float mealrate = 0;
        public Calculation()
        {
            InitializeComponent();
            ChangeGridColor(dataGridView1);
            ChangeGridColor(dataGridView2);
            
        }


        public Calculation(AdminSession adminBack) :this()
        {
            this.managerBack = adminBack;
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tb_MealAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculation_Load(object sender, EventArgs e)
        {
            tb_totalBazar.ReadOnly = true;
            tb_totalMeal.ReadOnly = true;
            tb_Remarks.ReadOnly = true;

            info.refManagrtName = Login.refManagerName;            dt = opr.LoadBazarHistory(info);

            MessageBox.Show("Your Manager is :" + info.refManagrtName);
            dataGridView1.DataSource = dt;

            info.refManagrtName = Login.refManagerName;
            MessageBox.Show("Your Manager is :" + info.refManagrtName);
            dt = opr.LoadMealHistoryCalculation(info);
            dataGridView2.DataSource = dt;


            MessageBox.Show(dataGridView1.Rows.Count.ToString());

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                float  temp =Convert.ToSingle( dataGridView1.Rows[i].Cells[2].Value);
                //double temp= double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                sumation += temp;
               // MessageBox.Show(sumation.ToString());
            }
            

            tb_totalBazar.Text = sumation.ToString();

            db.connection.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = db.connection;
            string query = "select * from vmmUser1 where RefManagerName='" + Login.logInUserName1 + "'";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cb_Member.Items.Add(reader["Name"]);

            }
            db.connection.Close();

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                float temp = Convert.ToSingle(dataGridView2.Rows[i].Cells[1].Value);
                //double temp= double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                mealsumation += temp;
                // MessageBox.Show(sumation.ToString());
            }
            tb_totalMeal.Text = mealsumation.ToString();

            mealrate = sumation / mealsumation;
            tb_mealRate.Text = mealrate.ToString();
        }

        private void cb_Member_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_mealRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Deposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) &&  e.KeyChar != '.')
                e.Handled = true;

        }

        private void tb_MealAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) && e.KeyChar != '.')
                e.Handled = true;

        }

        private void tb_Others_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)) && e.KeyChar != '.')
                e.Handled = true;
        }

        public void ChangeGridColor(DataGridView grid)
        {
            grid.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Yellow;
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerBack.Show();
           
        }

        private void bt_Calculate_Click(object sender, EventArgs e)
        {
            float deposit = float.Parse(tb_Deposit.Text);
            float mealNumber = float.Parse(tb_MealAmount.Text);
            float others = float.Parse(tb_Others.Text);

            float result = deposit-(mealrate * mealNumber + others);

            tb_Remarks.Text = result.ToString();
        }
    }
}
