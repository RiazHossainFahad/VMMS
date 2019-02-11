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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AdminSession admin = new AdminSession(this);
            admin.Show(this);
            this.Hide();
        }

        private void tb_loginStatusMan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            tb_loginStatusMan.Text = Login.loginName;
        }

        private void manAddBazar_Click(object sender, EventArgs e)
        {
            Add_Bazar addBazar = new Add_Bazar(this);
            addBazar.Show(this);
            this.Hide();

            
        }

        private void manMemberInfo_Click(object sender, EventArgs e)
        {
           
            MemberInformation memberinfo = new MemberInformation(this);
            memberinfo.Show(this);
            this.Hide();
        }

        private void manBookMeal_Click(object sender, EventArgs e)
        {
            Book_Meal book = new Book_Meal(this);
            book.Show(this);
            this.Hide();
        }

        private void manSeeBookedMeal_Click(object sender, EventArgs e)
        {
            SeeBookedMeal bookedMeal = new SeeBookedMeal(this);
            bookedMeal.Show(this);
            this.Hide();
        }

        private void manSeeBazar_Click(object sender, EventArgs e)
        {
            SeeBazarHistory bazarHistory = new SeeBazarHistory(this);
            bazarHistory.Show(this);
            this.Hide();
        }

        private void bt_signOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
