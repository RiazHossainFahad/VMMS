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
    public partial class SeeBookedMeal : Form
    {
        Informations info = new Informations();
        public Operation opr = new Operation();
        DataTable dt = new DataTable();

        private Manager managerBack = null;
        private Member memberBack = null;
        public SeeBookedMeal()
        {
            InitializeComponent();
            ChangeGridColor(gv_MealHistory);
        }


        public SeeBookedMeal(Manager manager) : this() {
            this.managerBack = manager;
        }

        public SeeBookedMeal(Member member)
            : this()
        {
            this.memberBack = member;
        }


        private void SeeBookedMeal_Load(object sender, EventArgs e)
        {
            info.refManagrtName = Login.refManagerName;
            MessageBox.Show("Your Manager is :" + info.refManagrtName);
            dt = opr.LoadMealHistory(info);
            gv_MealHistory.DataSource = dt;
        }

        private void bt_LoadMeal_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            info.refManagrtName = Login.refManagerName;
            info.dateFromMeal = Convert.ToDateTime(dt_FromMealHistory.Value.ToShortDateString());
            info.dateToMeal = Convert.ToDateTime(dt_ToMealHistory.Value.ToShortDateString());


            dt = opr.LoadMealHistorySpecificDate(info);
            gv_MealHistory.DataSource = dt;
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        public void ChangeGridColor(DataGridView grid)
        {
            grid.RowsDefaultCellStyle.BackColor = Color.YellowGreen;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat;
        }

        private void bt_Back_Click(object sender, EventArgs e)
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
