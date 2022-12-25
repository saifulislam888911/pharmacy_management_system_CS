namespace CS_Pharmacy_Management_Systems
{
    partial class Form2
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
            System.Windows.Forms.Label doctor_s_Ref_NoLabel;
            System.Windows.Forms.Label doctor_s_NHS_NoLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label medical_Centre_NameLabel;
            System.Windows.Forms.Label address_of_CentreLabel;
            System.Windows.Forms.Label post_CodeLabel;
            System.Windows.Forms.Label medical_Centre_RefLabel;
            System.Windows.Forms.Label office_Phone_No_1Label;
            System.Windows.Forms.Label office_Phone_No_2Label;
            System.Windows.Forms.Label fax_NoLabel;
            System.Windows.Forms.Label email_AddressLabel;
            System.Windows.Forms.Label patient_NHS_NumberLabel;
            System.Windows.Forms.Label eMIS_NumberLabel;
            System.Windows.Forms.Label gP_Appointment_RefLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pharmacyDataSet = new CS_Pharmacy_Management_Systems.PharmacyDataSet();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.DoctorTableAdapter();
            this.tableAdapterManager = new CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.doctorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.doctorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.doctor_s_Ref_NoTextBox = new System.Windows.Forms.TextBox();
            this.doctor_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.medical_Centre_NameTextBox = new System.Windows.Forms.TextBox();
            this.address_of_CentreTextBox = new System.Windows.Forms.TextBox();
            this.post_CodeTextBox = new System.Windows.Forms.TextBox();
            this.medical_Centre_RefTextBox = new System.Windows.Forms.TextBox();
            this.office_Phone_No_1TextBox = new System.Windows.Forms.TextBox();
            this.office_Phone_No_2TextBox = new System.Windows.Forms.TextBox();
            this.fax_NoTextBox = new System.Windows.Forms.TextBox();
            this.email_AddressTextBox = new System.Windows.Forms.TextBox();
            this.patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.eMIS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.doctorDataGridView = new System.Windows.Forms.DataGridView();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            doctor_s_Ref_NoLabel = new System.Windows.Forms.Label();
            doctor_s_NHS_NoLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            medical_Centre_NameLabel = new System.Windows.Forms.Label();
            address_of_CentreLabel = new System.Windows.Forms.Label();
            post_CodeLabel = new System.Windows.Forms.Label();
            medical_Centre_RefLabel = new System.Windows.Forms.Label();
            office_Phone_No_1Label = new System.Windows.Forms.Label();
            office_Phone_No_2Label = new System.Windows.Forms.Label();
            fax_NoLabel = new System.Windows.Forms.Label();
            email_AddressLabel = new System.Windows.Forms.Label();
            patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            eMIS_NumberLabel = new System.Windows.Forms.Label();
            gP_Appointment_RefLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingNavigator)).BeginInit();
            this.doctorBindingNavigator.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctor_s_Ref_NoLabel
            // 
            doctor_s_Ref_NoLabel.AutoSize = true;
            doctor_s_Ref_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_s_Ref_NoLabel.Location = new System.Drawing.Point(16, 127);
            doctor_s_Ref_NoLabel.Name = "doctor_s_Ref_NoLabel";
            doctor_s_Ref_NoLabel.Size = new System.Drawing.Size(127, 16);
            doctor_s_Ref_NoLabel.TabIndex = 1;
            doctor_s_Ref_NoLabel.Text = "Doctor\'s Ref No:";
            // 
            // doctor_s_NHS_NoLabel
            // 
            doctor_s_NHS_NoLabel.AutoSize = true;
            doctor_s_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_s_NHS_NoLabel.Location = new System.Drawing.Point(16, 153);
            doctor_s_NHS_NoLabel.Name = "doctor_s_NHS_NoLabel";
            doctor_s_NHS_NoLabel.Size = new System.Drawing.Size(137, 16);
            doctor_s_NHS_NoLabel.TabIndex = 3;
            doctor_s_NHS_NoLabel.Text = "Doctor\'s NHS No:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstnameLabel.Location = new System.Drawing.Point(16, 179);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(81, 16);
            firstnameLabel.TabIndex = 5;
            firstnameLabel.Text = "Firstname:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            surnameLabel.Location = new System.Drawing.Point(16, 205);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(74, 16);
            surnameLabel.TabIndex = 7;
            surnameLabel.Text = "Surname:";
            // 
            // medical_Centre_NameLabel
            // 
            medical_Centre_NameLabel.AutoSize = true;
            medical_Centre_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medical_Centre_NameLabel.Location = new System.Drawing.Point(16, 231);
            medical_Centre_NameLabel.Name = "medical_Centre_NameLabel";
            medical_Centre_NameLabel.Size = new System.Drawing.Size(167, 16);
            medical_Centre_NameLabel.TabIndex = 9;
            medical_Centre_NameLabel.Text = "Medical Centre Name:";
            // 
            // address_of_CentreLabel
            // 
            address_of_CentreLabel.AutoSize = true;
            address_of_CentreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address_of_CentreLabel.Location = new System.Drawing.Point(16, 257);
            address_of_CentreLabel.Name = "address_of_CentreLabel";
            address_of_CentreLabel.Size = new System.Drawing.Size(141, 16);
            address_of_CentreLabel.TabIndex = 11;
            address_of_CentreLabel.Text = "Address of Centre:";
            // 
            // post_CodeLabel
            // 
            post_CodeLabel.AutoSize = true;
            post_CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            post_CodeLabel.Location = new System.Drawing.Point(16, 283);
            post_CodeLabel.Name = "post_CodeLabel";
            post_CodeLabel.Size = new System.Drawing.Size(88, 16);
            post_CodeLabel.TabIndex = 13;
            post_CodeLabel.Text = "Post Code:";
            // 
            // medical_Centre_RefLabel
            // 
            medical_Centre_RefLabel.AutoSize = true;
            medical_Centre_RefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medical_Centre_RefLabel.Location = new System.Drawing.Point(16, 309);
            medical_Centre_RefLabel.Name = "medical_Centre_RefLabel";
            medical_Centre_RefLabel.Size = new System.Drawing.Size(150, 16);
            medical_Centre_RefLabel.TabIndex = 15;
            medical_Centre_RefLabel.Text = "Medical Centre Ref:";
            // 
            // office_Phone_No_1Label
            // 
            office_Phone_No_1Label.AutoSize = true;
            office_Phone_No_1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            office_Phone_No_1Label.Location = new System.Drawing.Point(401, 131);
            office_Phone_No_1Label.Name = "office_Phone_No_1Label";
            office_Phone_No_1Label.Size = new System.Drawing.Size(143, 16);
            office_Phone_No_1Label.TabIndex = 17;
            office_Phone_No_1Label.Text = "Office Phone No 1:";
            // 
            // office_Phone_No_2Label
            // 
            office_Phone_No_2Label.AutoSize = true;
            office_Phone_No_2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            office_Phone_No_2Label.Location = new System.Drawing.Point(401, 157);
            office_Phone_No_2Label.Name = "office_Phone_No_2Label";
            office_Phone_No_2Label.Size = new System.Drawing.Size(143, 16);
            office_Phone_No_2Label.TabIndex = 19;
            office_Phone_No_2Label.Text = "Office Phone No 2:";
            // 
            // fax_NoLabel
            // 
            fax_NoLabel.AutoSize = true;
            fax_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fax_NoLabel.Location = new System.Drawing.Point(401, 183);
            fax_NoLabel.Name = "fax_NoLabel";
            fax_NoLabel.Size = new System.Drawing.Size(64, 16);
            fax_NoLabel.TabIndex = 21;
            fax_NoLabel.Text = "Fax No:";
            // 
            // email_AddressLabel
            // 
            email_AddressLabel.AutoSize = true;
            email_AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            email_AddressLabel.Location = new System.Drawing.Point(401, 209);
            email_AddressLabel.Name = "email_AddressLabel";
            email_AddressLabel.Size = new System.Drawing.Size(116, 16);
            email_AddressLabel.TabIndex = 23;
            email_AddressLabel.Text = "Email Address:";
            // 
            // patient_NHS_NumberLabel
            // 
            patient_NHS_NumberLabel.AutoSize = true;
            patient_NHS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_NHS_NumberLabel.Location = new System.Drawing.Point(401, 235);
            patient_NHS_NumberLabel.Name = "patient_NHS_NumberLabel";
            patient_NHS_NumberLabel.Size = new System.Drawing.Size(161, 16);
            patient_NHS_NumberLabel.TabIndex = 25;
            patient_NHS_NumberLabel.Text = "Patient NHS Number:";
            // 
            // eMIS_NumberLabel
            // 
            eMIS_NumberLabel.AutoSize = true;
            eMIS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMIS_NumberLabel.Location = new System.Drawing.Point(401, 261);
            eMIS_NumberLabel.Name = "eMIS_NumberLabel";
            eMIS_NumberLabel.Size = new System.Drawing.Size(112, 16);
            eMIS_NumberLabel.TabIndex = 27;
            eMIS_NumberLabel.Text = "EMIS Number:";
            // 
            // gP_Appointment_RefLabel
            // 
            gP_Appointment_RefLabel.AutoSize = true;
            gP_Appointment_RefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_Appointment_RefLabel.Location = new System.Drawing.Point(401, 287);
            gP_Appointment_RefLabel.Name = "gP_Appointment_RefLabel";
            gP_Appointment_RefLabel.Size = new System.Drawing.Size(157, 16);
            gP_Appointment_RefLabel.TabIndex = 29;
            gP_Appointment_RefLabel.Text = "GP Appointment Ref:";
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_IDLabel.Location = new System.Drawing.Point(401, 313);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(83, 16);
            patient_IDLabel.TabIndex = 31;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = this.doctorTableAdapter;
            this.tableAdapterManager.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctorBindingNavigator
            // 
            this.doctorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doctorBindingNavigator.BindingSource = this.doctorBindingSource;
            this.doctorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doctorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doctorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.doctorBindingNavigatorSaveItem});
            this.doctorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.doctorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doctorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doctorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doctorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doctorBindingNavigator.Name = "doctorBindingNavigator";
            this.doctorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doctorBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.doctorBindingNavigator.TabIndex = 0;
            this.doctorBindingNavigator.Text = "bindingNavigator1";
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
            // doctorBindingNavigatorSaveItem
            // 
            this.doctorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorBindingNavigatorSaveItem.Image")));
            this.doctorBindingNavigatorSaveItem.Name = "doctorBindingNavigatorSaveItem";
            this.doctorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.doctorBindingNavigatorSaveItem.Text = "Save Data";
            this.doctorBindingNavigatorSaveItem.Click += new System.EventHandler(this.doctorBindingNavigatorSaveItem_Click);
            // 
            // doctor_s_Ref_NoTextBox
            // 
            this.doctor_s_Ref_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Doctor\'s Ref No", true));
            this.doctor_s_Ref_NoTextBox.Location = new System.Drawing.Point(228, 127);
            this.doctor_s_Ref_NoTextBox.Name = "doctor_s_Ref_NoTextBox";
            this.doctor_s_Ref_NoTextBox.Size = new System.Drawing.Size(156, 20);
            this.doctor_s_Ref_NoTextBox.TabIndex = 2;
            // 
            // doctor_s_NHS_NoTextBox
            // 
            this.doctor_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Doctor\'s NHS No", true));
            this.doctor_s_NHS_NoTextBox.Location = new System.Drawing.Point(228, 153);
            this.doctor_s_NHS_NoTextBox.Name = "doctor_s_NHS_NoTextBox";
            this.doctor_s_NHS_NoTextBox.Size = new System.Drawing.Size(156, 20);
            this.doctor_s_NHS_NoTextBox.TabIndex = 4;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(228, 179);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(156, 20);
            this.firstnameTextBox.TabIndex = 6;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(228, 205);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(156, 20);
            this.surnameTextBox.TabIndex = 8;
            // 
            // medical_Centre_NameTextBox
            // 
            this.medical_Centre_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Medical Centre Name", true));
            this.medical_Centre_NameTextBox.Location = new System.Drawing.Point(228, 231);
            this.medical_Centre_NameTextBox.Name = "medical_Centre_NameTextBox";
            this.medical_Centre_NameTextBox.Size = new System.Drawing.Size(156, 20);
            this.medical_Centre_NameTextBox.TabIndex = 10;
            // 
            // address_of_CentreTextBox
            // 
            this.address_of_CentreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Address of Centre", true));
            this.address_of_CentreTextBox.Location = new System.Drawing.Point(228, 257);
            this.address_of_CentreTextBox.Name = "address_of_CentreTextBox";
            this.address_of_CentreTextBox.Size = new System.Drawing.Size(156, 20);
            this.address_of_CentreTextBox.TabIndex = 12;
            // 
            // post_CodeTextBox
            // 
            this.post_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Post Code", true));
            this.post_CodeTextBox.Location = new System.Drawing.Point(228, 283);
            this.post_CodeTextBox.Name = "post_CodeTextBox";
            this.post_CodeTextBox.Size = new System.Drawing.Size(156, 20);
            this.post_CodeTextBox.TabIndex = 14;
            // 
            // medical_Centre_RefTextBox
            // 
            this.medical_Centre_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Medical Centre Ref", true));
            this.medical_Centre_RefTextBox.Location = new System.Drawing.Point(228, 309);
            this.medical_Centre_RefTextBox.Name = "medical_Centre_RefTextBox";
            this.medical_Centre_RefTextBox.Size = new System.Drawing.Size(156, 20);
            this.medical_Centre_RefTextBox.TabIndex = 16;
            // 
            // office_Phone_No_1TextBox
            // 
            this.office_Phone_No_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Office Phone No 1", true));
            this.office_Phone_No_1TextBox.Location = new System.Drawing.Point(613, 131);
            this.office_Phone_No_1TextBox.Name = "office_Phone_No_1TextBox";
            this.office_Phone_No_1TextBox.Size = new System.Drawing.Size(156, 20);
            this.office_Phone_No_1TextBox.TabIndex = 18;
            // 
            // office_Phone_No_2TextBox
            // 
            this.office_Phone_No_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Office Phone No 2", true));
            this.office_Phone_No_2TextBox.Location = new System.Drawing.Point(613, 157);
            this.office_Phone_No_2TextBox.Name = "office_Phone_No_2TextBox";
            this.office_Phone_No_2TextBox.Size = new System.Drawing.Size(156, 20);
            this.office_Phone_No_2TextBox.TabIndex = 20;
            // 
            // fax_NoTextBox
            // 
            this.fax_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Fax No", true));
            this.fax_NoTextBox.Location = new System.Drawing.Point(613, 183);
            this.fax_NoTextBox.Name = "fax_NoTextBox";
            this.fax_NoTextBox.Size = new System.Drawing.Size(156, 20);
            this.fax_NoTextBox.TabIndex = 22;
            // 
            // email_AddressTextBox
            // 
            this.email_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Email Address", true));
            this.email_AddressTextBox.Location = new System.Drawing.Point(613, 209);
            this.email_AddressTextBox.Name = "email_AddressTextBox";
            this.email_AddressTextBox.Size = new System.Drawing.Size(156, 20);
            this.email_AddressTextBox.TabIndex = 24;
            // 
            // patient_NHS_NumberTextBox
            // 
            this.patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Patient NHS Number", true));
            this.patient_NHS_NumberTextBox.Location = new System.Drawing.Point(613, 235);
            this.patient_NHS_NumberTextBox.Name = "patient_NHS_NumberTextBox";
            this.patient_NHS_NumberTextBox.Size = new System.Drawing.Size(156, 20);
            this.patient_NHS_NumberTextBox.TabIndex = 26;
            // 
            // eMIS_NumberTextBox
            // 
            this.eMIS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "EMIS Number", true));
            this.eMIS_NumberTextBox.Location = new System.Drawing.Point(613, 261);
            this.eMIS_NumberTextBox.Name = "eMIS_NumberTextBox";
            this.eMIS_NumberTextBox.Size = new System.Drawing.Size(156, 20);
            this.eMIS_NumberTextBox.TabIndex = 28;
            // 
            // gP_Appointment_RefTextBox
            // 
            this.gP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "GP Appointment Ref", true));
            this.gP_Appointment_RefTextBox.Location = new System.Drawing.Point(613, 287);
            this.gP_Appointment_RefTextBox.Name = "gP_Appointment_RefTextBox";
            this.gP_Appointment_RefTextBox.Size = new System.Drawing.Size(156, 20);
            this.gP_Appointment_RefTextBox.TabIndex = 30;
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Location = new System.Drawing.Point(613, 313);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(156, 20);
            this.patient_IDTextBox.TabIndex = 32;
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
            this.panel_Title.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.doctorDataGridView);
            this.panel1.Location = new System.Drawing.Point(19, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 311);
            this.panel1.TabIndex = 35;
            // 
            // doctorDataGridView
            // 
            this.doctorDataGridView.AutoGenerateColumns = false;
            this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn16});
            this.doctorDataGridView.DataSource = this.doctorBindingSource;
            this.doctorDataGridView.Location = new System.Drawing.Point(3, 3);
            this.doctorDataGridView.Name = "doctorDataGridView";
            this.doctorDataGridView.Size = new System.Drawing.Size(742, 301);
            this.doctorDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Doctor\'s Ref No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Doctor\'s Ref No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Doctor\'s NHS No";
            this.dataGridViewTextBoxColumn2.HeaderText = "Doctor\'s NHS No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Firstname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Firstname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Medical Centre Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Medical Centre Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address of Centre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address of Centre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Post Code";
            this.dataGridViewTextBoxColumn7.HeaderText = "Post Code";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Medical Centre Ref";
            this.dataGridViewTextBoxColumn8.HeaderText = "Medical Centre Ref";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Office Phone No 1";
            this.dataGridViewTextBoxColumn9.HeaderText = "Office Phone No 1";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Office Phone No 2";
            this.dataGridViewTextBoxColumn10.HeaderText = "Office Phone No 2";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Fax No";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fax No";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Email Address";
            this.dataGridViewTextBoxColumn12.HeaderText = "Email Address";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Patient NHS Number";
            this.dataGridViewTextBoxColumn13.HeaderText = "Patient NHS Number";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "EMIS Number";
            this.dataGridViewTextBoxColumn14.HeaderText = "EMIS Number";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn15.HeaderText = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Patient ID";
            this.dataGridViewTextBoxColumn16.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
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
            this.panel2.Location = new System.Drawing.Point(24, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 42);
            this.panel2.TabIndex = 39;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Close.Location = new System.Drawing.Point(605, 3);
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
            this.btn_Save.Location = new System.Drawing.Point(516, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(83, 29);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Previous.Location = new System.Drawing.Point(414, 3);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(96, 29);
            this.btn_Previous.TabIndex = 18;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
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
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
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
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(doctor_s_Ref_NoLabel);
            this.Controls.Add(this.doctor_s_Ref_NoTextBox);
            this.Controls.Add(doctor_s_NHS_NoLabel);
            this.Controls.Add(this.doctor_s_NHS_NoTextBox);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(medical_Centre_NameLabel);
            this.Controls.Add(this.medical_Centre_NameTextBox);
            this.Controls.Add(address_of_CentreLabel);
            this.Controls.Add(this.address_of_CentreTextBox);
            this.Controls.Add(post_CodeLabel);
            this.Controls.Add(this.post_CodeTextBox);
            this.Controls.Add(medical_Centre_RefLabel);
            this.Controls.Add(this.medical_Centre_RefTextBox);
            this.Controls.Add(office_Phone_No_1Label);
            this.Controls.Add(this.office_Phone_No_1TextBox);
            this.Controls.Add(office_Phone_No_2Label);
            this.Controls.Add(this.office_Phone_No_2TextBox);
            this.Controls.Add(fax_NoLabel);
            this.Controls.Add(this.fax_NoTextBox);
            this.Controls.Add(email_AddressLabel);
            this.Controls.Add(this.email_AddressTextBox);
            this.Controls.Add(patient_NHS_NumberLabel);
            this.Controls.Add(this.patient_NHS_NumberTextBox);
            this.Controls.Add(eMIS_NumberLabel);
            this.Controls.Add(this.eMIS_NumberTextBox);
            this.Controls.Add(gP_Appointment_RefLabel);
            this.Controls.Add(this.gP_Appointment_RefTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(this.doctorBindingNavigator);
            this.Name = "Form2";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingNavigator)).EndInit();
            this.doctorBindingNavigator.ResumeLayout(false);
            this.doctorBindingNavigator.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private PharmacyDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doctorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton doctorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox doctor_s_Ref_NoTextBox;
        private System.Windows.Forms.TextBox doctor_s_NHS_NoTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox medical_Centre_NameTextBox;
        private System.Windows.Forms.TextBox address_of_CentreTextBox;
        private System.Windows.Forms.TextBox post_CodeTextBox;
        private System.Windows.Forms.TextBox medical_Centre_RefTextBox;
        private System.Windows.Forms.TextBox office_Phone_No_1TextBox;
        private System.Windows.Forms.TextBox office_Phone_No_2TextBox;
        private System.Windows.Forms.TextBox fax_NoTextBox;
        private System.Windows.Forms.TextBox email_AddressTextBox;
        private System.Windows.Forms.TextBox patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox eMIS_NumberTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView doctorDataGridView;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
    }
}