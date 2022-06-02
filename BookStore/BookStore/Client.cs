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
    public partial class Client : Form
    {
        DataTable clientTable;
        public Client()
        {
            InitializeComponent();
            DataSet1TableAdapters.CUSTOMERINFOTableAdapter customerinfoTableAdapter1 = new DataSet1TableAdapters.CUSTOMERINFOTableAdapter();
            
        }
        private void Client_Load(object sender, EventArgs e)
        {
            this.customerinfoTableAdapter1.Fill(this.dataSet11.CUSTOMERINFO);
            clientTable = dataSet11.Tables["CUSTOMERINFO"];
        }
        private void CLoginBtn_Click(object sender, EventArgs e)
        {
            DataRow FindID = clientTable.Rows.Find(textBox1.Text);
            DataRow[] FindPW= clientTable.Select("C_PW  = '" + textBox2.Text + "'" );

            if (FindID != null)
            {
                
                if (FindPW != null)
                {
                    MessageBox.Show("Succesful Login");
                    this.Visible = false;
                    ClientForm clientform = new ClientForm(textBox1.Text);
                    clientform.Owner = this;
                    clientform.Show();
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀렸습니다");
                }
            }
            else
            {
                if (FindPW != null)
                {
                    MessageBox.Show("아이디가 틀렸습니다.");
                }
                else
                {
                    MessageBox.Show("정보를 입력하세요");
                }
            }
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
           // this.Visible = false;
            SIGN sign = new SIGN();
            sign.Owner = this;
            sign.Show();
        }

      
    }
}
