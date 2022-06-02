using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace BookStore
{
    public partial class Manage : Form
    {
        DataTable manageTable;
        public Manage()
        {
            InitializeComponent();
            oracleConnection1.Open();
            manageTable = dataSet11.Tables["MANAGER"];
        }

        private void LoginBtn_click(object sender, EventArgs e)
        {
            OracleDataReader rdr = oracleCommand1.ExecuteReader();
            if (rdr.Read() && rdr["M_ID"].ToString() == textBox1.Text && rdr["M_PW"].ToString() == textBox2.Text)
            {
                MessageBox.Show("Succesful Login");
                this.Visible = false;
                ManageForm M_Form = new ManageForm();
                M_Form.Owner = this;
                M_Form.Show();
            }
            else
            {
                MessageBox.Show("존재하지 않는 ID입니다");
            }
        }
    }
}
