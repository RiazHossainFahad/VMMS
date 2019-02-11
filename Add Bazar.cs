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
using vmmDAL;
using System.Data.SqlClient;

namespace VirtualMessManager
{

    public partial class Add_Bazar : Form
    {
        public Operation opr = new Operation();
        public DBConnection db = new DBConnection();
        public Bazar bazar = new Bazar();
        public Informations info = new Informations();
        private Manager managerBack=null;
        private Member memberBack=null;
        public Add_Bazar()
        {
            
            InitializeComponent();
           
        }
        public Add_Bazar(Manager manager):this()
        {

            
            this.managerBack = manager;
            this.ActiveControl = cb_Items;
        }
        public Add_Bazar(Member member) : this()
        {


            this.memberBack = member;
            this.ActiveControl = cb_Items;
        }

        private void bt_addItems_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Iam Working Proprely..");
            bazar.items = cb_Items.Text;
            bazar.quantity = tb_Quantity.Text;
            bazar.amount = float.Parse(tb_Amount.Text);
            bazar.date = Convert.ToDateTime(dt_Bazar.Value.ToShortDateString());
            bazar.userID = Login.userId;
            bazar.userName = Login.loginName;
            bazar.refManager = Login.refManagerName;
            MessageBox.Show(bazar.date+"");

            int rowAffected = opr.insertBazar(bazar);
           MessageBox.Show("I am back from operarion.");

            if (rowAffected > 0)
            {
                MessageBox.Show("Data Saved SuccessFull.");

                cb_Items.Text = "";
                tb_Amount.Text = "";
                tb_Quantity.Text = "";
            }
            else {
                MessageBox.Show("Something Wrong Try Again.");
            }


        }

        private void Add_Bazar_Load(object sender, EventArgs e)
        {

        }

        private void addBazarCancel_Click(object sender, EventArgs e)
        {
           // Application.Exit();
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void bt_back_Click(object sender, EventArgs e)
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
