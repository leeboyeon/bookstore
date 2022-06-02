using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class SIGN : Form
    {
        DataTable signTable;
        DataTable customerTable;
        public SIGN()
        {
            InitializeComponent();
            DataSet1TableAdapters.CUSTOMERINFOTableAdapter customerinfoTableAdapter = new DataSet1TableAdapters.CUSTOMERINFOTableAdapter();
        }
        private void SIGN_Load(object sender, EventArgs e)
        {
            oracleConnection1.Open();
            oracleDataAdapter1.Fill(dataSet11, "CUSTOMERINFO");
            oracleConnection1.Close();

            this.customerinfoTableAdapter1.Fill(this.dataSet11.CUSTOMERINFO);

            signTable = dataSet11.Tables["CUSTOMERINFO"];
            customerTable = dataSet11.Tables["CUSTOMERINFO"];
        }
        private void SuccesBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            DataRow mynewDataRow = signTable.NewRow();
            mynewDataRow["C_ID"] = textBox1.Text;
            mynewDataRow["C_PW"] = textBox2.Text;
            mynewDataRow["CNAME"] = textBox3.Text;
            mynewDataRow["CPHONENUM"] = textBox4.Text;
            mynewDataRow["CSSN"] = textBox5.Text;
            signTable.Rows.Add(mynewDataRow);
            oracleDataAdapter1.Update(signTable);
            MessageBox.Show("회원가입이 완료되었습니다");
        }

        private void doubleCheckBtn_Click(object sender, EventArgs e)
        {
            

        }

        
    }
}
