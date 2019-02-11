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
    public partial class EditBazar : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        public BookMeal book = new BookMeal();

        private AdminSession managerBack = null;
        //private Member memberBack = null;

        public EditBazar()
        {
            InitializeComponent();
            ChangeGridColor(gv_EditBazat);
        }


         public EditBazar(AdminSession manager) : this() {
            this.managerBack = manager;
        }

        // public EditBazar(Member member): this()
        // {
        //    this.memberBack = member;
        //}


        private void bt_Exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void EditBazar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.vmmBazarChart' table. You can move, or remove it, as needed.
            this.vmmBazarChartTableAdapter1.Fill(this.dataSet1.vmmBazarChart);
            // TODO: This line of code loads data into the 'vMMDataSet1.vmmBazarChart' table. You can move, or remove it, as needed.
            //this.vmmBazarChartTableAdapter.Fill(this.vMMDataSet1.vmmBazarChart);

        }

        private void gv_EditBazat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (gv_EditBazat.CurrentCell.ColumnIndex.Equals(7))
                {
                    if (MessageBox.Show("Are you Sure want to delete this records ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var row = gv_EditBazat.CurrentRow;
                        gv_EditBazat.Rows.Remove(row);
                    }

                }
                else if (gv_EditBazat.CurrentCell.ColumnIndex.Equals(6))
                {
                    try
                    {

                        if (MessageBox.Show("Are you Sure want to Update this records ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlConnection con = new SqlConnection("Data Source=ROKY\\SQLEXPRESS;Initial Catalog=VMM;User ID=sa;Password=123456");
                            con.Open();
                            SqlDataAdapter sda1 = new SqlDataAdapter("Select * from vmmBazarChart", con);
                            DataTable dt = new DataTable();
                            SqlCommandBuilder scb = new SqlCommandBuilder(sda1);
                            sda1.Update(this.vMMDataSet1.vmmBazarChart);
                            con.Close();
                            MessageBox.Show("Your Data Updated !");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }


                }
            }
        }

        public void ChangeGridColor(DataGridView grid)
        {
            grid.RowsDefaultCellStyle.BackColor = Color.ForestGreen;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat;
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (managerBack != null)
            {
                managerBack.Show();
            }
        }
    }
}
