namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.Label employee_NameLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label postCodeLabel;
            System.Windows.Forms.Label employerLabel;
            System.Windows.Forms.Label reference_NoLabel;
            System.Windows.Forms.Label innerCity_WeightingLabel;
            System.Windows.Forms.Label basic_SalaryLabel;
            System.Windows.Forms.Label overTimeLabel;
            System.Windows.Forms.Label paydateLabel;
            System.Windows.Forms.Label tax_PeriodLabel;
            System.Windows.Forms.Label tax_CodeLabel;
            System.Windows.Forms.Label nI_NumberLabel;
            System.Windows.Forms.Label nI_CodeLabel;
            System.Windows.Forms.Label taxable_PayLabel;
            System.Windows.Forms.Label pensionable_PayLabel;
            System.Windows.Forms.Label net_PayLabel;
            System.Windows.Forms.Label taxLabel;
            System.Windows.Forms.Label pensionLabel;
            System.Windows.Forms.Label student_LoanLabel;
            System.Windows.Forms.Label nil_PaymentLabel;
            System.Windows.Forms.Label paymentsLabel;
            System.Windows.Forms.Label deductionsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reference_NoTextBox = new System.Windows.Forms.TextBox();
            this.daftarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollDataSet = new WindowsFormsApplication1.payrollDataSet();
            this.employerTextBox = new System.Windows.Forms.TextBox();
            this.employee_NameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.overTimeTextBox = new System.Windows.Forms.TextBox();
            this.basic_SalaryTextBox = new System.Windows.Forms.TextBox();
            this.innerCity_WeightingTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nil_PaymentTextBox = new System.Windows.Forms.TextBox();
            this.student_LoanTextBox = new System.Windows.Forms.TextBox();
            this.pensionTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deductionsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.paymentsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.paydateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.nI_CodeTextBox = new System.Windows.Forms.TextBox();
            this.nI_NumberTextBox = new System.Windows.Forms.TextBox();
            this.tax_CodeTextBox = new System.Windows.Forms.TextBox();
            this.tax_PeriodTextBox = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pensionable_PayTextBox = new System.Windows.Forms.TextBox();
            this.taxable_PayTextBox = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.net_PayTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.daftarTableAdapter = new WindowsFormsApplication1.payrollDataSetTableAdapters.daftarTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.payrollDataSetTableAdapters.TableAdapterManager();
            this.daftarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.daftarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.postCodeTextBox = new System.Windows.Forms.TextBox();
            this.daftarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            employee_NameLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            postCodeLabel = new System.Windows.Forms.Label();
            employerLabel = new System.Windows.Forms.Label();
            reference_NoLabel = new System.Windows.Forms.Label();
            innerCity_WeightingLabel = new System.Windows.Forms.Label();
            basic_SalaryLabel = new System.Windows.Forms.Label();
            overTimeLabel = new System.Windows.Forms.Label();
            paydateLabel = new System.Windows.Forms.Label();
            tax_PeriodLabel = new System.Windows.Forms.Label();
            tax_CodeLabel = new System.Windows.Forms.Label();
            nI_NumberLabel = new System.Windows.Forms.Label();
            nI_CodeLabel = new System.Windows.Forms.Label();
            taxable_PayLabel = new System.Windows.Forms.Label();
            pensionable_PayLabel = new System.Windows.Forms.Label();
            net_PayLabel = new System.Windows.Forms.Label();
            taxLabel = new System.Windows.Forms.Label();
            pensionLabel = new System.Windows.Forms.Label();
            student_LoanLabel = new System.Windows.Forms.Label();
            nil_PaymentLabel = new System.Windows.Forms.Label();
            paymentsLabel = new System.Windows.Forms.Label();
            deductionsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingNavigator)).BeginInit();
            this.daftarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daftarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_NameLabel
            // 
            employee_NameLabel.AutoSize = true;
            employee_NameLabel.Location = new System.Drawing.Point(21, 44);
            employee_NameLabel.Name = "employee_NameLabel";
            employee_NameLabel.Size = new System.Drawing.Size(87, 13);
            employee_NameLabel.TabIndex = 0;
            employee_NameLabel.Text = "Employee Name:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(18, 64);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(54, 13);
            address1Label.TabIndex = 12;
            address1Label.Text = "Address1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(18, 89);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(54, 13);
            address2Label.TabIndex = 14;
            address2Label.Text = "Address2:";
            // 
            // postCodeLabel
            // 
            postCodeLabel.AutoSize = true;
            postCodeLabel.Location = new System.Drawing.Point(14, 116);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(59, 13);
            postCodeLabel.TabIndex = 16;
            postCodeLabel.Text = "Post Code:";
            // 
            // employerLabel
            // 
            employerLabel.AutoSize = true;
            employerLabel.Location = new System.Drawing.Point(55, 72);
            employerLabel.Name = "employerLabel";
            employerLabel.Size = new System.Drawing.Size(53, 13);
            employerLabel.TabIndex = 2;
            employerLabel.Text = "Employer:";
            // 
            // reference_NoLabel
            // 
            reference_NoLabel.AutoSize = true;
            reference_NoLabel.Location = new System.Drawing.Point(31, 101);
            reference_NoLabel.Name = "reference_NoLabel";
            reference_NoLabel.Size = new System.Drawing.Size(77, 13);
            reference_NoLabel.TabIndex = 4;
            reference_NoLabel.Text = "Reference No:";
            // 
            // innerCity_WeightingLabel
            // 
            innerCity_WeightingLabel.AutoSize = true;
            innerCity_WeightingLabel.Location = new System.Drawing.Point(6, 29);
            innerCity_WeightingLabel.Name = "innerCity_WeightingLabel";
            innerCity_WeightingLabel.Size = new System.Drawing.Size(105, 13);
            innerCity_WeightingLabel.TabIndex = 0;
            innerCity_WeightingLabel.Text = "Inner City Weighting:";
            // 
            // basic_SalaryLabel
            // 
            basic_SalaryLabel.AutoSize = true;
            basic_SalaryLabel.Location = new System.Drawing.Point(43, 60);
            basic_SalaryLabel.Name = "basic_SalaryLabel";
            basic_SalaryLabel.Size = new System.Drawing.Size(68, 13);
            basic_SalaryLabel.TabIndex = 2;
            basic_SalaryLabel.Text = "Basic Salary:";
            // 
            // overTimeLabel
            // 
            overTimeLabel.AutoSize = true;
            overTimeLabel.Location = new System.Drawing.Point(52, 90);
            overTimeLabel.Name = "overTimeLabel";
            overTimeLabel.Size = new System.Drawing.Size(59, 13);
            overTimeLabel.TabIndex = 4;
            overTimeLabel.Text = "Over Time:";
            // 
            // paydateLabel
            // 
            paydateLabel.AutoSize = true;
            paydateLabel.Location = new System.Drawing.Point(6, 22);
            paydateLabel.Name = "paydateLabel";
            paydateLabel.Size = new System.Drawing.Size(49, 13);
            paydateLabel.TabIndex = 0;
            paydateLabel.Text = "Paydate:";
            // 
            // tax_PeriodLabel
            // 
            tax_PeriodLabel.AutoSize = true;
            tax_PeriodLabel.Location = new System.Drawing.Point(6, 29);
            tax_PeriodLabel.Name = "tax_PeriodLabel";
            tax_PeriodLabel.Size = new System.Drawing.Size(61, 13);
            tax_PeriodLabel.TabIndex = 0;
            tax_PeriodLabel.Text = "Tax Period:";
            // 
            // tax_CodeLabel
            // 
            tax_CodeLabel.AutoSize = true;
            tax_CodeLabel.Location = new System.Drawing.Point(11, 52);
            tax_CodeLabel.Name = "tax_CodeLabel";
            tax_CodeLabel.Size = new System.Drawing.Size(56, 13);
            tax_CodeLabel.TabIndex = 2;
            tax_CodeLabel.Text = "Tax Code:";
            // 
            // nI_NumberLabel
            // 
            nI_NumberLabel.AutoSize = true;
            nI_NumberLabel.Location = new System.Drawing.Point(6, 75);
            nI_NumberLabel.Name = "nI_NumberLabel";
            nI_NumberLabel.Size = new System.Drawing.Size(61, 13);
            nI_NumberLabel.TabIndex = 4;
            nI_NumberLabel.Text = "NI Number:";
            // 
            // nI_CodeLabel
            // 
            nI_CodeLabel.AutoSize = true;
            nI_CodeLabel.Location = new System.Drawing.Point(18, 103);
            nI_CodeLabel.Name = "nI_CodeLabel";
            nI_CodeLabel.Size = new System.Drawing.Size(49, 13);
            nI_CodeLabel.TabIndex = 6;
            nI_CodeLabel.Text = "NI Code:";
            // 
            // taxable_PayLabel
            // 
            taxable_PayLabel.AutoSize = true;
            taxable_PayLabel.Location = new System.Drawing.Point(30, 25);
            taxable_PayLabel.Name = "taxable_PayLabel";
            taxable_PayLabel.Size = new System.Drawing.Size(65, 13);
            taxable_PayLabel.TabIndex = 0;
            taxable_PayLabel.Text = "taxable Pay:";
            // 
            // pensionable_PayLabel
            // 
            pensionable_PayLabel.AutoSize = true;
            pensionable_PayLabel.Location = new System.Drawing.Point(6, 55);
            pensionable_PayLabel.Name = "pensionable_PayLabel";
            pensionable_PayLabel.Size = new System.Drawing.Size(89, 13);
            pensionable_PayLabel.TabIndex = 2;
            pensionable_PayLabel.Text = "Pensionable Pay:";
            // 
            // net_PayLabel
            // 
            net_PayLabel.AutoSize = true;
            net_PayLabel.Location = new System.Drawing.Point(47, 31);
            net_PayLabel.Name = "net_PayLabel";
            net_PayLabel.Size = new System.Drawing.Size(48, 13);
            net_PayLabel.TabIndex = 0;
            net_PayLabel.Text = "Net Pay:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Location = new System.Drawing.Point(53, 42);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new System.Drawing.Size(28, 13);
            taxLabel.TabIndex = 0;
            taxLabel.Text = "Tax:";
            // 
            // pensionLabel
            // 
            pensionLabel.AutoSize = true;
            pensionLabel.Location = new System.Drawing.Point(33, 66);
            pensionLabel.Name = "pensionLabel";
            pensionLabel.Size = new System.Drawing.Size(48, 13);
            pensionLabel.TabIndex = 2;
            pensionLabel.Text = "Pension:";
            // 
            // student_LoanLabel
            // 
            student_LoanLabel.AutoSize = true;
            student_LoanLabel.Location = new System.Drawing.Point(7, 94);
            student_LoanLabel.Name = "student_LoanLabel";
            student_LoanLabel.Size = new System.Drawing.Size(74, 13);
            student_LoanLabel.TabIndex = 4;
            student_LoanLabel.Text = "Student Loan:";
            // 
            // nil_PaymentLabel
            // 
            nil_PaymentLabel.AutoSize = true;
            nil_PaymentLabel.Location = new System.Drawing.Point(15, 119);
            nil_PaymentLabel.Name = "nil_PaymentLabel";
            nil_PaymentLabel.Size = new System.Drawing.Size(66, 13);
            nil_PaymentLabel.TabIndex = 6;
            nil_PaymentLabel.Text = "Nil Payment:";
            // 
            // paymentsLabel
            // 
            paymentsLabel.AutoSize = true;
            paymentsLabel.Location = new System.Drawing.Point(22, 24);
            paymentsLabel.Name = "paymentsLabel";
            paymentsLabel.Size = new System.Drawing.Size(56, 13);
            paymentsLabel.TabIndex = 0;
            paymentsLabel.Text = "Payments:";
            // 
            // deductionsLabel
            // 
            deductionsLabel.AutoSize = true;
            deductionsLabel.Location = new System.Drawing.Point(24, 29);
            deductionsLabel.Name = "deductionsLabel";
            deductionsLabel.Size = new System.Drawing.Size(64, 13);
            deductionsLabel.TabIndex = 0;
            deductionsLabel.Text = "Deductions:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(reference_NoLabel);
            this.groupBox1.Controls.Add(this.reference_NoTextBox);
            this.groupBox1.Controls.Add(employerLabel);
            this.groupBox1.Controls.Add(this.employerTextBox);
            this.groupBox1.Controls.Add(employee_NameLabel);
            this.groupBox1.Controls.Add(this.employee_NameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // reference_NoTextBox
            // 
            this.reference_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Reference No", true));
            this.reference_NoTextBox.Location = new System.Drawing.Point(114, 98);
            this.reference_NoTextBox.Name = "reference_NoTextBox";
            this.reference_NoTextBox.Size = new System.Drawing.Size(188, 20);
            this.reference_NoTextBox.TabIndex = 5;
            // 
            // daftarBindingSource
            // 
            this.daftarBindingSource.DataMember = "daftar";
            this.daftarBindingSource.DataSource = this.payrollDataSet;
            // 
            // payrollDataSet
            // 
            this.payrollDataSet.DataSetName = "payrollDataSet";
            this.payrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employerTextBox
            // 
            this.employerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Employer", true));
            this.employerTextBox.Location = new System.Drawing.Point(114, 69);
            this.employerTextBox.Name = "employerTextBox";
            this.employerTextBox.Size = new System.Drawing.Size(188, 20);
            this.employerTextBox.TabIndex = 3;
            // 
            // employee_NameTextBox
            // 
            this.employee_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Employee Name", true));
            this.employee_NameTextBox.Location = new System.Drawing.Point(114, 41);
            this.employee_NameTextBox.Name = "employee_NameTextBox";
            this.employee_NameTextBox.Size = new System.Drawing.Size(188, 20);
            this.employee_NameTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(overTimeLabel);
            this.groupBox2.Controls.Add(this.overTimeTextBox);
            this.groupBox2.Controls.Add(basic_SalaryLabel);
            this.groupBox2.Controls.Add(this.basic_SalaryTextBox);
            this.groupBox2.Controls.Add(innerCity_WeightingLabel);
            this.groupBox2.Controls.Add(this.innerCity_WeightingTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // overTimeTextBox
            // 
            this.overTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "OverTime", true));
            this.overTimeTextBox.Location = new System.Drawing.Point(117, 87);
            this.overTimeTextBox.Name = "overTimeTextBox";
            this.overTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.overTimeTextBox.TabIndex = 5;
            // 
            // basic_SalaryTextBox
            // 
            this.basic_SalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Basic Salary", true));
            this.basic_SalaryTextBox.Location = new System.Drawing.Point(117, 57);
            this.basic_SalaryTextBox.Name = "basic_SalaryTextBox";
            this.basic_SalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.basic_SalaryTextBox.TabIndex = 3;
            // 
            // innerCity_WeightingTextBox
            // 
            this.innerCity_WeightingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "InnerCity Weighting", true));
            this.innerCity_WeightingTextBox.Location = new System.Drawing.Point(117, 26);
            this.innerCity_WeightingTextBox.Name = "innerCity_WeightingTextBox";
            this.innerCity_WeightingTextBox.Size = new System.Drawing.Size(100, 20);
            this.innerCity_WeightingTextBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(nil_PaymentLabel);
            this.groupBox3.Controls.Add(this.nil_PaymentTextBox);
            this.groupBox3.Controls.Add(student_LoanLabel);
            this.groupBox3.Controls.Add(this.student_LoanTextBox);
            this.groupBox3.Controls.Add(pensionLabel);
            this.groupBox3.Controls.Add(this.pensionTextBox);
            this.groupBox3.Controls.Add(taxLabel);
            this.groupBox3.Controls.Add(this.taxTextBox);
            this.groupBox3.Location = new System.Drawing.Point(251, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 203);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // nil_PaymentTextBox
            // 
            this.nil_PaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Nil Payment", true));
            this.nil_PaymentTextBox.Location = new System.Drawing.Point(87, 116);
            this.nil_PaymentTextBox.Name = "nil_PaymentTextBox";
            this.nil_PaymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.nil_PaymentTextBox.TabIndex = 7;
            // 
            // student_LoanTextBox
            // 
            this.student_LoanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Student Loan", true));
            this.student_LoanTextBox.Location = new System.Drawing.Point(87, 91);
            this.student_LoanTextBox.Name = "student_LoanTextBox";
            this.student_LoanTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_LoanTextBox.TabIndex = 5;
            // 
            // pensionTextBox
            // 
            this.pensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Pension", true));
            this.pensionTextBox.Location = new System.Drawing.Point(87, 63);
            this.pensionTextBox.Name = "pensionTextBox";
            this.pensionTextBox.Size = new System.Drawing.Size(100, 20);
            this.pensionTextBox.TabIndex = 3;
            // 
            // taxTextBox
            // 
            this.taxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Tax", true));
            this.taxTextBox.Location = new System.Drawing.Point(87, 39);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxTextBox.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(deductionsLabel);
            this.groupBox4.Controls.Add(this.deductionsTextBox);
            this.groupBox4.Location = new System.Drawing.Point(251, 542);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 66);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // deductionsTextBox
            // 
            this.deductionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Deductions", true));
            this.deductionsTextBox.Location = new System.Drawing.Point(94, 26);
            this.deductionsTextBox.Name = "deductionsTextBox";
            this.deductionsTextBox.Size = new System.Drawing.Size(100, 20);
            this.deductionsTextBox.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(paymentsLabel);
            this.groupBox5.Controls.Add(this.paymentsTextBox);
            this.groupBox5.Location = new System.Drawing.Point(12, 542);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 63);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // paymentsTextBox
            // 
            this.paymentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Payments", true));
            this.paymentsTextBox.Location = new System.Drawing.Point(84, 21);
            this.paymentsTextBox.Name = "paymentsTextBox";
            this.paymentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentsTextBox.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(paydateLabel);
            this.groupBox6.Controls.Add(this.paydateDateTimePicker);
            this.groupBox6.Location = new System.Drawing.Point(458, 161);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(275, 68);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // paydateDateTimePicker
            // 
            this.paydateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.daftarBindingSource, "Paydate", true));
            this.paydateDateTimePicker.Location = new System.Drawing.Point(61, 18);
            this.paydateDateTimePicker.Name = "paydateDateTimePicker";
            this.paydateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.paydateDateTimePicker.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(nI_CodeLabel);
            this.groupBox7.Controls.Add(this.nI_CodeTextBox);
            this.groupBox7.Controls.Add(nI_NumberLabel);
            this.groupBox7.Controls.Add(this.nI_NumberTextBox);
            this.groupBox7.Controls.Add(tax_CodeLabel);
            this.groupBox7.Controls.Add(this.tax_CodeTextBox);
            this.groupBox7.Controls.Add(tax_PeriodLabel);
            this.groupBox7.Controls.Add(this.tax_PeriodTextBox);
            this.groupBox7.Location = new System.Drawing.Point(458, 230);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(275, 187);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // nI_CodeTextBox
            // 
            this.nI_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "NI Code", true));
            this.nI_CodeTextBox.Location = new System.Drawing.Point(73, 100);
            this.nI_CodeTextBox.Name = "nI_CodeTextBox";
            this.nI_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nI_CodeTextBox.TabIndex = 7;
            // 
            // nI_NumberTextBox
            // 
            this.nI_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "NI Number", true));
            this.nI_NumberTextBox.Location = new System.Drawing.Point(73, 72);
            this.nI_NumberTextBox.Name = "nI_NumberTextBox";
            this.nI_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.nI_NumberTextBox.TabIndex = 5;
            // 
            // tax_CodeTextBox
            // 
            this.tax_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Tax Code", true));
            this.tax_CodeTextBox.Location = new System.Drawing.Point(73, 49);
            this.tax_CodeTextBox.Name = "tax_CodeTextBox";
            this.tax_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.tax_CodeTextBox.TabIndex = 3;
            // 
            // tax_PeriodTextBox
            // 
            this.tax_PeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Tax Period", true));
            this.tax_PeriodTextBox.Location = new System.Drawing.Point(73, 26);
            this.tax_PeriodTextBox.Name = "tax_PeriodTextBox";
            this.tax_PeriodTextBox.Size = new System.Drawing.Size(100, 20);
            this.tax_PeriodTextBox.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(pensionable_PayLabel);
            this.groupBox8.Controls.Add(this.pensionable_PayTextBox);
            this.groupBox8.Controls.Add(taxable_PayLabel);
            this.groupBox8.Controls.Add(this.taxable_PayTextBox);
            this.groupBox8.Location = new System.Drawing.Point(458, 423);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(275, 113);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
            // 
            // pensionable_PayTextBox
            // 
            this.pensionable_PayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Pensionable Pay", true));
            this.pensionable_PayTextBox.Location = new System.Drawing.Point(101, 52);
            this.pensionable_PayTextBox.Name = "pensionable_PayTextBox";
            this.pensionable_PayTextBox.Size = new System.Drawing.Size(100, 20);
            this.pensionable_PayTextBox.TabIndex = 3;
            // 
            // taxable_PayTextBox
            // 
            this.taxable_PayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "taxable Pay", true));
            this.taxable_PayTextBox.Location = new System.Drawing.Point(101, 22);
            this.taxable_PayTextBox.Name = "taxable_PayTextBox";
            this.taxable_PayTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxable_PayTextBox.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(net_PayLabel);
            this.groupBox9.Controls.Add(this.net_PayTextBox);
            this.groupBox9.Location = new System.Drawing.Point(458, 542);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(275, 63);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            // 
            // net_PayTextBox
            // 
            this.net_PayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Net Pay", true));
            this.net_PayTextBox.Location = new System.Drawing.Point(101, 28);
            this.net_PayTextBox.Name = "net_PayTextBox";
            this.net_PayTextBox.Size = new System.Drawing.Size(100, 20);
            this.net_PayTextBox.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(739, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 572);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button8);
            this.groupBox10.Controls.Add(this.button7);
            this.groupBox10.Controls.Add(this.button6);
            this.groupBox10.Controls.Add(this.button5);
            this.groupBox10.Controls.Add(this.button4);
            this.groupBox10.Controls.Add(this.button3);
            this.groupBox10.Controls.Add(this.button2);
            this.groupBox10.Controls.Add(this.button1);
            this.groupBox10.Location = new System.Drawing.Point(14, 611);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(719, 122);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "groupBox10";
            // 
            // daftarTableAdapter
            // 
            this.daftarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.daftarTableAdapter = this.daftarTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.payrollDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // daftarBindingNavigator
            // 
            this.daftarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.daftarBindingNavigator.BindingSource = this.daftarBindingSource;
            this.daftarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.daftarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.daftarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.daftarBindingNavigatorSaveItem});
            this.daftarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.daftarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.daftarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.daftarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.daftarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.daftarBindingNavigator.Name = "daftarBindingNavigator";
            this.daftarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.daftarBindingNavigator.Size = new System.Drawing.Size(1179, 25);
            this.daftarBindingNavigator.TabIndex = 8;
            this.daftarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // daftarBindingNavigatorSaveItem
            // 
            this.daftarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.daftarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("daftarBindingNavigatorSaveItem.Image")));
            this.daftarBindingNavigatorSaveItem.Name = "daftarBindingNavigatorSaveItem";
            this.daftarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.daftarBindingNavigatorSaveItem.Text = "Save Data";
            this.daftarBindingNavigatorSaveItem.Click += new System.EventHandler(this.daftarBindingNavigatorSaveItem_Click);
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(78, 61);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(100, 20);
            this.address1TextBox.TabIndex = 13;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "Address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(78, 86);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(100, 20);
            this.address2TextBox.TabIndex = 15;
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource, "PostCode", true));
            this.postCodeTextBox.Location = new System.Drawing.Point(79, 113);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postCodeTextBox.TabIndex = 17;
            // 
            // daftarDataGridView
            // 
            this.daftarDataGridView.AutoGenerateColumns = false;
            this.daftarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daftarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.daftarDataGridView.DataSource = this.daftarBindingSource;
            this.daftarDataGridView.Location = new System.Drawing.Point(327, 32);
            this.daftarDataGridView.Name = "daftarDataGridView";
            this.daftarDataGridView.Size = new System.Drawing.Size(816, 123);
            this.daftarDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Employee Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Address1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Address1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address2";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PostCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "PostCode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TelNo";
            this.dataGridViewTextBoxColumn5.HeaderText = "TelNo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NI Number";
            this.dataGridViewTextBoxColumn6.HeaderText = "NI Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Paydate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Paydate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Employer";
            this.dataGridViewTextBoxColumn8.HeaderText = "Employer";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NI Code";
            this.dataGridViewTextBoxColumn9.HeaderText = "NI Code";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Tax Code";
            this.dataGridViewTextBoxColumn10.HeaderText = "Tax Code";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Tax Period";
            this.dataGridViewTextBoxColumn11.HeaderText = "Tax Period";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Reference No";
            this.dataGridViewTextBoxColumn12.HeaderText = "Reference No";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Basic Salary";
            this.dataGridViewTextBoxColumn13.HeaderText = "Basic Salary";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "OverTime";
            this.dataGridViewTextBoxColumn14.HeaderText = "OverTime";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "InnerCity Weighting";
            this.dataGridViewTextBoxColumn15.HeaderText = "InnerCity Weighting";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Student Loan";
            this.dataGridViewTextBoxColumn16.HeaderText = "Student Loan";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Pension";
            this.dataGridViewTextBoxColumn17.HeaderText = "Pension";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Tax";
            this.dataGridViewTextBoxColumn18.HeaderText = "Tax";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Pensionable Pay";
            this.dataGridViewTextBoxColumn19.HeaderText = "Pensionable Pay";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "taxable Pay";
            this.dataGridViewTextBoxColumn20.HeaderText = "taxable Pay";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Payments";
            this.dataGridViewTextBoxColumn21.HeaderText = "Payments";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Deductions";
            this.dataGridViewTextBoxColumn22.HeaderText = "Deductions";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Net Pay";
            this.dataGridViewTextBoxColumn23.HeaderText = "Net Pay";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Nil Payment";
            this.dataGridViewTextBoxColumn24.HeaderText = "Nil Payment";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "addNew";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(346, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(424, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Slip";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(505, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(586, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 72);
            this.button8.TabIndex = 7;
            this.button8.Text = "Hitung";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1179, 744);
            this.Controls.Add(this.daftarDataGridView);
            this.Controls.Add(postCodeLabel);
            this.Controls.Add(this.postCodeTextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.daftarBindingNavigator);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingNavigator)).EndInit();
            this.daftarBindingNavigator.ResumeLayout(false);
            this.daftarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daftarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox10;
        private payrollDataSet payrollDataSet;
        private System.Windows.Forms.BindingSource daftarBindingSource;
        private payrollDataSetTableAdapters.daftarTableAdapter daftarTableAdapter;
        private payrollDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator daftarBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton daftarBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox reference_NoTextBox;
        private System.Windows.Forms.TextBox employerTextBox;
        private System.Windows.Forms.TextBox employee_NameTextBox;
        private System.Windows.Forms.TextBox overTimeTextBox;
        private System.Windows.Forms.TextBox basic_SalaryTextBox;
        private System.Windows.Forms.TextBox innerCity_WeightingTextBox;
        private System.Windows.Forms.TextBox nil_PaymentTextBox;
        private System.Windows.Forms.TextBox student_LoanTextBox;
        private System.Windows.Forms.TextBox pensionTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox deductionsTextBox;
        private System.Windows.Forms.TextBox paymentsTextBox;
        private System.Windows.Forms.DateTimePicker paydateDateTimePicker;
        private System.Windows.Forms.TextBox nI_CodeTextBox;
        private System.Windows.Forms.TextBox nI_NumberTextBox;
        private System.Windows.Forms.TextBox tax_CodeTextBox;
        private System.Windows.Forms.TextBox tax_PeriodTextBox;
        private System.Windows.Forms.TextBox pensionable_PayTextBox;
        private System.Windows.Forms.TextBox taxable_PayTextBox;
        private System.Windows.Forms.TextBox net_PayTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox postCodeTextBox;
        private System.Windows.Forms.DataGridView daftarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

