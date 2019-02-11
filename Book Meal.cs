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
    public partial class Book_Meal : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        public BookMeal book = new BookMeal();

        private Manager managerBack = null;
        private Member memberBack = null;
       

        public Book_Meal()
        {
            InitializeComponent();
        }

        public Book_Meal(Manager manager) : this() {
            this.managerBack = manager;
        }

        public Book_Meal(Member member) :this() {
            this.memberBack = member;
        }

        private void Book_Meal_Load(object sender, EventArgs e)
        {

        }

        private void bt_book_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("i am here.");
            book.date = Convert.ToDateTime(dateTime_BookMeal.Value.ToShortDateString());
            book.memberId = Login.userId;
            book.name = Login.loginName;
            book.breakfast = float.Parse(cb_Breakfast.Text);
            book.dinner = Convert.ToInt32(cb_Lunch.Text);
            book.lunch = Convert.ToInt32(cb_Dinner.Text);
            book.refManager = Login.refManagerName;

            float tempTotal=book.breakfast + book.dinner + book.lunch;;
            book.TotalMeal = tempTotal;
            int rowAffected = opr.BookMeal(book);
            if (rowAffected > 0)
            {
                MessageBox.Show("Data Saved SuccessFull.");
            }
            else {
                MessageBox.Show("Something wrong.");
            }

        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            Login log = new Login();
            log.Show();
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

        private void cb_Breakfast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

