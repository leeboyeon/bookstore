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
    public partial class ClientForm : Form
    {
        DataTable bookTable;
        DataTable CustomerTable;
        DataTable reservTable;
        DataTable HistoryTable;
        DataTable ReviewTable;
        DataTable BestViewTable;

        string id;
        
        public ClientForm(string id)
        {
            InitializeComponent();

            
            DataSet1TableAdapters.BOOKTableAdapter bookTableAdpater1 = new DataSet1TableAdapters.BOOKTableAdapter();
            DataSet1TableAdapters.CUSTOMERINFOTableAdapter customerinfoTableAdapter1 = new DataSet1TableAdapters.CUSTOMERINFOTableAdapter();
            DataSet1TableAdapters.RESERVATIONTableAdapter reservationTableAdapter1 = new DataSet1TableAdapters.RESERVATIONTableAdapter();
            DataSet1TableAdapters.HISTORYTableAdapter historyTableAdpater1 = new DataSet1TableAdapters.HISTORYTableAdapter();
            DataSet1TableAdapters.REVIEWTableAdapter reviewTableAdapter1 = new DataSet1TableAdapters.REVIEWTableAdapter();

            oracleConnection1.Open();

            this.id = id;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.CLASSIFICATION' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
          //  this.cLASSIFICATIONTableAdapter.Fill(this.dataSet1.CLASSIFICATION);
            // TODO: 이 코드는 데이터를 'dataSet1.HISTORY' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.hISTORYTableAdapter.Fill(this.dataSet1.HISTORY);
            this.bOOKTableAdapter.Fill(this.dataSet1.BOOK);
            bookTable = dataSet1.Tables["BOOK"];

            this.customerinfoTableAdapter1.Fill(this.dataSet1.CUSTOMERINFO);
            CustomerTable = dataSet1.Tables["CUSTOMERINFO"];

            this.reservationTableAdapter1.Fill(this.dataSet1.RESERVATION);
            reservTable = dataSet1.Tables["RESERVATION"];

            this.historyTableAdapter1.Fill(this.dataSet1.HISTORY);
            HistoryTable = dataSet1.Tables["HISTORY"];

            this.reviewTableAdapter1.Fill(this.dataSet1.REVIEW);
            ReviewTable = dataSet1.Tables["REVIEW"];

            this.bestviewTableAdapter1.Fill(this.dataSet1.BESTVIEW);
            BestViewTable = dataSet1.Tables["BESTVIEW"];

            int a = 1;

            DataRow[] bidRow = BestViewTable.Select("B_ID > 0", "COUNTCID DESC ");
            foreach (DataRow mydataRow in bidRow)
            {
                listBox1.Items.Add(a + ".   "  +  mydataRow["BOOKNAME"].ToString());
                a++;
                if (a >= 6)
                {
                    break;
                }
            }
        }

        /*콤보박스로 책검색하기*/
        private void SearchBtn_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text != null )
            {
                this.bOOKTableAdapter.findbookname(this.dataSet1.BOOK, textBox1.Text.ToString());
            }        
        }
        private void BestBook_ListLoad(object sender, EventArgs e)
        {
            //B_ID만 출력한다 view BID_COUN_CID
            
        }
        /*예약버튼 클릭이벤트*/
        private void reservBtn_Click(object sender, EventArgs e)
        {
            int Index = dataGridView2.CurrentRow.Index;
            String rentalstate = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            String rentalB_ID = dataGridView2.CurrentRow.Cells[1].Value.ToString();

            if (rentalstate == "불가능")
            {
              
                MessageBox.Show("예약되었습니다");
                int seq;
                int order;

                oracleCommand1.CommandText = "SELECT RESERVATION_SEQ.nextval FROM DUAL";
                oracleCommand2.CommandText = "SELECT count(*) FROM RESERVATION WHERE B_ID=:aa GROUP BY (B_ID)";

                oracleCommand2.Parameters["aa"].Value = rentalB_ID;
                seq = Convert.ToInt16(oracleCommand1.ExecuteScalar());
                order = Convert.ToInt16(oracleCommand2.ExecuteScalar());

                DataRow mynewDataRow = reservTable.NewRow();
                mynewDataRow["SEQNUM"] = seq;
                mynewDataRow["C_ID"] = this.id;
                mynewDataRow["ORDER_RESERV"] = order + 1;
                mynewDataRow["B_ID"] = rentalB_ID;
                mynewDataRow["E_MAIL"] = textBox3.Text;
                reservTable.Rows.Add(mynewDataRow);
                reservationTableAdapter1.Update(dataSet1.RESERVATION);

                int seq2;
                oracleCommand4.CommandText = "SELECT HISTORY_SEQ.nextval FROM DUAL";
                seq2 = Convert.ToInt16(oracleCommand4.ExecuteScalar());

                DataRow mynewDataRow2 = HistoryTable.NewRow();
                mynewDataRow2["SEQ"] = seq2;
                mynewDataRow2["C_ID"] = this.id;
                // mynewDataRow2["DUEDATE"] = now.ToLongDateString();
                mynewDataRow2["B_ID"] = rentalB_ID;
                mynewDataRow2["PRICE"] = dataGridView2.Rows[Index].Cells[5].Value;
                mynewDataRow2["STATE"] = "예약";
                HistoryTable.Rows.Add(mynewDataRow2);
                historyTableAdapter1.Update(dataSet1.HISTORY);

                MessageBox.Show("예약대기 번호는 " + (order + 1) + "입니다");
            }
            else
            {
                MessageBox.Show("바로 대여가 가능합니다");
            }
        }
        //본인 대여정보 확인 state : 반납완료 / 예약 / 대여중 
        //본인대여정보확인 
        private void Search2Btn_Click(object sender, EventArgs e)
        {          
            //다 떳다가 검색버튼 누르면 뜨는데 이거를 처음부터 뜨게 해주세요
                this.hISTORYTableAdapter.cidfilter(this.dataSet1.HISTORY,this.id.ToString());
            
        }
        private void reviewBtn_Click(object sender, EventArgs e)
        {
            String b_id = dataGridView3.CurrentRow.Cells[4].Value.ToString();
  
            DataRow mynewDataRow = ReviewTable.NewRow();
            mynewDataRow["C_ID"] = this.id;
            mynewDataRow["REVIEW"] = textBox5.Text;
            mynewDataRow["B_ID"] = b_id;
           //radiobtn click 
            if (radioButton1.Checked == true)
            {
                mynewDataRow["STAR"] = Convert.ToInt16(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                mynewDataRow["STAR"] =  Convert.ToInt16(radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                mynewDataRow["STAR"] = Convert.ToInt16(radioButton3.Text);
            }
            else if (radioButton4.Checked == true)
            {
                mynewDataRow["STAR"] = Convert.ToInt16(radioButton4.Text);
            }
            else if (radioButton5.Checked == true)
            {
                mynewDataRow["STAR"] = Convert.ToInt16(radioButton5.Text);
            }          
            ReviewTable.Rows.Add(mynewDataRow);
            reviewTableAdapter1.Update(dataSet1.REVIEW);

            MessageBox.Show("소중한 후기 감사합니다^^");
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("로그아웃을 하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Visible = false;
                Client client = new Client();
                client.Owner = this;
                client.Show();
            }
        }

        
        private void Starbtn_Click(object sender, EventArgs e)
        {
   
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    
    }
}
