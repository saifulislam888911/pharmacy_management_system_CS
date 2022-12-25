namespace CS_Pharmacy_Management_Systems
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label invoice_NoLabel;
            System.Windows.Forms.Label amount_PaidLabel;
            System.Windows.Forms.Label method_of_PaymentLabel;
            System.Windows.Forms.Label visa_CardLabel;
            System.Windows.Forms.Label debit_CardLabel;
            System.Windows.Forms.Label master_CardLabel;
            System.Windows.Forms.Label credit_CardLabel;
            System.Windows.Forms.Label driect_DebitLabel;
            System.Windows.Forms.Label visa_Debit_CardLabel;
            System.Windows.Forms.Label cash_PaidLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label per_Paid_PlanLabel;
            System.Windows.Forms.Label patient_NHS_NumberLabel;
            this.pharmacyDataSet = new CS_Pharmacy_Management_Systems.PharmacyDataSet();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.PaymentTableAdapter();
            this.tableAdapterManager = new CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.paymentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.paymentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoice_NoTextBox = new System.Windows.Forms.TextBox();
            this.amount_PaidTextBox = new System.Windows.Forms.TextBox();
            this.method_of_PaymentTextBox = new System.Windows.Forms.TextBox();
            this.visa_CardTextBox = new System.Windows.Forms.TextBox();
            this.debit_CardTextBox = new System.Windows.Forms.TextBox();
            this.master_CardTextBox = new System.Windows.Forms.TextBox();
            this.credit_CardTextBox = new System.Windows.Forms.TextBox();
            this.driect_DebitTextBox = new System.Windows.Forms.TextBox();
            this.visa_Debit_CardTextBox = new System.Windows.Forms.TextBox();
            this.cash_PaidTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.per_Paid_PlanCheckBox = new System.Windows.Forms.CheckBox();
            this.patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            invoice_NoLabel = new System.Windows.Forms.Label();
            amount_PaidLabel = new System.Windows.Forms.Label();
            method_of_PaymentLabel = new System.Windows.Forms.Label();
            visa_CardLabel = new System.Windows.Forms.Label();
            debit_CardLabel = new System.Windows.Forms.Label();
            master_CardLabel = new System.Windows.Forms.Label();
            credit_CardLabel = new System.Windows.Forms.Label();
            driect_DebitLabel = new System.Windows.Forms.Label();
            visa_Debit_CardLabel = new System.Windows.Forms.Label();
            cash_PaidLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            per_Paid_PlanLabel = new System.Windows.Forms.Label();
            patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingNavigator)).BeginInit();
            this.paymentBindingNavigator.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = this.paymentTableAdapter;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paymentBindingNavigator
            // 
            this.paymentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paymentBindingNavigator.BindingSource = this.paymentBindingSource;
            this.paymentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paymentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paymentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paymentBindingNavigatorSaveItem});
            this.paymentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paymentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paymentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paymentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paymentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paymentBindingNavigator.Name = "paymentBindingNavigator";
            this.paymentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paymentBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.paymentBindingNavigator.TabIndex = 0;
            this.paymentBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // paymentBindingNavigatorSaveItem
            // 
            this.paymentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paymentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentBindingNavigatorSaveItem.Image")));
            this.paymentBindingNavigatorSaveItem.Name = "paymentBindingNavigatorSaveItem";
            this.paymentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.paymentBindingNavigatorSaveItem.Text = "Save Data";
            this.paymentBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentBindingNavigatorSaveItem_Click);
            // 
            // invoice_NoLabel
            // 
            invoice_NoLabel.AutoSize = true;
            invoice_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoice_NoLabel.Location = new System.Drawing.Point(18, 151);
            invoice_NoLabel.Name = "invoice_NoLabel";
            invoice_NoLabel.Size = new System.Drawing.Size(89, 16);
            invoice_NoLabel.TabIndex = 1;
            invoice_NoLabel.Text = "Invoice No:";
            // 
            // invoice_NoTextBox
            // 
            this.invoice_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Invoice No", true));
            this.invoice_NoTextBox.Location = new System.Drawing.Point(210, 148);
            this.invoice_NoTextBox.Name = "invoice_NoTextBox";
            this.invoice_NoTextBox.Size = new System.Drawing.Size(160, 20);
            this.invoice_NoTextBox.TabIndex = 2;
            // 
            // amount_PaidLabel
            // 
            amount_PaidLabel.AutoSize = true;
            amount_PaidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            amount_PaidLabel.Location = new System.Drawing.Point(18, 177);
            amount_PaidLabel.Name = "amount_PaidLabel";
            amount_PaidLabel.Size = new System.Drawing.Size(102, 16);
            amount_PaidLabel.TabIndex = 3;
            amount_PaidLabel.Text = "Amount Paid:";
            // 
            // amount_PaidTextBox
            // 
            this.amount_PaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Amount Paid", true));
            this.amount_PaidTextBox.Location = new System.Drawing.Point(210, 174);
            this.amount_PaidTextBox.Name = "amount_PaidTextBox";
            this.amount_PaidTextBox.Size = new System.Drawing.Size(160, 20);
            this.amount_PaidTextBox.TabIndex = 4;
            // 
            // method_of_PaymentLabel
            // 
            method_of_PaymentLabel.AutoSize = true;
            method_of_PaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            method_of_PaymentLabel.Location = new System.Drawing.Point(18, 203);
            method_of_PaymentLabel.Name = "method_of_PaymentLabel";
            method_of_PaymentLabel.Size = new System.Drawing.Size(148, 16);
            method_of_PaymentLabel.TabIndex = 5;
            method_of_PaymentLabel.Text = "Method of Payment:";
            // 
            // method_of_PaymentTextBox
            // 
            this.method_of_PaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Method of Payment", true));
            this.method_of_PaymentTextBox.Location = new System.Drawing.Point(210, 200);
            this.method_of_PaymentTextBox.Name = "method_of_PaymentTextBox";
            this.method_of_PaymentTextBox.Size = new System.Drawing.Size(160, 20);
            this.method_of_PaymentTextBox.TabIndex = 6;
            // 
            // visa_CardLabel
            // 
            visa_CardLabel.AutoSize = true;
            visa_CardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            visa_CardLabel.Location = new System.Drawing.Point(18, 229);
            visa_CardLabel.Name = "visa_CardLabel";
            visa_CardLabel.Size = new System.Drawing.Size(84, 16);
            visa_CardLabel.TabIndex = 7;
            visa_CardLabel.Text = "Visa Card:";
            // 
            // visa_CardTextBox
            // 
            this.visa_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Visa Card", true));
            this.visa_CardTextBox.Location = new System.Drawing.Point(210, 226);
            this.visa_CardTextBox.Name = "visa_CardTextBox";
            this.visa_CardTextBox.Size = new System.Drawing.Size(160, 20);
            this.visa_CardTextBox.TabIndex = 8;
            // 
            // debit_CardLabel
            // 
            debit_CardLabel.AutoSize = true;
            debit_CardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            debit_CardLabel.Location = new System.Drawing.Point(18, 255);
            debit_CardLabel.Name = "debit_CardLabel";
            debit_CardLabel.Size = new System.Drawing.Size(90, 16);
            debit_CardLabel.TabIndex = 9;
            debit_CardLabel.Text = "Debit Card:";
            // 
            // debit_CardTextBox
            // 
            this.debit_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Debit Card", true));
            this.debit_CardTextBox.Location = new System.Drawing.Point(210, 252);
            this.debit_CardTextBox.Name = "debit_CardTextBox";
            this.debit_CardTextBox.Size = new System.Drawing.Size(160, 20);
            this.debit_CardTextBox.TabIndex = 10;
            // 
            // master_CardLabel
            // 
            master_CardLabel.AutoSize = true;
            master_CardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            master_CardLabel.Location = new System.Drawing.Point(18, 281);
            master_CardLabel.Name = "master_CardLabel";
            master_CardLabel.Size = new System.Drawing.Size(100, 16);
            master_CardLabel.TabIndex = 11;
            master_CardLabel.Text = "Master Card:";
            // 
            // master_CardTextBox
            // 
            this.master_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Master Card", true));
            this.master_CardTextBox.Location = new System.Drawing.Point(210, 278);
            this.master_CardTextBox.Name = "master_CardTextBox";
            this.master_CardTextBox.Size = new System.Drawing.Size(160, 20);
            this.master_CardTextBox.TabIndex = 12;
            // 
            // credit_CardLabel
            // 
            credit_CardLabel.AutoSize = true;
            credit_CardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            credit_CardLabel.Location = new System.Drawing.Point(18, 307);
            credit_CardLabel.Name = "credit_CardLabel";
            credit_CardLabel.Size = new System.Drawing.Size(95, 16);
            credit_CardLabel.TabIndex = 13;
            credit_CardLabel.Text = "Credit Card:";
            // 
            // credit_CardTextBox
            // 
            this.credit_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Credit Card", true));
            this.credit_CardTextBox.Location = new System.Drawing.Point(210, 304);
            this.credit_CardTextBox.Name = "credit_CardTextBox";
            this.credit_CardTextBox.Size = new System.Drawing.Size(160, 20);
            this.credit_CardTextBox.TabIndex = 14;
            // 
            // driect_DebitLabel
            // 
            driect_DebitLabel.AutoSize = true;
            driect_DebitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            driect_DebitLabel.Location = new System.Drawing.Point(408, 150);
            driect_DebitLabel.Name = "driect_DebitLabel";
            driect_DebitLabel.Size = new System.Drawing.Size(97, 16);
            driect_DebitLabel.TabIndex = 15;
            driect_DebitLabel.Text = "Driect Debit:";
            // 
            // driect_DebitTextBox
            // 
            this.driect_DebitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Driect Debit", true));
            this.driect_DebitTextBox.Location = new System.Drawing.Point(600, 147);
            this.driect_DebitTextBox.Name = "driect_DebitTextBox";
            this.driect_DebitTextBox.Size = new System.Drawing.Size(160, 20);
            this.driect_DebitTextBox.TabIndex = 16;
            // 
            // visa_Debit_CardLabel
            // 
            visa_Debit_CardLabel.AutoSize = true;
            visa_Debit_CardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            visa_Debit_CardLabel.Location = new System.Drawing.Point(408, 176);
            visa_Debit_CardLabel.Name = "visa_Debit_CardLabel";
            visa_Debit_CardLabel.Size = new System.Drawing.Size(127, 16);
            visa_Debit_CardLabel.TabIndex = 17;
            visa_Debit_CardLabel.Text = "Visa Debit Card:";
            // 
            // visa_Debit_CardTextBox
            // 
            this.visa_Debit_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Visa Debit Card", true));
            this.visa_Debit_CardTextBox.Location = new System.Drawing.Point(600, 173);
            this.visa_Debit_CardTextBox.Name = "visa_Debit_CardTextBox";
            this.visa_Debit_CardTextBox.Size = new System.Drawing.Size(160, 20);
            this.visa_Debit_CardTextBox.TabIndex = 18;
            // 
            // cash_PaidLabel
            // 
            cash_PaidLabel.AutoSize = true;
            cash_PaidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cash_PaidLabel.Location = new System.Drawing.Point(408, 202);
            cash_PaidLabel.Name = "cash_PaidLabel";
            cash_PaidLabel.Size = new System.Drawing.Size(87, 16);
            cash_PaidLabel.TabIndex = 19;
            cash_PaidLabel.Text = "Cash Paid:";
            // 
            // cash_PaidTextBox
            // 
            this.cash_PaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Cash Paid", true));
            this.cash_PaidTextBox.Location = new System.Drawing.Point(600, 199);
            this.cash_PaidTextBox.Name = "cash_PaidTextBox";
            this.cash_PaidTextBox.Size = new System.Drawing.Size(160, 20);
            this.cash_PaidTextBox.TabIndex = 20;
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_IDLabel.Location = new System.Drawing.Point(408, 228);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(83, 16);
            patient_IDLabel.TabIndex = 21;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Location = new System.Drawing.Point(600, 225);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(160, 20);
            this.patient_IDTextBox.TabIndex = 22;
            // 
            // per_Paid_PlanLabel
            // 
            per_Paid_PlanLabel.AutoSize = true;
            per_Paid_PlanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            per_Paid_PlanLabel.Location = new System.Drawing.Point(408, 256);
            per_Paid_PlanLabel.Name = "per_Paid_PlanLabel";
            per_Paid_PlanLabel.Size = new System.Drawing.Size(112, 16);
            per_Paid_PlanLabel.TabIndex = 23;
            per_Paid_PlanLabel.Text = "Per Paid Plan:";
            // 
            // per_Paid_PlanCheckBox
            // 
            this.per_Paid_PlanCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.paymentBindingSource, "Per Paid Plan", true));
            this.per_Paid_PlanCheckBox.Location = new System.Drawing.Point(600, 251);
            this.per_Paid_PlanCheckBox.Name = "per_Paid_PlanCheckBox";
            this.per_Paid_PlanCheckBox.Size = new System.Drawing.Size(160, 24);
            this.per_Paid_PlanCheckBox.TabIndex = 24;
            this.per_Paid_PlanCheckBox.Text = "checkBox1";
            this.per_Paid_PlanCheckBox.UseVisualStyleBackColor = true;
            // 
            // patient_NHS_NumberLabel
            // 
            patient_NHS_NumberLabel.AutoSize = true;
            patient_NHS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_NHS_NumberLabel.Location = new System.Drawing.Point(408, 284);
            patient_NHS_NumberLabel.Name = "patient_NHS_NumberLabel";
            patient_NHS_NumberLabel.Size = new System.Drawing.Size(161, 16);
            patient_NHS_NumberLabel.TabIndex = 25;
            patient_NHS_NumberLabel.Text = "Patient NHS Number:";
            // 
            // patient_NHS_NumberTextBox
            // 
            this.patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Patient NHS Number", true));
            this.patient_NHS_NumberTextBox.Location = new System.Drawing.Point(600, 281);
            this.patient_NHS_NumberTextBox.Name = "patient_NHS_NumberTextBox";
            this.patient_NHS_NumberTextBox.Size = new System.Drawing.Size(160, 20);
            this.patient_NHS_NumberTextBox.TabIndex = 26;
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Title.Controls.Add(this.label1);
            this.panel_Title.Controls.Add(this.label_Title);
            this.panel_Title.Location = new System.Drawing.Point(12, 28);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(760, 77);
            this.panel_Title.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Title.Location = new System.Drawing.Point(3, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(245, 18);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Pharmacy Management System";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_Previous);
            this.panel2.Controls.Add(this.btn_Next);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Location = new System.Drawing.Point(21, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 42);
            this.panel2.TabIndex = 42;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Close.Location = new System.Drawing.Point(592, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(83, 29);
            this.btn_Close.TabIndex = 18;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Green;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Save.Location = new System.Drawing.Point(503, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(83, 29);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Previous.Location = new System.Drawing.Point(414, 3);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(83, 29);
            this.btn_Previous.TabIndex = 18;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = false;
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Next.Location = new System.Drawing.Point(325, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(83, 29);
            this.btn_Next.TabIndex = 18;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Edit.Location = new System.Drawing.Point(236, 3);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(83, 29);
            this.btn_Edit.TabIndex = 18;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Delete.Location = new System.Drawing.Point(147, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(83, 29);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Add.Location = new System.Drawing.Point(58, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(83, 29);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.paymentDataGridView);
            this.panel1.Location = new System.Drawing.Point(16, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 309);
            this.panel1.TabIndex = 41;
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AutoGenerateColumns = false;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn12});
            this.paymentDataGridView.DataSource = this.paymentBindingSource;
            this.paymentDataGridView.Location = new System.Drawing.Point(3, 3);
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.Size = new System.Drawing.Size(742, 299);
            this.paymentDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Invoice No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Amount Paid";
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount Paid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Method of Payment";
            this.dataGridViewTextBoxColumn3.HeaderText = "Method of Payment";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Visa Card";
            this.dataGridViewTextBoxColumn4.HeaderText = "Visa Card";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Debit Card";
            this.dataGridViewTextBoxColumn5.HeaderText = "Debit Card";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Master Card";
            this.dataGridViewTextBoxColumn6.HeaderText = "Master Card";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Credit Card";
            this.dataGridViewTextBoxColumn7.HeaderText = "Credit Card";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Driect Debit";
            this.dataGridViewTextBoxColumn8.HeaderText = "Driect Debit";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Visa Debit Card";
            this.dataGridViewTextBoxColumn9.HeaderText = "Visa Debit Card";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Cash Paid";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cash Paid";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Patient ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Per Paid Plan";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Per Paid Plan";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Patient NHS Number";
            this.dataGridViewTextBoxColumn12.HeaderText = "Patient NHS Number";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(invoice_NoLabel);
            this.Controls.Add(this.invoice_NoTextBox);
            this.Controls.Add(amount_PaidLabel);
            this.Controls.Add(this.amount_PaidTextBox);
            this.Controls.Add(method_of_PaymentLabel);
            this.Controls.Add(this.method_of_PaymentTextBox);
            this.Controls.Add(visa_CardLabel);
            this.Controls.Add(this.visa_CardTextBox);
            this.Controls.Add(debit_CardLabel);
            this.Controls.Add(this.debit_CardTextBox);
            this.Controls.Add(master_CardLabel);
            this.Controls.Add(this.master_CardTextBox);
            this.Controls.Add(credit_CardLabel);
            this.Controls.Add(this.credit_CardTextBox);
            this.Controls.Add(driect_DebitLabel);
            this.Controls.Add(this.driect_DebitTextBox);
            this.Controls.Add(visa_Debit_CardLabel);
            this.Controls.Add(this.visa_Debit_CardTextBox);
            this.Controls.Add(cash_PaidLabel);
            this.Controls.Add(this.cash_PaidTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(per_Paid_PlanLabel);
            this.Controls.Add(this.per_Paid_PlanCheckBox);
            this.Controls.Add(patient_NHS_NumberLabel);
            this.Controls.Add(this.patient_NHS_NumberTextBox);
            this.Controls.Add(this.paymentBindingNavigator);
            this.Name = "Form5";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingNavigator)).EndInit();
            this.paymentBindingNavigator.ResumeLayout(false);
            this.paymentBindingNavigator.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private PharmacyDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paymentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton paymentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox invoice_NoTextBox;
        private System.Windows.Forms.TextBox amount_PaidTextBox;
        private System.Windows.Forms.TextBox method_of_PaymentTextBox;
        private System.Windows.Forms.TextBox visa_CardTextBox;
        private System.Windows.Forms.TextBox debit_CardTextBox;
        private System.Windows.Forms.TextBox master_CardTextBox;
        private System.Windows.Forms.TextBox credit_CardTextBox;
        private System.Windows.Forms.TextBox driect_DebitTextBox;
        private System.Windows.Forms.TextBox visa_Debit_CardTextBox;
        private System.Windows.Forms.TextBox cash_PaidTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.CheckBox per_Paid_PlanCheckBox;
        private System.Windows.Forms.TextBox patient_NHS_NumberTextBox;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView paymentDataGridView;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}