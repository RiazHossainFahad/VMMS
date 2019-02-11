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
    public partial class MemberInformation : Form
    {
        public Informations info = new Informations();
        public Operation opr = new Operation();
        DataTable dt = new DataTable();

        private Manager managerBack = null;
        private Member memberBack = null;
        public MemberInformation()
        {
            InitializeComponent();
            ChangeGridColor(MemdataGridView);
        }


        public MemberInformation(Manager manager) : this() {
            this.managerBack = manager;
        }

        public MemberInformation(Member member): this()
        {
            this.memberBack =member;
        }

        private void MemberInformation_Load(object sender, EventArgs e)
        {
            info.refManagrtName = Login.refManagerName;
            MessageBox.Show("Your Manager is : "+info.refManagrtName);
            dt = opr.LoadMemberInformation(info);
            MemdataGridView.DataSource = dt;
            

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
            grid.RowsDefaultCellStyle.BackColor = Color.Tomato;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.YellowGreen;
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
