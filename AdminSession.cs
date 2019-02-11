using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMessManager
{
    public partial class AdminSession : Form
    {
        private Manager managerBack = null;
        public AdminSession()
        {
            InitializeComponent();
        }

        public AdminSession(Manager manager): this()
        {
            this.managerBack = manager;
        }

        private void admAddMember_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Application.Exit();
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerBack.Show();
        }

        private void admMealSheetUpd_Click(object sender, EventArgs e)
        {
            EditMealChart editMeal = new EditMealChart(this);
            editMeal.Show(this);
            this.Hide();
        }

        private void admChange_Click(object sender, EventArgs e)
        {
            AdminChange adminchange = new AdminChange(this);
            adminchange.Show(this);
            this.Hide();
        }

        private void admMonthCal_Click(object sender, EventArgs e)
        {
            Calculation calculation = new Calculation(this);
            calculation.Show(this);
            this.Hide();
        }

        private void bt_BazarEdit_Click(object sender, EventArgs e)
        {
            EditBazar bazarEdit = new EditBazar(this);
            bazarEdit.Show(this);
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminSession_Load(object sender, EventArgs e)
        {

        }
    }
}
