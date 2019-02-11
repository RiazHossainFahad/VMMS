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
        private EditMealChart editMealChartnewBack = null;
        public SeeBookedMeal()
        {
            InitializeComponent();
            ChangeGridColor(gv_MealHistory);
        }

        public SeeBookedMeal(EditMealChart editMealChartnew) : this()
        {
            this.editMealChartnewBack = editMealChartnew;
        }


        public SeeBookedMeal(Manager manager) : this() {
            this.managerBack = manager;
        }

        public SeeBookedMeal(Member member): this()
        {
            this.memberBack = member;
        }


        private void SeeBookedMeal_Load(object sender, EventArgs e)
        {
            info.refManagrtName = Login.refManagerName;
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
            DialogResult result = MessageBox.Show("Do You want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void ChangeGridColor(DataGridView grid)
        {
            grid.RowsDefaultCellStyle.BackColor = Color.YellowGreen;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat;
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            //this.Hide();

            if (managerBack != null)
            {
                this.Hide();
                managerBack.Show();
            }
            else
            {
                this.Hide();
                Member m = new Member();
                m.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();

            if (managerBack != null)
            {
                this.Hide();
                EditMealChart editMeal = new EditMealChart(this);
                editMeal.Show(this);
            }
            else
            {
                MessageBox.Show("You are not a Manager.\nYou can't Access this section. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                SeeBookedMeal s = new SeeBookedMeal();
                s.Show();
                
    }

        }
    }
}
