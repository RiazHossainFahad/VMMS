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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Member_Load(object sender, EventArgs e)
        {
            tb_loginStatusMem.Text = Login.loginName;
        }

        private void memAddBazar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Bazar addBazar = new Add_Bazar(this);
            addBazar.Show(this);
        }

        private void memMemberInfo_Click(object sender, EventArgs e)
        {
            
            MemberInformation memberinfo = new MemberInformation(this);
            memberinfo.Show(this);
            this.Hide();
        }

        private void memBookMeal_Click(object sender, EventArgs e)
        {
            Book_Meal book = new Book_Meal(this);
            book.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void memMealHistory_Click(object sender, EventArgs e)
        {
            SeeBookedMeal bookedMeal = new SeeBookedMeal(this);
            bookedMeal.Show(this);
            this.Hide();
        }

        private void memBazarHistory_Click(object sender, EventArgs e)
        {
            SeeBazarHistory bazarHistory = new SeeBazarHistory(this);
            bazarHistory.Show(this);
            this.Hide();
        }

        
    }
}
