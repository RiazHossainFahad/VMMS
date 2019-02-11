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
    public partial class Notification : Form
    {
        Informations info = new Informations();
        public Operation opr = new Operation();
        DataTable dt = new DataTable();
        public Notification()
        {
            InitializeComponent();
            ChangeGridColor(dataGridView1);
        }

        public void ChangeGridColor(DataGridView grid)
        {
            grid.RowsDefaultCellStyle.BackColor = Color.DodgerBlue;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat;
        }

        private void Notification_Load(object sender, EventArgs e)
        {

            dt = opr.LoadNotification(info);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditBzaar eb = new EditBzaar(this);
            eb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            EditMealChart ec= new EditMealChart();
            ec.Show();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You want to exit?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager mg = new Manager();
            mg.Show();
        }
    }
}
