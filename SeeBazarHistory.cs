using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vmmBAL;
using vmmBLL;

namespace VirtualMessManager
{
    public partial class SeeBazarHistory : Form
    {
        Informations info = new Informations();
        public Operation opr = new Operation();
        DataTable dt = new DataTable();

        private Manager managerBack = null;
        private Member memberBack = null;
        public SeeBazarHistory()
        {
            InitializeComponent();
            ChangeGridColor(gv_LoadBazar);
        }

                public SeeBazarHistory(Manager manager) : this() {
            this.managerBack = manager;
        }

              public SeeBazarHistory(Member member): this()
        {
            this.memberBack = member;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SeeBazarHistory_Load(object sender, EventArgs e)
        {
            info.refManagrtName = Login.refManagerName;
            MessageBox.Show("Your Manager is :" + info.refManagrtName);
            dt = opr.LoadBazarHistory(info);
            gv_LoadBazar.DataSource = dt;

        }
        public void ChangeGridColor(DataGridView grid)
        {
            grid.RowsDefaultCellStyle.BackColor = Color.DodgerBlue;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat;
        }

        private void bt_BazarLoad_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            info.refManagrtName = Login.refManagerName;
            info.dateFromMeal = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            info.dateToMeal = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());


            dt = opr.LoadBazarHistorySpecificDate(info);
            gv_LoadBazar.DataSource = dt;
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

            if (managerBack != null)
            {
                managerBack.Show();
            }
            else
            {
                memberBack.Show();
            }
        }
    }
}
