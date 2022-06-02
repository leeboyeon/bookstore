namespace BookStore
{
    partial class ManageForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Oracle.DataAccess.Client.OracleParameter oracleParameter1 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter2 = new Oracle.DataAccess.Client.OracleParameter();
            Oracle.DataAccess.Client.OracleParameter oracleParameter3 = new Oracle.DataAccess.Client.OracleParameter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bOOKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLEVELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대여가능DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new BookStore.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oracleConnection1 = new Oracle.DataAccess.Client.OracleConnection();
            this.oracleCommand1 = new Oracle.DataAccess.Client.OracleCommand();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPHONENUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLEVELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLATEFEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pENALTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wARNINGNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLACKLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.bOOKNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLEVELDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대여가능DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bIDCOUNCIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mONTHSUMPRICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pRICEMONTHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BookStore.DataSet1();
            this.oracleCommand2 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand3 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand4 = new Oracle.DataAccess.Client.OracleCommand();
            this.oracleCommand5 = new Oracle.DataAccess.Client.OracleCommand();
            this.bOOKTableAdapter = new BookStore.DataSet1TableAdapters.BOOKTableAdapter();
            this.customerinfoTableAdapter1 = new BookStore.DataSet1TableAdapters.CUSTOMERINFOTableAdapter();
            this.rentalTableAdapter1 = new BookStore.DataSet1TableAdapters.RENTALTableAdapter();
            this.hISTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERINFOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bLACKLISTTableAdapter = new BookStore.DataSet1TableAdapters.BLACKLISTTableAdapter();
            this.historyTableAdapter1 = new BookStore.DataSet1TableAdapters.HISTORYTableAdapter();
            this.reservationTableAdapter1 = new BookStore.DataSet1TableAdapters.RESERVATIONTableAdapter();
            this.bID_COUN_CIDTableAdapter = new BookStore.DataSet1TableAdapters.BID_COUN_CIDTableAdapter();
            this.mONTH_SUM_PRICETableAdapter = new BookStore.DataSet1TableAdapters.MONTH_SUM_PRICETableAdapter();
            this.pRICE_MONTHTableAdapter = new BookStore.DataSet1TableAdapters.PRICE_MONTHTableAdapter();
            this.oracleCommand6 = new Oracle.DataAccess.Client.OracleCommand();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.직원정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.마감ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERINFOBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLACKLISTBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIDCOUNCIDBindingSource)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTHSUMPRICEBindingSource)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRICEMONTHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERINFOBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.DataSource = this.bOOKBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(18, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(748, 419);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewClick_Event);
            // 
            // bOOKNAMEDataGridViewTextBoxColumn
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.HeaderText = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.Name = "bOOKNAMEDataGridViewTextBoxColumn";
            this.bOOKNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bIDDataGridViewTextBoxColumn
            // 
            this.bIDDataGridViewTextBoxColumn.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn.HeaderText = "B_ID";
            this.bIDDataGridViewTextBoxColumn.Name = "bIDDataGridViewTextBoxColumn";
            this.bIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUBLISHINGHOUSEDataGridViewTextBoxColumn
            // 
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHINGHOUSE";
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn.HeaderText = "PUBLISHINGHOUSE";
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn.Name = "pUBLISHINGHOUSEDataGridViewTextBoxColumn";
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bLEVELDataGridViewTextBoxColumn
            // 
            this.bLEVELDataGridViewTextBoxColumn.DataPropertyName = "BLEVEL";
            this.bLEVELDataGridViewTextBoxColumn.HeaderText = "BLEVEL";
            this.bLEVELDataGridViewTextBoxColumn.Name = "bLEVELDataGridViewTextBoxColumn";
            this.bLEVELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLASSIDDataGridViewTextBoxColumn
            // 
            this.cLASSIDDataGridViewTextBoxColumn.DataPropertyName = "CLASS_ID";
            this.cLASSIDDataGridViewTextBoxColumn.HeaderText = "CLASS_ID";
            this.cLASSIDDataGridViewTextBoxColumn.Name = "cLASSIDDataGridViewTextBoxColumn";
            this.cLASSIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 대여가능DataGridViewTextBoxColumn
            // 
            this.대여가능DataGridViewTextBoxColumn.DataPropertyName = "대여가능";
            this.대여가능DataGridViewTextBoxColumn.HeaderText = "대여가능";
            this.대여가능DataGridViewTextBoxColumn.Name = "대여가능DataGridViewTextBoxColumn";
            this.대여가능DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOOKBindingSource1
            // 
            this.bOOKBindingSource1.DataMember = "BOOK";
            this.bOOKBindingSource1.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬바탕 확장", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "책이름";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 33);
            this.textBox1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(585, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(772, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 423);
            this.panel1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(16, 213);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 196);
            this.listBox1.TabIndex = 16;
            this.listBox1.DoubleClick += new System.EventHandler(this.ListDoubleClick_Event);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(131, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 57);
            this.button2.TabIndex = 15;
            this.button2.Text = "대여";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RentalBtn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(16, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 57);
            this.button3.TabIndex = 14;
            this.button3.Text = "반납";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 87);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 40);
            this.textBox3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "회원 ID를 입력하시오";
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=ORCL;USER ID=A5469761; PASSWORD=5469761;";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.CommandText = "SELECT * FROM RENTAL";
            this.oracleCommand1.Connection = this.oracleConnection1;
            this.oracleCommand1.Transaction = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 502);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1046, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "반납 및 대여";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1046, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "회원정보보기";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(916, 417);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 48);
            this.button6.TabIndex = 5;
            this.button6.Text = "정보수정";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.customerEditBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(792, 417);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "회원삭제";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CustomerDeleteBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.cPWDataGridViewTextBoxColumn,
            this.cNAMEDataGridViewTextBoxColumn,
            this.cPHONENUMDataGridViewTextBoxColumn,
            this.cSSNDataGridViewTextBoxColumn,
            this.cLEVELDataGridViewTextBoxColumn,
            this.cLATEFEEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cUSTOMERINFOBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(25, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(761, 405);
            this.dataGridView2.TabIndex = 3;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            // 
            // cPWDataGridViewTextBoxColumn
            // 
            this.cPWDataGridViewTextBoxColumn.DataPropertyName = "C_PW";
            this.cPWDataGridViewTextBoxColumn.HeaderText = "C_PW";
            this.cPWDataGridViewTextBoxColumn.Name = "cPWDataGridViewTextBoxColumn";
            // 
            // cNAMEDataGridViewTextBoxColumn
            // 
            this.cNAMEDataGridViewTextBoxColumn.DataPropertyName = "CNAME";
            this.cNAMEDataGridViewTextBoxColumn.HeaderText = "CNAME";
            this.cNAMEDataGridViewTextBoxColumn.Name = "cNAMEDataGridViewTextBoxColumn";
            // 
            // cPHONENUMDataGridViewTextBoxColumn
            // 
            this.cPHONENUMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPHONENUMDataGridViewTextBoxColumn.DataPropertyName = "CPHONENUM";
            this.cPHONENUMDataGridViewTextBoxColumn.HeaderText = "CPHONENUM";
            this.cPHONENUMDataGridViewTextBoxColumn.Name = "cPHONENUMDataGridViewTextBoxColumn";
            // 
            // cSSNDataGridViewTextBoxColumn
            // 
            this.cSSNDataGridViewTextBoxColumn.DataPropertyName = "CSSN";
            this.cSSNDataGridViewTextBoxColumn.HeaderText = "CSSN";
            this.cSSNDataGridViewTextBoxColumn.Name = "cSSNDataGridViewTextBoxColumn";
            // 
            // cLEVELDataGridViewTextBoxColumn
            // 
            this.cLEVELDataGridViewTextBoxColumn.DataPropertyName = "CLEVEL";
            this.cLEVELDataGridViewTextBoxColumn.HeaderText = "CLEVEL";
            this.cLEVELDataGridViewTextBoxColumn.Name = "cLEVELDataGridViewTextBoxColumn";
            // 
            // cLATEFEEDataGridViewTextBoxColumn
            // 
            this.cLATEFEEDataGridViewTextBoxColumn.DataPropertyName = "CLATEFEE";
            this.cLATEFEEDataGridViewTextBoxColumn.HeaderText = "CLATEFEE";
            this.cLATEFEEDataGridViewTextBoxColumn.Name = "cLATEFEEDataGridViewTextBoxColumn";
            // 
            // cUSTOMERINFOBindingSource
            // 
            this.cUSTOMERINFOBindingSource.DataMember = "CUSTOMERINFO";
            this.cUSTOMERINFOBindingSource.DataSource = this.dataSet11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(521, 21);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "회원이름",
            "회원ID",
            "회원전화번호"});
            this.comboBox1.Location = new System.Drawing.Point(25, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1046, 476);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "블랙리스트관리";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(883, 411);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 59);
            this.button8.TabIndex = 2;
            this.button8.Text = "삭제";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(727, 411);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 59);
            this.button7.TabIndex = 1;
            this.button7.Text = "등록";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SuccBtn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn1,
            this.pENALTYDataGridViewTextBoxColumn,
            this.rEASONDataGridViewTextBoxColumn,
            this.wARNINGNUMBERDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.bLACKLISTBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(31, 18);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(652, 452);
            this.dataGridView3.TabIndex = 0;
            // 
            // cIDDataGridViewTextBoxColumn1
            // 
            this.cIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cIDDataGridViewTextBoxColumn1.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn1.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn1.Name = "cIDDataGridViewTextBoxColumn1";
            this.cIDDataGridViewTextBoxColumn1.Width = 56;
            // 
            // pENALTYDataGridViewTextBoxColumn
            // 
            this.pENALTYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pENALTYDataGridViewTextBoxColumn.DataPropertyName = "PENALTY";
            this.pENALTYDataGridViewTextBoxColumn.HeaderText = "PENALTY";
            this.pENALTYDataGridViewTextBoxColumn.Name = "pENALTYDataGridViewTextBoxColumn";
            this.pENALTYDataGridViewTextBoxColumn.Width = 86;
            // 
            // rEASONDataGridViewTextBoxColumn
            // 
            this.rEASONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rEASONDataGridViewTextBoxColumn.DataPropertyName = "REASON";
            this.rEASONDataGridViewTextBoxColumn.HeaderText = "REASON";
            this.rEASONDataGridViewTextBoxColumn.Name = "rEASONDataGridViewTextBoxColumn";
            // 
            // wARNINGNUMBERDataGridViewTextBoxColumn
            // 
            this.wARNINGNUMBERDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.wARNINGNUMBERDataGridViewTextBoxColumn.DataPropertyName = "WARNINGNUMBER";
            this.wARNINGNUMBERDataGridViewTextBoxColumn.HeaderText = "WARNINGNUMBER";
            this.wARNINGNUMBERDataGridViewTextBoxColumn.Name = "wARNINGNUMBERDataGridViewTextBoxColumn";
            this.wARNINGNUMBERDataGridViewTextBoxColumn.Width = 138;
            // 
            // bLACKLISTBindingSource
            // 
            this.bLACKLISTBindingSource.DataMember = "BLACKLIST";
            this.bLACKLISTBindingSource.DataSource = this.dataSet11;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1046, 476);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "상품관리";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel4.Location = new System.Drawing.Point(493, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 438);
            this.panel4.TabIndex = 18;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(50, 330);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 16);
            this.label23.TabIndex = 12;
            this.label23.Text = "하 : 1000~2000원대로 설정";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(50, 306);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(200, 16);
            this.label22.TabIndex = 11;
            this.label22.Text = "중 : 3000~4000원대로 설정";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(50, 282);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(200, 16);
            this.label21.TabIndex = 10;
            this.label21.Text = "상 : 5000~6000원대로 설정";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(23, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 16);
            this.label20.TabIndex = 9;
            this.label20.Text = "2. CLASS_ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(50, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(166, 16);
            this.label19.TabIndex = 8;
            this.label19.Text = "A~F로 넘어갈 때 마다";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(23, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "3. PRICE";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(48, 233);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(161, 16);
            this.label18.TabIndex = 6;
            this.label18.Text = "G : 자기계발 H : 여행";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(50, 212);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "E : 에세이 F : 역사";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(49, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "C : 대학교제 D : 소설/시  ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(50, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(196, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "A : 건강취미 B : 경제경영 ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(50, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "100단위로 넘어가야 한다.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(23, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "1. B_ID";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(26, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 34);
            this.panel5.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(63, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 32);
            this.label13.TabIndex = 11;
            this.label13.Text = "추가 조건";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(786, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 438);
            this.panel2.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.Location = new System.Drawing.Point(158, 375);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 43);
            this.button11.TabIndex = 17;
            this.button11.Text = "삭제";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.BookDeleteBtn_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.Location = new System.Drawing.Point(84, 375);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(71, 43);
            this.button10.TabIndex = 16;
            this.button10.Text = "수정";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "(상,중,하)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(19, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "상품상태";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(23, 235);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(192, 21);
            this.textBox9.TabIndex = 13;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(6, 375);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 43);
            this.button9.TabIndex = 12;
            this.button9.Text = "추가";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(17, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 37);
            this.panel3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(49, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "상품추가";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(19, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "PRICE";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(22, 330);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(192, 21);
            this.textBox8.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(19, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "CLASS_ID";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(23, 282);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(192, 21);
            this.textBox7.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(18, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "출판사";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(22, 190);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(192, 21);
            this.textBox6.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(18, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "B_ID";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(22, 139);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(192, 21);
            this.textBox5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(18, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "BOOKNAME";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(22, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(192, 21);
            this.textBox4.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKNAMEDataGridViewTextBoxColumn1,
            this.bIDDataGridViewTextBoxColumn1,
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1,
            this.bLEVELDataGridViewTextBoxColumn1,
            this.cLASSIDDataGridViewTextBoxColumn1,
            this.대여가능DataGridViewTextBoxColumn1,
            this.pRICEDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.bOOKBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(22, 22);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(465, 438);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            this.dataGridView4.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Edit_Event);
            // 
            // bOOKNAMEDataGridViewTextBoxColumn1
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn1.DataPropertyName = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn1.HeaderText = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn1.Name = "bOOKNAMEDataGridViewTextBoxColumn1";
            // 
            // bIDDataGridViewTextBoxColumn1
            // 
            this.bIDDataGridViewTextBoxColumn1.DataPropertyName = "B_ID";
            this.bIDDataGridViewTextBoxColumn1.HeaderText = "B_ID";
            this.bIDDataGridViewTextBoxColumn1.Name = "bIDDataGridViewTextBoxColumn1";
            // 
            // pUBLISHINGHOUSEDataGridViewTextBoxColumn1
            // 
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1.DataPropertyName = "PUBLISHINGHOUSE";
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1.HeaderText = "PUBLISHINGHOUSE";
            this.pUBLISHINGHOUSEDataGridViewTextBoxColumn1.Name = "pUBLISHINGHOUSEDataGridViewTextBoxColumn1";
            // 
            // bLEVELDataGridViewTextBoxColumn1
            // 
            this.bLEVELDataGridViewTextBoxColumn1.DataPropertyName = "BLEVEL";
            this.bLEVELDataGridViewTextBoxColumn1.HeaderText = "BLEVEL";
            this.bLEVELDataGridViewTextBoxColumn1.Name = "bLEVELDataGridViewTextBoxColumn1";
            // 
            // cLASSIDDataGridViewTextBoxColumn1
            // 
            this.cLASSIDDataGridViewTextBoxColumn1.DataPropertyName = "CLASS_ID";
            this.cLASSIDDataGridViewTextBoxColumn1.HeaderText = "CLASS_ID";
            this.cLASSIDDataGridViewTextBoxColumn1.Name = "cLASSIDDataGridViewTextBoxColumn1";
            // 
            // 대여가능DataGridViewTextBoxColumn1
            // 
            this.대여가능DataGridViewTextBoxColumn1.DataPropertyName = "대여가능";
            this.대여가능DataGridViewTextBoxColumn1.HeaderText = "대여가능";
            this.대여가능DataGridViewTextBoxColumn1.Name = "대여가능DataGridViewTextBoxColumn1";
            // 
            // pRICEDataGridViewTextBoxColumn1
            // 
            this.pRICEDataGridViewTextBoxColumn1.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn1.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn1.Name = "pRICEDataGridViewTextBoxColumn1";
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.dataSet11;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabControl2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1046, 476);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "상품통계";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(51, 22);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(938, 419);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chart1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(930, 393);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "대여통계";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "B_ID";
            chartArea1.AxisY.Title = "회원수";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.bIDCOUNCIDBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(163, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "B_ID";
            series1.YValueMembers = "COUNTCID";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(599, 384);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // bIDCOUNCIDBindingSource
            // 
            this.bIDCOUNCIDBindingSource.DataMember = "BID_COUN_CID";
            this.bIDCOUNCIDBindingSource.DataSource = this.dataSet11;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.chart2);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(930, 393);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "상품별 매출현황";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.AxisX.Title = "B_ID";
            chartArea2.AxisY.Title = "매출총액";
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.mONTHSUMPRICEBindingSource;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(170, 3);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "B_ID";
            series2.YValueMembers = "CNTPRICE";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(596, 387);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // mONTHSUMPRICEBindingSource
            // 
            this.mONTHSUMPRICEBindingSource.DataMember = "MONTH_SUM_PRICE";
            this.mONTHSUMPRICEBindingSource.DataSource = this.dataSet11;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.chart3);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(930, 393);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "월별 매출현황";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea3.AxisX.Title = "월";
            chartArea3.AxisY.Title = "총매출액";
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.DataSource = this.pRICEMONTHBindingSource;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(172, 3);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XValueMember = "MONTH";
            series3.YValueMembers = "PRICESUM";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(605, 390);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // pRICEMONTHBindingSource
            // 
            this.pRICEMONTHBindingSource.DataMember = "PRICE_MONTH";
            this.pRICEMONTHBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Connection = this.oracleConnection1;
            oracleParameter1.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Int16;
            oracleParameter1.ParameterName = "fee";
            oracleParameter2.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter2.ParameterName = "id";
            this.oracleCommand2.Parameters.Add(oracleParameter1);
            this.oracleCommand2.Parameters.Add(oracleParameter2);
            this.oracleCommand2.Transaction = null;
            // 
            // oracleCommand3
            // 
            this.oracleCommand3.Connection = this.oracleConnection1;
            this.oracleCommand3.Transaction = null;
            // 
            // oracleCommand4
            // 
            this.oracleCommand4.Connection = this.oracleConnection1;
            this.oracleCommand4.Transaction = null;
            // 
            // oracleCommand5
            // 
            this.oracleCommand5.Connection = this.oracleConnection1;
            oracleParameter3.OracleDbType = Oracle.DataAccess.Client.OracleDbType.Varchar2;
            oracleParameter3.ParameterName = "b_id";
            this.oracleCommand5.Parameters.Add(oracleParameter3);
            this.oracleCommand5.Transaction = null;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // customerinfoTableAdapter1
            // 
            this.customerinfoTableAdapter1.ClearBeforeFill = true;
            // 
            // rentalTableAdapter1
            // 
            this.rentalTableAdapter1.ClearBeforeFill = true;
            // 
            // hISTORYBindingSource
            // 
            this.hISTORYBindingSource.DataMember = "HISTORY";
            this.hISTORYBindingSource.DataSource = this.dataSet11;
            // 
            // cUSTOMERINFOBindingSource1
            // 
            this.cUSTOMERINFOBindingSource1.DataMember = "CUSTOMERINFO";
            this.cUSTOMERINFOBindingSource1.DataSource = this.dataSet11;
            // 
            // bLACKLISTTableAdapter
            // 
            this.bLACKLISTTableAdapter.ClearBeforeFill = true;
            // 
            // historyTableAdapter1
            // 
            this.historyTableAdapter1.ClearBeforeFill = true;
            // 
            // reservationTableAdapter1
            // 
            this.reservationTableAdapter1.ClearBeforeFill = true;
            // 
            // bID_COUN_CIDTableAdapter
            // 
            this.bID_COUN_CIDTableAdapter.ClearBeforeFill = true;
            // 
            // mONTH_SUM_PRICETableAdapter
            // 
            this.mONTH_SUM_PRICETableAdapter.ClearBeforeFill = true;
            // 
            // pRICE_MONTHTableAdapter
            // 
            this.pRICE_MONTHTableAdapter.ClearBeforeFill = true;
            // 
            // oracleCommand6
            // 
            this.oracleCommand6.Connection = this.oracleConnection1;
            this.oracleCommand6.Transaction = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.직원정보수정ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem,
            this.마감ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemClick_Event);
            // 
            // 직원정보수정ToolStripMenuItem
            // 
            this.직원정보수정ToolStripMenuItem.Name = "직원정보수정ToolStripMenuItem";
            this.직원정보수정ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.직원정보수정ToolStripMenuItem.Text = "직원정보수정";
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            // 
            // 마감ToolStripMenuItem
            // 
            this.마감ToolStripMenuItem.Name = "마감ToolStripMenuItem";
            this.마감ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.마감ToolStripMenuItem.Text = "마감";
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageForm";
            this.Text = "ManageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageForm_FormClosing);
            this.Load += new System.EventHandler(this.ManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERINFOBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLACKLISTBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIDCOUNCIDBindingSource)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTHSUMPRICEBindingSource)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRICEMONTHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERINFOBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1TableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHINGHOUSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLEVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대여가능DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bOOKBindingSource1;
        private DataSet1TableAdapters.CUSTOMERINFOTableAdapter customerinfoTableAdapter1;
        private Oracle.DataAccess.Client.OracleConnection oracleConnection1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand1;
        private DataSet1TableAdapters.RENTALTableAdapter rentalTableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource cUSTOMERINFOBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cUSTOMERINFOBindingSource1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource bLACKLISTBindingSource;
        private DataSet1TableAdapters.BLACKLISTTableAdapter bLACKLISTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPHONENUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLEVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLATEFEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pENALTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wARNINGNUMBERDataGridViewTextBoxColumn;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand2;
        private DataSet1TableAdapters.HISTORYTableAdapter historyTableAdapter1;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand3;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand4;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand5;
        private DataSet1TableAdapters.RESERVATIONTableAdapter reservationTableAdapter1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHINGHOUSEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLEVELDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대여가능DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource hISTORYBindingSource;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.BindingSource bIDCOUNCIDBindingSource;
        private DataSet1TableAdapters.BID_COUN_CIDTableAdapter bID_COUN_CIDTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource mONTHSUMPRICEBindingSource;
        private DataSet1TableAdapters.MONTH_SUM_PRICETableAdapter mONTH_SUM_PRICETableAdapter;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pRICEMONTHBindingSource;
        private DataSet1TableAdapters.PRICE_MONTHTableAdapter pRICE_MONTHTableAdapter;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private Oracle.DataAccess.Client.OracleCommand oracleCommand6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 직원정보수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 마감ToolStripMenuItem;
    }
}