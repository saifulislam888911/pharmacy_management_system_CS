namespace CS_Pharmacy_Management_Systems
{
    partial class Form7
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
            System.Windows.Forms.Label reference_NumberLabel;
            System.Windows.Forms.Label patient__IDLabel;
            System.Windows.Forms.Label doctor_s_NHS_NoLabel;
            System.Windows.Forms.Label medical_Centre_NameLabel;
            System.Windows.Forms.Label eMIS_NumberLabel;
            System.Windows.Forms.Label doctor_GP_Appointment_RefLabel;
            System.Windows.Forms.Label doctor_Patient_NHS_NumberLabel;
            System.Windows.Forms.Label gP_Appointment_GP_Appointment_RefLabel;
            System.Windows.Forms.Label gP_Appointment_Patient_NHS_NumberLabel;
            System.Windows.Forms.Label invoice_NoLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label billing_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label post_CodeLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.pharmacyDataSet = new CS_Pharmacy_Management_Systems.PharmacyDataSet();
            this.pharmacy_OfficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacy_OfficeTableAdapter = new CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.Pharmacy_OfficeTableAdapter();
            this.tableAdapterManager = new CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.pharmacy_OfficeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pharmacy_OfficeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reference_NumberTextBox = new System.Windows.Forms.TextBox();
            this.patient__IDTextBox = new System.Windows.Forms.TextBox();
            this.doctor_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.medical_Centre_NameTextBox = new System.Windows.Forms.TextBox();
            this.eMIS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.doctor_GP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.doctor_Patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_GP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_Patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.invoice_NoTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthTextBox = new System.Windows.Forms.TextBox();
            this.billing_NameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.post_CodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
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
            this.pharmacyDataGridView = new System.Windows.Forms.DataGridView();
            this.referenceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsNHSNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalCentreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMISNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorGPAppointmentRefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPatientNHSNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPAppointmentGPAppointmentRefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPAppointmentPatientNHSNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            reference_NumberLabel = new System.Windows.Forms.Label();
            patient__IDLabel = new System.Windows.Forms.Label();
            doctor_s_NHS_NoLabel = new System.Windows.Forms.Label();
            medical_Centre_NameLabel = new System.Windows.Forms.Label();
            eMIS_NumberLabel = new System.Windows.Forms.Label();
            doctor_GP_Appointment_RefLabel = new System.Windows.Forms.Label();
            doctor_Patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            gP_Appointment_GP_Appointment_RefLabel = new System.Windows.Forms.Label();
            gP_Appointment_Patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            invoice_NoLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            billing_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            post_CodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingNavigator)).BeginInit();
            this.pharmacy_OfficeBindingNavigator.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reference_NumberLabel
            // 
            reference_NumberLabel.AutoSize = true;
            reference_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reference_NumberLabel.Location = new System.Drawing.Point(16, 164);
            reference_NumberLabel.Name = "reference_NumberLabel";
            reference_NumberLabel.Size = new System.Drawing.Size(145, 16);
            reference_NumberLabel.TabIndex = 1;
            reference_NumberLabel.Text = "Reference Number:";
            // 
            // patient__IDLabel
            // 
            patient__IDLabel.AutoSize = true;
            patient__IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient__IDLabel.Location = new System.Drawing.Point(16, 190);
            patient__IDLabel.Name = "patient__IDLabel";
            patient__IDLabel.Size = new System.Drawing.Size(88, 16);
            patient__IDLabel.TabIndex = 3;
            patient__IDLabel.Text = "Patient  ID:";
            // 
            // doctor_s_NHS_NoLabel
            // 
            doctor_s_NHS_NoLabel.AutoSize = true;
            doctor_s_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_s_NHS_NoLabel.Location = new System.Drawing.Point(16, 216);
            doctor_s_NHS_NoLabel.Name = "doctor_s_NHS_NoLabel";
            doctor_s_NHS_NoLabel.Size = new System.Drawing.Size(137, 16);
            doctor_s_NHS_NoLabel.TabIndex = 5;
            doctor_s_NHS_NoLabel.Text = "Doctor\'s NHS No:";
            // 
            // medical_Centre_NameLabel
            // 
            medical_Centre_NameLabel.AutoSize = true;
            medical_Centre_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medical_Centre_NameLabel.Location = new System.Drawing.Point(16, 242);
            medical_Centre_NameLabel.Name = "medical_Centre_NameLabel";
            medical_Centre_NameLabel.Size = new System.Drawing.Size(167, 16);
            medical_Centre_NameLabel.TabIndex = 7;
            medical_Centre_NameLabel.Text = "Medical Centre Name:";
            // 
            // eMIS_NumberLabel
            // 
            eMIS_NumberLabel.AutoSize = true;
            eMIS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMIS_NumberLabel.Location = new System.Drawing.Point(16, 268);
            eMIS_NumberLabel.Name = "eMIS_NumberLabel";
            eMIS_NumberLabel.Size = new System.Drawing.Size(112, 16);
            eMIS_NumberLabel.TabIndex = 9;
            eMIS_NumberLabel.Text = "EMIS Number:";
            // 
            // doctor_GP_Appointment_RefLabel
            // 
            doctor_GP_Appointment_RefLabel.AutoSize = true;
            doctor_GP_Appointment_RefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_GP_Appointment_RefLabel.Location = new System.Drawing.Point(16, 294);
            doctor_GP_Appointment_RefLabel.Name = "doctor_GP_Appointment_RefLabel";
            doctor_GP_Appointment_RefLabel.Size = new System.Drawing.Size(209, 16);
            doctor_GP_Appointment_RefLabel.TabIndex = 11;
            doctor_GP_Appointment_RefLabel.Text = "Doctor GP Appointment Ref:";
            // 
            // doctor_Patient_NHS_NumberLabel
            // 
            doctor_Patient_NHS_NumberLabel.AutoSize = true;
            doctor_Patient_NHS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_Patient_NHS_NumberLabel.Location = new System.Drawing.Point(16, 320);
            doctor_Patient_NHS_NumberLabel.Name = "doctor_Patient_NHS_NumberLabel";
            doctor_Patient_NHS_NumberLabel.Size = new System.Drawing.Size(213, 16);
            doctor_Patient_NHS_NumberLabel.TabIndex = 13;
            doctor_Patient_NHS_NumberLabel.Text = "Doctor Patient NHS Number:";
            // 
            // gP_Appointment_GP_Appointment_RefLabel
            // 
            gP_Appointment_GP_Appointment_RefLabel.AutoSize = true;
            gP_Appointment_GP_Appointment_RefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_Appointment_GP_Appointment_RefLabel.Location = new System.Drawing.Point(16, 347);
            gP_Appointment_GP_Appointment_RefLabel.Name = "gP_Appointment_GP_Appointment_RefLabel";
            gP_Appointment_GP_Appointment_RefLabel.Size = new System.Drawing.Size(277, 16);
            gP_Appointment_GP_Appointment_RefLabel.TabIndex = 15;
            gP_Appointment_GP_Appointment_RefLabel.Text = "GP Appointment GP Appointment Ref:";
            // 
            // gP_Appointment_Patient_NHS_NumberLabel
            // 
            gP_Appointment_Patient_NHS_NumberLabel.AutoSize = true;
            gP_Appointment_Patient_NHS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_Appointment_Patient_NHS_NumberLabel.Location = new System.Drawing.Point(16, 371);
            gP_Appointment_Patient_NHS_NumberLabel.Name = "gP_Appointment_Patient_NHS_NumberLabel";
            gP_Appointment_Patient_NHS_NumberLabel.Size = new System.Drawing.Size(281, 16);
            gP_Appointment_Patient_NHS_NumberLabel.TabIndex = 17;
            gP_Appointment_Patient_NHS_NumberLabel.Text = "GP Appointment Patient NHS Number:";
            // 
            // invoice_NoLabel
            // 
            invoice_NoLabel.AutoSize = true;
            invoice_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoice_NoLabel.Location = new System.Drawing.Point(500, 164);
            invoice_NoLabel.Name = "invoice_NoLabel";
            invoice_NoLabel.Size = new System.Drawing.Size(89, 16);
            invoice_NoLabel.TabIndex = 19;
            invoice_NoLabel.Text = "Invoice No:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstnameLabel.Location = new System.Drawing.Point(500, 190);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(81, 16);
            firstnameLabel.TabIndex = 21;
            firstnameLabel.Text = "Firstname:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            surnameLabel.Location = new System.Drawing.Point(500, 216);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(74, 16);
            surnameLabel.TabIndex = 23;
            surnameLabel.Text = "Surname:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_of_BirthLabel.Location = new System.Drawing.Point(500, 242);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(101, 16);
            date_of_BirthLabel.TabIndex = 25;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // billing_NameLabel
            // 
            billing_NameLabel.AutoSize = true;
            billing_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            billing_NameLabel.Location = new System.Drawing.Point(500, 268);
            billing_NameLabel.Name = "billing_NameLabel";
            billing_NameLabel.Size = new System.Drawing.Size(103, 16);
            billing_NameLabel.TabIndex = 27;
            billing_NameLabel.Text = "Billing Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(500, 294);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(71, 16);
            addressLabel.TabIndex = 29;
            addressLabel.Text = "Address:";
            // 
            // post_CodeLabel
            // 
            post_CodeLabel.AutoSize = true;
            post_CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            post_CodeLabel.Location = new System.Drawing.Point(500, 320);
            post_CodeLabel.Name = "post_CodeLabel";
            post_CodeLabel.Size = new System.Drawing.Size(88, 16);
            post_CodeLabel.TabIndex = 31;
            post_CodeLabel.Text = "Post Code:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(500, 346);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(40, 16);
            cityLabel.TabIndex = 33;
            cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.Location = new System.Drawing.Point(500, 372);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(66, 16);
            countryLabel.TabIndex = 35;
            countryLabel.Text = "Country:";
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacy_OfficeBindingSource
            // 
            this.pharmacy_OfficeBindingSource.DataMember = "Pharmacy_Office";
            this.pharmacy_OfficeBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacy_OfficeTableAdapter
            // 
            this.pharmacy_OfficeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pharmacy_OfficeBindingNavigator
            // 
            this.pharmacy_OfficeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pharmacy_OfficeBindingNavigator.BindingSource = this.pharmacy_OfficeBindingSource;
            this.pharmacy_OfficeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pharmacy_OfficeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pharmacy_OfficeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pharmacy_OfficeBindingNavigatorSaveItem});
            this.pharmacy_OfficeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pharmacy_OfficeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pharmacy_OfficeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pharmacy_OfficeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pharmacy_OfficeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pharmacy_OfficeBindingNavigator.Name = "pharmacy_OfficeBindingNavigator";
            this.pharmacy_OfficeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pharmacy_OfficeBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.pharmacy_OfficeBindingNavigator.TabIndex = 0;
            this.pharmacy_OfficeBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // pharmacy_OfficeBindingNavigatorSaveItem
            // 
            this.pharmacy_OfficeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pharmacy_OfficeBindingNavigatorSaveItem.Enabled = false;
            this.pharmacy_OfficeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pharmacy_OfficeBindingNavigatorSaveItem.Image")));
            this.pharmacy_OfficeBindingNavigatorSaveItem.Name = "pharmacy_OfficeBindingNavigatorSaveItem";
            this.pharmacy_OfficeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pharmacy_OfficeBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // reference_NumberTextBox
            // 
            this.reference_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Reference Number", true));
            this.reference_NumberTextBox.Location = new System.Drawing.Point(305, 162);
            this.reference_NumberTextBox.Name = "reference_NumberTextBox";
            this.reference_NumberTextBox.Size = new System.Drawing.Size(124, 20);
            this.reference_NumberTextBox.TabIndex = 2;
            // 
            // patient__IDTextBox
            // 
            this.patient__IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Patient  ID", true));
            this.patient__IDTextBox.Location = new System.Drawing.Point(305, 188);
            this.patient__IDTextBox.Name = "patient__IDTextBox";
            this.patient__IDTextBox.Size = new System.Drawing.Size(124, 20);
            this.patient__IDTextBox.TabIndex = 4;
            // 
            // doctor_s_NHS_NoTextBox
            // 
            this.doctor_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Doctor\'s NHS No", true));
            this.doctor_s_NHS_NoTextBox.Location = new System.Drawing.Point(305, 214);
            this.doctor_s_NHS_NoTextBox.Name = "doctor_s_NHS_NoTextBox";
            this.doctor_s_NHS_NoTextBox.Size = new System.Drawing.Size(124, 20);
            this.doctor_s_NHS_NoTextBox.TabIndex = 6;
            // 
            // medical_Centre_NameTextBox
            // 
            this.medical_Centre_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Medical Centre Name", true));
            this.medical_Centre_NameTextBox.Location = new System.Drawing.Point(305, 240);
            this.medical_Centre_NameTextBox.Name = "medical_Centre_NameTextBox";
            this.medical_Centre_NameTextBox.Size = new System.Drawing.Size(124, 20);
            this.medical_Centre_NameTextBox.TabIndex = 8;
            // 
            // eMIS_NumberTextBox
            // 
            this.eMIS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "EMIS Number", true));
            this.eMIS_NumberTextBox.Location = new System.Drawing.Point(305, 266);
            this.eMIS_NumberTextBox.Name = "eMIS_NumberTextBox";
            this.eMIS_NumberTextBox.Size = new System.Drawing.Size(124, 20);
            this.eMIS_NumberTextBox.TabIndex = 10;
            // 
            // doctor_GP_Appointment_RefTextBox
            // 
            this.doctor_GP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Doctor_GP Appointment Ref", true));
            this.doctor_GP_Appointment_RefTextBox.Location = new System.Drawing.Point(305, 292);
            this.doctor_GP_Appointment_RefTextBox.Name = "doctor_GP_Appointment_RefTextBox";
            this.doctor_GP_Appointment_RefTextBox.Size = new System.Drawing.Size(124, 20);
            this.doctor_GP_Appointment_RefTextBox.TabIndex = 12;
            // 
            // doctor_Patient_NHS_NumberTextBox
            // 
            this.doctor_Patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Doctor_Patient NHS Number", true));
            this.doctor_Patient_NHS_NumberTextBox.Location = new System.Drawing.Point(305, 318);
            this.doctor_Patient_NHS_NumberTextBox.Name = "doctor_Patient_NHS_NumberTextBox";
            this.doctor_Patient_NHS_NumberTextBox.Size = new System.Drawing.Size(124, 20);
            this.doctor_Patient_NHS_NumberTextBox.TabIndex = 14;
            // 
            // gP_Appointment_GP_Appointment_RefTextBox
            // 
            this.gP_Appointment_GP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "GP Appointment_GP Appointment Ref", true));
            this.gP_Appointment_GP_Appointment_RefTextBox.Location = new System.Drawing.Point(305, 344);
            this.gP_Appointment_GP_Appointment_RefTextBox.Name = "gP_Appointment_GP_Appointment_RefTextBox";
            this.gP_Appointment_GP_Appointment_RefTextBox.Size = new System.Drawing.Size(124, 20);
            this.gP_Appointment_GP_Appointment_RefTextBox.TabIndex = 16;
            // 
            // gP_Appointment_Patient_NHS_NumberTextBox
            // 
            this.gP_Appointment_Patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "GP Appointment_Patient NHS Number", true));
            this.gP_Appointment_Patient_NHS_NumberTextBox.Location = new System.Drawing.Point(305, 370);
            this.gP_Appointment_Patient_NHS_NumberTextBox.Name = "gP_Appointment_Patient_NHS_NumberTextBox";
            this.gP_Appointment_Patient_NHS_NumberTextBox.Size = new System.Drawing.Size(124, 20);
            this.gP_Appointment_Patient_NHS_NumberTextBox.TabIndex = 18;
            // 
            // invoice_NoTextBox
            // 
            this.invoice_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Invoice No", true));
            this.invoice_NoTextBox.Location = new System.Drawing.Point(629, 165);
            this.invoice_NoTextBox.Name = "invoice_NoTextBox";
            this.invoice_NoTextBox.Size = new System.Drawing.Size(126, 20);
            this.invoice_NoTextBox.TabIndex = 20;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(629, 191);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(126, 20);
            this.firstnameTextBox.TabIndex = 22;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(629, 217);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(126, 20);
            this.surnameTextBox.TabIndex = 24;
            // 
            // date_of_BirthTextBox
            // 
            this.date_of_BirthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Date of Birth", true));
            this.date_of_BirthTextBox.Location = new System.Drawing.Point(629, 243);
            this.date_of_BirthTextBox.Name = "date_of_BirthTextBox";
            this.date_of_BirthTextBox.Size = new System.Drawing.Size(126, 20);
            this.date_of_BirthTextBox.TabIndex = 26;
            // 
            // billing_NameTextBox
            // 
            this.billing_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Billing Name", true));
            this.billing_NameTextBox.Location = new System.Drawing.Point(629, 269);
            this.billing_NameTextBox.Name = "billing_NameTextBox";
            this.billing_NameTextBox.Size = new System.Drawing.Size(126, 20);
            this.billing_NameTextBox.TabIndex = 28;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(629, 295);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(126, 20);
            this.addressTextBox.TabIndex = 30;
            // 
            // post_CodeTextBox
            // 
            this.post_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Post Code", true));
            this.post_CodeTextBox.Location = new System.Drawing.Point(629, 321);
            this.post_CodeTextBox.Name = "post_CodeTextBox";
            this.post_CodeTextBox.Size = new System.Drawing.Size(126, 20);
            this.post_CodeTextBox.TabIndex = 32;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(629, 347);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(126, 20);
            this.cityTextBox.TabIndex = 34;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacy_OfficeBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(629, 373);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(126, 20);
            this.countryTextBox.TabIndex = 36;
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
            this.panel_Title.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacy Office";
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
            this.panel2.Location = new System.Drawing.Point(19, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 42);
            this.panel2.TabIndex = 46;
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
            this.panel1.Controls.Add(this.pharmacyDataGridView);
            this.panel1.Location = new System.Drawing.Point(19, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 263);
            this.panel1.TabIndex = 45;
            // 
            // pharmacyDataGridView
            // 
            this.pharmacyDataGridView.AutoGenerateColumns = false;
            this.pharmacyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenceNumberDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.doctorsNHSNoDataGridViewTextBoxColumn,
            this.medicalCentreNameDataGridViewTextBoxColumn,
            this.eMISNumberDataGridViewTextBoxColumn,
            this.doctorGPAppointmentRefDataGridViewTextBoxColumn,
            this.doctorPatientNHSNumberDataGridViewTextBoxColumn,
            this.gPAppointmentGPAppointmentRefDataGridViewTextBoxColumn,
            this.gPAppointmentPatientNHSNumberDataGridViewTextBoxColumn,
            this.invoiceNoDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.billingNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.pharmacyDataGridView.DataSource = this.pharmacy_OfficeBindingSource;
            this.pharmacyDataGridView.Location = new System.Drawing.Point(3, 3);
            this.pharmacyDataGridView.Name = "pharmacyDataGridView";
            this.pharmacyDataGridView.Size = new System.Drawing.Size(732, 253);
            this.pharmacyDataGridView.TabIndex = 0;
            // 
            // referenceNumberDataGridViewTextBoxColumn
            // 
            this.referenceNumberDataGridViewTextBoxColumn.DataPropertyName = "Reference Number";
            this.referenceNumberDataGridViewTextBoxColumn.HeaderText = "Reference Number";
            this.referenceNumberDataGridViewTextBoxColumn.Name = "referenceNumberDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient  ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient  ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // doctorsNHSNoDataGridViewTextBoxColumn
            // 
            this.doctorsNHSNoDataGridViewTextBoxColumn.DataPropertyName = "Doctor\'s NHS No";
            this.doctorsNHSNoDataGridViewTextBoxColumn.HeaderText = "Doctor\'s NHS No";
            this.doctorsNHSNoDataGridViewTextBoxColumn.Name = "doctorsNHSNoDataGridViewTextBoxColumn";
            // 
            // medicalCentreNameDataGridViewTextBoxColumn
            // 
            this.medicalCentreNameDataGridViewTextBoxColumn.DataPropertyName = "Medical Centre Name";
            this.medicalCentreNameDataGridViewTextBoxColumn.HeaderText = "Medical Centre Name";
            this.medicalCentreNameDataGridViewTextBoxColumn.Name = "medicalCentreNameDataGridViewTextBoxColumn";
            // 
            // eMISNumberDataGridViewTextBoxColumn
            // 
            this.eMISNumberDataGridViewTextBoxColumn.DataPropertyName = "EMIS Number";
            this.eMISNumberDataGridViewTextBoxColumn.HeaderText = "EMIS Number";
            this.eMISNumberDataGridViewTextBoxColumn.Name = "eMISNumberDataGridViewTextBoxColumn";
            // 
            // doctorGPAppointmentRefDataGridViewTextBoxColumn
            // 
            this.doctorGPAppointmentRefDataGridViewTextBoxColumn.DataPropertyName = "Doctor_GP Appointment Ref";
            this.doctorGPAppointmentRefDataGridViewTextBoxColumn.HeaderText = "Doctor_GP Appointment Ref";
            this.doctorGPAppointmentRefDataGridViewTextBoxColumn.Name = "doctorGPAppointmentRefDataGridViewTextBoxColumn";
            // 
            // doctorPatientNHSNumberDataGridViewTextBoxColumn
            // 
            this.doctorPatientNHSNumberDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Patient NHS Number";
            this.doctorPatientNHSNumberDataGridViewTextBoxColumn.HeaderText = "Doctor_Patient NHS Number";
            this.doctorPatientNHSNumberDataGridViewTextBoxColumn.Name = "doctorPatientNHSNumberDataGridViewTextBoxColumn";
            // 
            // gPAppointmentGPAppointmentRefDataGridViewTextBoxColumn
            // 
            this.gPAppointmentGPAppointmentRefDataGridViewTextBoxColumn.DataPropertyName = "GP Appointment_GP Appointment Ref";
            this.gPAppointmentGPAppointmentRefDataGridViewTextBoxColumn.HeaderText = "GP Appointment_GP Appointment Ref";
            this.gPAppointmentGPAppointmentRefDataGridViewTextBoxColumn.Name = "gPAppointmentGPAppointmentRefDataGridViewTextBoxColumn";
            // 
            // gPAppointmentPatientNHSNumberDataGridViewTextBoxColumn
            // 
            this.gPAppointmentPatientNHSNumberDataGridViewTextBoxColumn.DataPropertyName = "GP Appointment_Patient NHS Number";
            this.gPAppointmentPatientNHSNumberDataGridViewTextBoxColumn.HeaderText = "GP Appointment_Patient NHS Number";
            this.gPAppointmentPatientNHSNumberDataGridViewTextBoxColumn.Name = "gPAppointmentPatientNHSNumberDataGridViewTextBoxColumn";
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "Invoice No";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "Invoice No";
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // billingNameDataGridViewTextBoxColumn
            // 
            this.billingNameDataGridViewTextBoxColumn.DataPropertyName = "Billing Name";
            this.billingNameDataGridViewTextBoxColumn.HeaderText = "Billing Name";
            this.billingNameDataGridViewTextBoxColumn.Name = "billingNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "Post Code";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "Post Code";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(reference_NumberLabel);
            this.Controls.Add(this.reference_NumberTextBox);
            this.Controls.Add(patient__IDLabel);
            this.Controls.Add(this.patient__IDTextBox);
            this.Controls.Add(doctor_s_NHS_NoLabel);
            this.Controls.Add(this.doctor_s_NHS_NoTextBox);
            this.Controls.Add(medical_Centre_NameLabel);
            this.Controls.Add(this.medical_Centre_NameTextBox);
            this.Controls.Add(eMIS_NumberLabel);
            this.Controls.Add(this.eMIS_NumberTextBox);
            this.Controls.Add(doctor_GP_Appointment_RefLabel);
            this.Controls.Add(this.doctor_GP_Appointment_RefTextBox);
            this.Controls.Add(doctor_Patient_NHS_NumberLabel);
            this.Controls.Add(this.doctor_Patient_NHS_NumberTextBox);
            this.Controls.Add(gP_Appointment_GP_Appointment_RefLabel);
            this.Controls.Add(this.gP_Appointment_GP_Appointment_RefTextBox);
            this.Controls.Add(gP_Appointment_Patient_NHS_NumberLabel);
            this.Controls.Add(this.gP_Appointment_Patient_NHS_NumberTextBox);
            this.Controls.Add(invoice_NoLabel);
            this.Controls.Add(this.invoice_NoTextBox);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(date_of_BirthLabel);
            this.Controls.Add(this.date_of_BirthTextBox);
            this.Controls.Add(billing_NameLabel);
            this.Controls.Add(this.billing_NameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(post_CodeLabel);
            this.Controls.Add(this.post_CodeTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.pharmacy_OfficeBindingNavigator);
            this.Name = "Form7";
            this.Text = "Pharmacy Office";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_OfficeBindingNavigator)).EndInit();
            this.pharmacy_OfficeBindingNavigator.ResumeLayout(false);
            this.pharmacy_OfficeBindingNavigator.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource pharmacy_OfficeBindingSource;
        private PharmacyDataSetTableAdapters.Pharmacy_OfficeTableAdapter pharmacy_OfficeTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pharmacy_OfficeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pharmacy_OfficeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox reference_NumberTextBox;
        private System.Windows.Forms.TextBox patient__IDTextBox;
        private System.Windows.Forms.TextBox doctor_s_NHS_NoTextBox;
        private System.Windows.Forms.TextBox medical_Centre_NameTextBox;
        private System.Windows.Forms.TextBox eMIS_NumberTextBox;
        private System.Windows.Forms.TextBox doctor_GP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox doctor_Patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_GP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_Patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox invoice_NoTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox date_of_BirthTextBox;
        private System.Windows.Forms.TextBox billing_NameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox post_CodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
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
        private System.Windows.Forms.DataGridView pharmacyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorsNHSNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalCentreNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMISNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorGPAppointmentRefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorPatientNHSNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPAppointmentGPAppointmentRefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPAppointmentPatientNHSNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
    }
}