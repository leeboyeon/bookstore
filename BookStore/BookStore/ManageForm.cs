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
using System.Text;
using System.Net;
using System.Net.Mail;

namespace BookStore
{
    public partial class ManageForm : Form
    {
        DataTable BookTable;
        DataTable CustomerTable;
        DataTable RentalTable;
        DataTable HistoryTable;
        DataTable ReservTable;
        DateTime now = DateTime.Now;

        public ManageForm()
        {
            InitializeComponent();
            DataSet1TableAdapters.BOOKTableAdapter bookTableAdapter1 = new DataSet1TableAdapters.BOOKTableAdapter();
            DataSet1TableAdapters.CUSTOMERINFOTableAdapter customerinfoTableAdapter1 = new DataSet1TableAdapters.CUSTOMERINFOTableAdapter();
            DataSet1TableAdapters.RENTALTableAdapter rentalTableAdapter1 = new DataSet1TableAdapters.RENTALTableAdapter();
            DataSet1TableAdapters.HISTORYTableAdapter historyTableAdapter1 = new DataSet1TableAdapters.HISTORYTableAdapter();
            DataSet1TableAdapters.RESERVATIONTableAdapter reservationTableAdapter1 = new DataSet1TableAdapters.RESERVATIONTableAdapter();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PRICE_MONTH' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRICE_MONTHTableAdapter.Fill(this.dataSet1.PRICE_MONTH);
            // TODO: 이 코드는 데이터를 'dataSet11.MONTH_SUM_PRICE' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.mONTH_SUM_PRICETableAdapter.Fill(this.dataSet11.MONTH_SUM_PRICE);
            // TODO: 이 코드는 데이터를 'dataSet11.BID_COUN_CID' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.bID_COUN_CIDTableAdapter.Fill(this.dataSet11.BID_COUN_CID);
            // TODO: 이 코드는 데이터를 'dataSet11.BLACKLIST' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.bLACKLISTTableAdapter.Fill(this.dataSet11.BLACKLIST);
            // TODO: 이 코드는 데이터를 'dataSet1.BOOK' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.bOOKTableAdapter.Fill(this.dataSet11.BOOK);
            BookTable = dataSet11.Tables["BOOK"];

            this.customerinfoTableAdapter1.Fill(this.dataSet11.CUSTOMERINFO);
            CustomerTable = dataSet11.Tables["CUSTOMERINFO"];

            this.rentalTableAdapter1.Fill(this.dataSet11.RENTAL);
            RentalTable = dataSet11.Tables["RENTAL"];

            this.historyTableAdapter1.Fill(this.dataSet11.HISTORY);
            HistoryTable = dataSet11.Tables["HISTORY"];

            this.reservationTableAdapter1.Fill(this.dataSet11.RESERVATION);
            ReservTable = dataSet11.Tables["RESERVATION"];

        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int ItemFound = bOOKBindingSource1.Find("BOOKNAME", textBox1.Text);
            bOOKBindingSource1.Position = ItemFound;
        }
        /*대여*/
        private void RentalBtn_Click(object sender, EventArgs e)
        {
            int Index = dataGridView1.CurrentRow.Index;
            String rentalstate = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            String rentalB_ID = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            if (rentalstate == "가능")
            {
                DataRow myDataRow = CustomerTable.Rows.Find(textBox3.Text);
                if (myDataRow != null)
                {
                    MessageBox.Show("대여되었습니다");
                    MessageBox.Show("대여료는 " + dataGridView1.Rows[Index].Cells[6].Value.ToString() + "입니다");
                    
                    DataRow[] new_state = BookTable.Select("대여가능 = '" + dataGridView1.Rows[Index].Cells[0].Value.ToString() + "'");

                    int seq;
                    int seq2;

                    if (new_state != null)
                    {
                        dataGridView1.Rows[Index].Cells[5].Value = "불가능";
                        this.bOOKBindingSource1.EndEdit();
                        bOOKTableAdapter.Update(dataSet11.BOOK);
                        /*대여가 되면 rentaltable에 정보를 저장시킨다*/
                        oracleConnection1.Open();
                        oracleCommand1.CommandText = "SELECT RENTAL_SEQ.nextval FROM DUAL";
                        seq = Convert.ToInt16(oracleCommand1.ExecuteScalar());

                        //대여되면 RentalTable에 대여목록 저장
                        DataRow mynewDataRow = RentalTable.NewRow();
                        mynewDataRow["R_ID"] = seq;
                        mynewDataRow["DUEDATE"] = now.ToLongDateString();
                        mynewDataRow["EXTENSIONDATE"] = now.AddDays(7).ToLongDateString();
                        mynewDataRow["C_ID"] = textBox3.Text;
                        mynewDataRow["B_ID"] = rentalB_ID;
                        mynewDataRow["RENTALPRICE"] = dataGridView1.Rows[Index].Cells[6].Value;
                        RentalTable.Rows.Add(mynewDataRow);
                        //저장시킨 데이터를 동기화시킨다
                        rentalTableAdapter1.Update(dataSet11.RENTAL);

                        oracleCommand3.CommandText = "SELECT HISTORY_SEQ.nextval FROM DUAL";
                        seq2 = Convert.ToInt16(oracleCommand3.ExecuteScalar());
                        //대여가 되면 History Table에 대여목록 저장
                        DataRow mynewDataRow2 = HistoryTable.NewRow();
                        mynewDataRow2["SEQ"] = seq2;
                        mynewDataRow2["C_ID"] = textBox3.Text;
                        mynewDataRow2["DUEDATE"] = now.ToLongDateString();
                        mynewDataRow2["B_ID"] = rentalB_ID;
                        mynewDataRow2["PRICE"] = dataGridView1.Rows[Index].Cells[6].Value;
                        mynewDataRow2["STATE"] = "대여중";
                        HistoryTable.Rows.Add(mynewDataRow2);
                        historyTableAdapter1.Update(dataSet11.HISTORY);

                        oracleConnection1.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("존재하지 않는 회원입니다");
                }
            }
            else
            {
                MessageBox.Show("대여가 불가능합니다");
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            rentalTableAdapter1.Update(dataSet11.RENTAL);
            DataRow[] foundRows = RentalTable.Select("C_ID LIKE '%" + textBox3.Text + "%'");
            foreach (DataRow mydataRow in foundRows)
            {
                listBox1.Items.Add(mydataRow["B_ID"].ToString());
            }
        }

        private void ListDoubleClick_Event(object sender, EventArgs e)
        {
            String r_id = "";
            String b_id = listBox1.SelectedItem.ToString();
            String seqnum = "";
            String Email = "";
            int order_re = 0;
           
            int Index = bOOKBindingSource1.Find("B_ID", b_id);
            if (listBox1.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("반납하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    /*연체료 계산해서 customertable에 저장하기 : 연체료는 모든 대여책 연체료 합산*/
                    
                    DateTime SDate = now.AddDays(7);
                    DateTime EDate = DateTime.Now;
                    
                    TimeSpan TS = SDate - EDate;
                    int diffDay = TS.Days;
                    int lateFee = 0;

                    if( EDate > SDate)
                    {
                        lateFee = diffDay * 700;
                    }
                    else if (EDate <= SDate)
                    {
                        lateFee = 0;
                    }
                    
                    oracleConnection1.Open();
                    
                    oracleCommand2.CommandText = "UPDATE CUSTOMERINFO SET CLATEFEE = CLATEFEE +" + lateFee + "WHERE C_ID = '" + textBox3.Text.ToString() + "'";
                    MessageBox.Show(textBox3.Text.ToString() + "님의 연체료는 총 " + lateFee + "입니다.");                   
                    oracleCommand2.ExecuteNonQuery();

                    oracleCommand4.CommandText = "UPDATE HISTORY SET LATEFEE =" + lateFee + "WHERE C_ID ='" + textBox3.Text.ToString() +"'";
                    oracleCommand4.ExecuteNonQuery();
                    //UPDATE HISTORY SET STATE = '반납완료' WHERE C_ID = 'test' AND B_ID = '203';
                    oracleCommand5.Parameters["b_id"].Value = b_id;
                    oracleCommand5.CommandText = "UPDATE HISTORY SET STATE = '반납완료' WHERE C_ID ='" + textBox3.Text.ToString() + "' AND B_ID = :b_id" ;
                    oracleCommand5.ExecuteNonQuery();
                    
                    oracleConnection1.Close();
                    
                    MessageBox.Show("반납완료");

                    /*반납되면 바로 reservTable에 있는 같은 b_id를 찾아 그 중 ORDER_RESERV가 1인 회원의 E_MAIL로 메일전송*/
                    //1. 같은 b_id 를 reservtable에서 찾는다
                    DataRow[] foundb_id = ReservTable.Select("B_ID = '" + b_id + "'");
                    //2. 그 b_id의 PK인 seqnum을 찾는다.
                    foreach (DataRow mydataRow in foundb_id)
                    {
                        seqnum = mydataRow["SEQNUM"].ToString();
                        DataRow reservKey = ReservTable.Rows.Find(seqnum);
                        if (seqnum != null)
                        {
                            order_re = Convert.ToInt16(reservKey["ORDER_RESERV"].ToString());
                            if (order_re == 1)
                            {
                                Email = reservKey["E_MAIL"].ToString();
                            }
                        }
                    }
                    //3.seqnum의 우선순위가 1인 것을 찾는다
                   
                    Mail mail = new Mail();
                    mail.set_receive(Email);
                    MessageBox.Show(Email + "님에게 예약메일이 발송되었습니다.");
                    /*반납이 되면 rentaltable에 있는 행 삭제*/
                    // 불가능 -> 가능 (test)
                    DataRow[] state_return = BookTable.Select("대여가능 = '" + dataGridView1.Rows[Index].Cells[0].Value.ToString() + "'");
                    if (state_return != null)
                    {
                        dataGridView1.Rows[Index].Cells[5].Value = "가능";
                        this.bOOKBindingSource1.EndEdit();
                        bOOKTableAdapter.Update(dataSet11.BOOK);
                        
                        //테이블에서 삭제하는거
                        DataRow[] rental = RentalTable.Select("B_ID = '" + b_id + "'");
                        foreach (DataRow mydataRow in rental)
                        {
                            r_id = mydataRow["R_ID"].ToString();
                        }
                        DataRow rentalkey = RentalTable.Rows.Find(r_id);
                        if (rentalkey != null)
                        {
                            rentalkey.Delete();
                            rentalTableAdapter1.Update(dataSet11.RENTAL);            
                        }
                        listBox1.Items.Clear();
                        ReturnBtn_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                     
                }
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "회원이름")
            {
                int ItemFound = cUSTOMERINFOBindingSource.Find("CNAME", textBox2.Text);
                if (ItemFound != null)
                {
                    cUSTOMERINFOBindingSource.Position = ItemFound;
                }
                else
                {
                    MessageBox.Show("존재하지 않는 회원이름입니다");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "회원ID")
            {
                int ItemFound = cUSTOMERINFOBindingSource.Find("C_ID", textBox2.Text);
                if (ItemFound != null)
                {
                    cUSTOMERINFOBindingSource.Position = ItemFound;
                }
                else
                {
                    MessageBox.Show("존재하지 않는 회원ID입니다");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "회원전화번호")
            {
                int ItemFound = cUSTOMERINFOBindingSource.Find("CPHONENUM", textBox2.Text);
                if (ItemFound != null)
                {
                    cUSTOMERINFOBindingSource.Position = ItemFound;
                }
                else
                {
                    MessageBox.Show("존재하지 않는 전화번호 입니다");
                }
            }
        }

        private void ManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void CustomerDeleteBtn_Click(object sender, EventArgs e)
        {
            cUSTOMERINFOBindingSource.RemoveCurrent();
            this.cUSTOMERINFOBindingSource.EndEdit();
            customerinfoTableAdapter1.Update(dataSet11.CUSTOMERINFO);
        }

        private void SuccBtn_Click(object sender, EventArgs e)
        {
            //C_ID가 NULL이 안된다는데 이게 몬소리죠?
        //    bLACKLISTBindingSource.AddNew();
         //   this.bLACKLISTBindingSource.EndEdit();
        //    bLACKLISTTableAdapter.Update(dataSet11.BLACKLIST);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            bLACKLISTBindingSource.RemoveCurrent();
            this.bLACKLISTBindingSource.EndEdit();
            bLACKLISTTableAdapter.Update(dataSet11.BLACKLIST);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //상품 추가
            DataRow mynewDataRow = BookTable.NewRow();
            mynewDataRow["BOOKNAME"] = textBox4.Text;
            mynewDataRow["B_ID"] = textBox5.Text;
            mynewDataRow["PUBLISHINGHOUSE"] = textBox6.Text;
            mynewDataRow["BLEVEL"] = textBox9.Text;
            mynewDataRow["CLASS_ID"] = textBox7.Text;
            mynewDataRow["PRICE"] = textBox8.Text;
            mynewDataRow["대여가능"] = "가능";
            BookTable.Rows.Add(mynewDataRow);
            bOOKTableAdapter.Update(dataSet11.BOOK);
            MessageBox.Show("추가되었습니다");

        }
        private void viewClick_Event(object sender, DataGridViewCellEventArgs e)
        {
         
        }      
        private void EditBtn_Click(object sender, EventArgs e)
        {
            this.bOOKTableAdapter.Update(this.dataSet11.BOOK);
            
        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Edit_Event(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BookDeleteBtn_Click(object sender, EventArgs e)
        {
            bOOKBindingSource.RemoveCurrent();
            this.bOOKBindingSource.EndEdit();
            bOOKTableAdapter.Update(dataSet11.BOOK);
        }

        private void customerEditBtn_Click(object sender, EventArgs e)
        {
            this.customerinfoTableAdapter1.Update(this.dataSet11.CUSTOMERINFO);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ItemClick_Event(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    

      
    }
     public partial class Mail
     {
         MailMessage mail = new MailMessage();

         private MailAddress send = new MailAddress("qhdus101@gmail.com");
         private string send_pw = "qhdus106902";
         private MailAddress receive = null;

         public void set_receive(string rec)
         {
             this.receive = new MailAddress(rec);
         }
         public string sendmail()
         {
             SmtpClient smtp = null;
             MailMessage msg = null;

             try
             {
                 smtp = new SmtpClient
                 {
                     Host = "smtp.gmail.com",
                     EnableSsl = true,
                     DeliveryMethod = SmtpDeliveryMethod.Network,
                     Credentials = new NetworkCredential(send.Address, send_pw),

                     Timeout = 20000
                 };

                 msg = new MailMessage(send, receive)
                 {
                     Subject = "<BOOKSTORE>에서 예약건으로 연락드립니다.",
                     Body = " <BOOKSTORE>에서 고객님이 예약해주신 책이 현재 대여가능 상태입니다. 2일 내로 오시지 않으시면 예약취소됩니다 감사합니다."
                 };
                 smtp.Send(msg);
                 MessageBox.Show("메일 발송 완료");
                 return "매일 발송이 완료되었습니다";
                 
             }
             catch (Exception e)
             {
                 return "메일 발송이 실패되었습니다";
             }
         }

     }
    
    

    
}
