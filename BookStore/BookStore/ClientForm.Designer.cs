namespace BookStore
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Oracle.DataAccess.Client.OracleParameter oracleParameter1 = new Oracle.DataAccess.Client.OracleParameter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BookStore.DataSet1();
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hISTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new BookStore.DataSet1TableAdapters.BOOKTableAdapter();
            this.customerinfoTableAdapter1 = new BookStore.DataSet1TableAdapters.CUSTOMERINFOTableAdapter();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.hISTORYTableAdapter = new BookStore.DataSet1TableAdapters.HISTORYTableAdapter();
            this.reservationTableAdapter1 = new BookStore.DataSet1TableAdapters.RESERVATIONTableAdapter();
            this.oracleCommand2 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand3 = new Oracle.DataAccess.Client.OracleCommand();
            this.historyTableAdapter1 = new BookStore.DataSet1TableAdapters.HISTORYTableAdapter();
            this.oracleCommand4 = new Oracle.DataAccess.Client.OracleCommand();
            this.reviewTableAdapter1 = new BookStore.DataSet1TableAdapters.REVIEWTableAdapter();
            this.oracleCommand5 = new Oracle.DataAccess.Client.OracleCommand();
            this.button5 = new System.Windows.Forms.Button();
            this.bestviewTableAdapter1 = new BookStore.DataSet1TableAdapters.BESTVIEWTableAdapter();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bOOKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLEVELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대여가능DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bOOKNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLEVELDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대여가능DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.sEQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lATEFEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1106, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            this.bOOKBindingSource1.DataSource = this.dataSet1;
            // 
            // hISTORYBindingSource
            // 
            this.hISTORYBindingSource.DataMember = "HISTORY";
            this.hISTORYBindingSource.DataSource = this.dataSet1;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // customerinfoTableAdapter1
            // 
            this.customerinfoTableAdapter1.ClearBeforeFill = true;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORCL;USER ID=A5469761; PASSWORD=5469761;";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Transaction = null;
            // 
            // hISTORYTableAdapter
            // 
            this.hISTORYTableAdapter.ClearBeforeFill = true;
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter1.ParameterName = "aa";
            this.oracleCommand2.Parameters.Add(oracleParameter1);
            this.oracleCommand2.Transaction = null;
            // 
            // oracleCommand3
            // 
            this.oracleCommand3.Transaction = null;
            // 
            // historyTableAdapter1
            // 
            this.historyTableAdapter1.ClearBeforeFill = true;
            // 
            // oracleCommand4
            // 
            this.oracleCommand4.Connection = this.oracleConnection1;
            this.oracleCommand4.Transaction = null;
            // 
            // reviewTableAdapter1
            // 
            this.reviewTableAdapter1.ClearBeforeFill = true;
            // 
            // oracleCommand5
            // 
            this.oracleCommand5.Connection = this.oracleConnection1;
            this.oracleCommand5.Transaction = null;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1019, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "로그아웃";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // bestviewTableAdapter1
            // 
            this.bestviewTableAdapter1.ClearBeforeFill = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::BookStore.Properties.Resources.짱구는_왜_못말릴까;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1098, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "검색모드";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(728, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 289);
            this.listBox1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::BookStore.Properties.Resources.panel;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(698, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 391);
            this.panel5.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("경기천년제목V Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(58, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 32);
            this.label11.TabIndex = 5;
            this.label11.Text = "<BEST 5>";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKNAMEDataGridViewTextBoxColumn,
            this.bIDDataGridViewTextBoxColumn,
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn,
            this.bLEVELDataGridViewTextBoxColumn,
            this.cLASSIDDataGridViewTextBoxColumn,
            this.대여가능DataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bOOKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(160, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(511, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // bOOKNAMEDataGridViewTextBoxColumn
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.HeaderText = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.Name = "bOOKNAMEDataGridViewTextBoxColumn";
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "B_ID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.Width = 55;
            // 
            // pUBLISHINGHOUSEDataGridViewTextBoxColumn
            // 
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHINGHOUSE";
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn.HeaderText = "PUBLISHINGHOUSE";
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn.Name = "pUBLISHINGHOUSEDataGridViewTextBoxColumn";
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn.Width = 142;
            // 
            // bLEVELDataGridViewTextBoxColumn
            // 
            this.bLEVELDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bLEVELDataGridViewTextBoxColumn.DataPropertyName = "BLEVEL";
            this.bLEVELDataGridViewTextBoxColumn.HeaderText = "BLEVEL";
            this.bLEVELDataGridViewTextBoxColumn.Name = "bLEVELDataGridViewTextBoxColumn";
            this.bLEVELDataGridViewTextBoxColumn.Width = 76;
            // 
            // cLASSIDDataGridViewTextBoxColumn
            // 
            this.cLASSIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cLASSIDDataGridViewTextBoxColumn.DataPropertyName = "CLASS_ID";
            this.cLASSIDDataGridViewTextBoxColumn.HeaderText = "CLASS_ID";
            this.cLASSIDDataGridViewTextBoxColumn.Name = "cLASSIDDataGridViewTextBoxColumn";
            this.cLASSIDDataGridViewTextBoxColumn.Width = 87;
            // 
            // 대여가능DataGridViewTextBoxColumn
            // 
            this.대여가능DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.대여가능DataGridViewTextBoxColumn.DataPropertyName = "대여가능";
            this.대여가능DataGridViewTextBoxColumn.HeaderText = "대여가능";
            this.대여가능DataGridViewTextBoxColumn.Name = "대여가능DataGridViewTextBoxColumn";
            this.대여가능DataGridViewTextBoxColumn.Width = 78;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.Width = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("경기천년제목 Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(170, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "책이름";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 30);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(590, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::BookStore.Properties.Resources.짱구는_왜_못말릴까;
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1098, 519);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "예약하기";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(781, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "예약하기";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BackgroundImage = global::BookStore.Properties.Resources.panel2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(663, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 414);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("경기천년바탕 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(61, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "(추후 예약이 가능할때 Email발송됩니다)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 186);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 25);
            this.textBox3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("경기천년바탕 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(7, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "3. 예약가능날짜는 확실하지 않습니다.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("경기천년바탕 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(6, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("경기천년바탕 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "2. 반납기준 책의 상태에 따라 벌금이 부과될 수 있습니다.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("경기천년바탕 Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(292, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "예약하기";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.reservBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("경기천년바탕 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "1. 기간은 무조건 7일입니다.(초과시 연체료 1일 기준 700원)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("경기천년제목 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "예약시 주의사항";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("경기천년제목V Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(247, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "BOOKLIST";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKNAMEDataGridViewTextBoxColumn1,
            this.bIDDataGridViewTextBoxColumn1,
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1,
            this.bLEVELDataGridViewTextBoxColumn1,
            this.대여가능DataGridViewTextBoxColumn1,
            this.pRICEDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bOOKBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(74, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(563, 414);
            this.dataGridView2.TabIndex = 0;
            // 
            // bOOKNAMEDataGridViewTextBoxColumn1
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn1.DataPropertyName = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn1.HeaderText = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn1.Name = "bOOKNAMEDataGridViewTextBoxColumn1";
            // 
            // bIDDataGridViewTextBoxColumn1
            // 
            this.bIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bIDDataGridViewTextBoxColumn1.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn1.HeaderText = "B_ID";
            this.bIDDataGridViewTextBoxColumn1.Name = "bIDDataGridViewTextBoxColumn1";
            this.bIDDataGridViewTextBoxColumn1.Width = 55;
            // 
            // pUBLISHINGHOUSEDataGridViewTextBoxColumn1
            // 
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1.DataPropertyName = "PUBLISHINGHOUSE";
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1.HeaderText = "PUBLISHINGHOUSE";
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1.Name = "pUBLISHINGHOUSEDataGridViewTextBoxColumn1";
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1.Width = 142;
            // 
            // bLEVELDataGridViewTextBoxColumn1
            // 
            this.bLEVELDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bLEVELDataGridViewTextBoxColumn1.DataPropertyName = "BLEVEL";
            this.bLEVELDataGridViewTextBoxColumn1.HeaderText = "BLEVEL";
            this.bLEVELDataGridViewTextBoxColumn1.Name = "bLEVELDataGridViewTextBoxColumn1";
            this.bLEVELDataGridViewTextBoxColumn1.Width = 76;
            // 
            // 대여가능DataGridViewTextBoxColumn1
            // 
            this.대여가능DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.대여가능DataGridViewTextBoxColumn1.DataPropertyName = "대여가능";
            this.대여가능DataGridViewTextBoxColumn1.HeaderText = "대여가능";
            this.대여가능DataGridViewTextBoxColumn1.Name = "대여가능DataGridViewTextBoxColumn1";
            this.대여가능DataGridViewTextBoxColumn1.Width = 78;
            // 
            // pRICEDataGridViewTextBoxColumn1
            // 
            this.pRICEDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pRICEDataGridViewTextBoxColumn1.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn1.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn1.Name = "pRICEDataGridViewTextBoxColumn1";
            this.pRICEDataGridViewTextBoxColumn1.Width = 66;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::BookStore.Properties.Resources.짱구는_왜_못말릴까;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1098, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "본인대여정보";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BackgroundImage = global::BookStore.Properties.Resources.panel3;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.radioButton5);
            this.panel4.Controls.Add(this.radioButton4);
            this.panel4.Controls.Add(this.radioButton3);
            this.panel4.Controls.Add(this.radioButton2);
            this.panel4.Controls.Add(this.radioButton1);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(768, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 440);
            this.panel4.TabIndex = 8;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.Font = new System.Drawing.Font("경기천년바탕 Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton5.Location = new System.Drawing.Point(244, 327);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(32, 17);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "1";
            this.radioButton5.UseVisualStyleBackColor = false;
            this.radioButton5.Click += new System.EventHandler(this.Starbtn_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Font = new System.Drawing.Font("경기천년바탕 Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton4.Location = new System.Drawing.Point(197, 327);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(32, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "2";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.Click += new System.EventHandler(this.Starbtn_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("경기천년바탕 Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton3.Location = new System.Drawing.Point(150, 327);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.Click += new System.EventHandler(this.Starbtn_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("경기천년바탕 Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.Location = new System.Drawing.Point(103, 327);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "4";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Click += new System.EventHandler(this.Starbtn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("경기천년바탕 Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.Location = new System.Drawing.Point(56, 327);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Click += new System.EventHandler(this.Starbtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::BookStore.Properties.Resources.버튼2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(9, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 92);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.reviewBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("경기천년바탕 Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(3, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(307, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "선택한 책에 대한 후기를 남겨주세요(300자 내외)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(24, 116);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(270, 189);
            this.textBox5.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("경기천년제목 Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(96, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "REVIEW";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BackgroundImage = global::BookStore.Properties.Resources.panel;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.monthCalendar1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(449, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 440);
            this.panel3.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(37, 89);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("경기천년제목 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(84, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "날짜로 검색";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::BookStore.Properties.Resources.버튼2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(153, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 128);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Search2Btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(740, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sEQDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.dUEDATEDataGridViewTextBoxColumn,
            this.lATEFEEDataGridViewTextBoxColumn,
            this.bIDDataGridViewTextBoxColumn2,
            this.pRICEDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.hISTORYBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(64, 36);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(366, 440);
            this.dataGridView3.TabIndex = 0;
            // 
            // sEQDataGridViewTextBoxColumn
            // 
            this.sEQDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sEQDataGridViewTextBoxColumn.DataPropertyName = "SEQ";
            this.sEQDataGridViewTextBoxColumn.HeaderText = "SEQ";
            this.sEQDataGridViewTextBoxColumn.Name = "sEQDataGridViewTextBoxColumn";
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            // 
            // dUEDATEDataGridViewTextBoxColumn
            // 
            this.dUEDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dUEDATEDataGridViewTextBoxColumn.DataPropertyName = "DUEDATE";
            this.dUEDATEDataGridViewTextBoxColumn.HeaderText = "DUEDATE";
            this.dUEDATEDataGridViewTextBoxColumn.Name = "dUEDATEDataGridViewTextBoxColumn";
            // 
            // lATEFEEDataGridViewTextBoxColumn
            // 
            this.lATEFEEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lATEFEEDataGridViewTextBoxColumn.DataPropertyName = "LATEFEE";
            this.lATEFEEDataGridViewTextBoxColumn.HeaderText = "LATEFEE";
            this.lATEFEEDataGridViewTextBoxColumn.Name = "lATEFEEDataGridViewTextBoxColumn";
            // 
            // bIDDataGridViewTextBoxColumn2
            // 
            this.bIDDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bIDDataGridViewTextBoxColumn2.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn2.HeaderText = "B_ID";
            this.bIDDataGridViewTextBoxColumn2.Name = "bIDDataGridViewTextBoxColumn2";
            // 
            // pRICEDataGridViewTextBoxColumn2
            // 
            this.pRICEDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pRICEDataGridViewTextBoxColumn2.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn2.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn2.Name = "pRICEDataGridViewTextBoxColumn2";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 558);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private DataSet1TableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHINGHOUSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLEVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대여가능DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHINGHOUSEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLEVELDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대여가능DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bOOKBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private DataSet1TableAdapters.CUSTOMERINFOTableAdapter customerinfoTableAdapter1;
        private DataSet1TableAdapters.RESERVATIONTableAdapter reservationTableAdapter1;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource hISTORYBindingSource;
        private DataSet1TableAdapters.HISTORYTableAdapter hISTORYTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lATEFEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand2;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand3;
        private DataSet1TableAdapters.HISTORYTableAdapter historyTableAdapter1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private DataSet1TableAdapters.REVIEWTableAdapter reviewTableAdapter1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private DataSet1TableAdapters.BESTVIEWTableAdapter bestviewTableAdapter1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
    }
}