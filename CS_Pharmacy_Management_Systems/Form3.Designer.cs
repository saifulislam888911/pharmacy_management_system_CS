namespace CS_Pharmacy_Management_Systems
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label gP_Appointment_RefLabel;
            System.Windows.Forms.Label patient_NHS_NumberLabel;
            System.Windows.Forms.Label eMIS_NumberLabel;
            System.Windows.Forms.Label gP_AppointmentLabel;
            System.Windows.Forms.Label patient_Full_NameLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label medical_Centre_NameLabel;
            System.Windows.Forms.Label doctor_s_NHS_NoLabel;
            this.pharmacyDataSet = new CS_Pharmacy_Management_Systems.PharmacyDataSet();
            this.gP_AppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gP_AppointmentTableAdapter = new CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.GP_AppointmentTableAdapter();
            this.tableAdapterManager = new CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.gP_AppointmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gP_AppointmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.eMIS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gP_AppointmentTextBox = new System.Windows.Forms.TextBox();
            this.patient_Full_NameTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.medical_Centre_NameTextBox = new System.Windows.Forms.TextBox();
            this.doctor_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
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
            this.gP_AppointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gP_Appointment_RefLabel = new System.Windows.Forms.Label();
            patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            eMIS_NumberLabel = new System.Windows.Forms.Label();
            gP_AppointmentLabel = new System.Windows.Forms.Label();
            patient_Full_NameLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            medical_Centre_NameLabel = new System.Windows.Forms.Label();
            doctor_s_NHS_NoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingNavigator)).BeginInit();
            this.gP_AppointmentBindingNavigator.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gP_AppointmentBindingSource
            // 
            this.gP_AppointmentBindingSource.DataMember = "GP Appointment";
            this.gP_AppointmentBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // gP_AppointmentTableAdapter
            // 
            this.gP_AppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = this.gP_AppointmentTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CS_Pharmacy_Management_Systems.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gP_AppointmentBindingNavigator
            // 
            this.gP_AppointmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gP_AppointmentBindingNavigator.BindingSource = this.gP_AppointmentBindingSource;
            this.gP_AppointmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gP_AppointmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gP_AppointmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gP_AppointmentBindingNavigatorSaveItem});
            this.gP_AppointmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gP_AppointmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gP_AppointmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gP_AppointmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gP_AppointmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gP_AppointmentBindingNavigator.Name = "gP_AppointmentBindingNavigator";
            this.gP_AppointmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gP_AppointmentBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.gP_AppointmentBindingNavigator.TabIndex = 0;
            this.gP_AppointmentBindingNavigator.Text = "bindingNavigator1";
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
            // gP_AppointmentBindingNavigatorSaveItem
            // 
            this.gP_AppointmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gP_AppointmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gP_AppointmentBindingNavigatorSaveItem.Image")));
            this.gP_AppointmentBindingNavigatorSaveItem.Name = "gP_AppointmentBindingNavigatorSaveItem";
            this.gP_AppointmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gP_AppointmentBindingNavigatorSaveItem.Text = "Save Data";
            this.gP_AppointmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.gP_AppointmentBindingNavigatorSaveItem_Click);
            // 
            // gP_Appointment_RefLabel
            // 
            gP_Appointment_RefLabel.AutoSize = true;
            gP_Appointment_RefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_Appointment_RefLabel.Location = new System.Drawing.Point(220, 152);
            gP_Appointment_RefLabel.Name = "gP_Appointment_RefLabel";
            gP_Appointment_RefLabel.Size = new System.Drawing.Size(157, 16);
            gP_Appointment_RefLabel.TabIndex = 1;
            gP_Appointment_RefLabel.Text = "GP Appointment Ref:";
            // 
            // gP_Appointment_RefTextBox
            // 
            this.gP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "GP Appointment Ref", true));
            this.gP_Appointment_RefTextBox.Location = new System.Drawing.Point(405, 152);
            this.gP_Appointment_RefTextBox.Name = "gP_Appointment_RefTextBox";
            this.gP_Appointment_RefTextBox.Size = new System.Drawing.Size(167, 20);
            this.gP_Appointment_RefTextBox.TabIndex = 2;
            // 
            // patient_NHS_NumberLabel
            // 
            patient_NHS_NumberLabel.AutoSize = true;
            patient_NHS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_NHS_NumberLabel.Location = new System.Drawing.Point(220, 178);
            patient_NHS_NumberLabel.Name = "patient_NHS_NumberLabel";
            patient_NHS_NumberLabel.Size = new System.Drawing.Size(161, 16);
            patient_NHS_NumberLabel.TabIndex = 3;
            patient_NHS_NumberLabel.Text = "Patient NHS Number:";
            // 
            // patient_NHS_NumberTextBox
            // 
            this.patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient NHS Number", true));
            this.patient_NHS_NumberTextBox.Location = new System.Drawing.Point(405, 178);
            this.patient_NHS_NumberTextBox.Name = "patient_NHS_NumberTextBox";
            this.patient_NHS_NumberTextBox.Size = new System.Drawing.Size(167, 20);
            this.patient_NHS_NumberTextBox.TabIndex = 4;
            // 
            // eMIS_NumberLabel
            // 
            eMIS_NumberLabel.AutoSize = true;
            eMIS_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMIS_NumberLabel.Location = new System.Drawing.Point(220, 204);
            eMIS_NumberLabel.Name = "eMIS_NumberLabel";
            eMIS_NumberLabel.Size = new System.Drawing.Size(112, 16);
            eMIS_NumberLabel.TabIndex = 5;
            eMIS_NumberLabel.Text = "EMIS Number:";
            // 
            // eMIS_NumberTextBox
            // 
            this.eMIS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "EMIS Number", true));
            this.eMIS_NumberTextBox.Location = new System.Drawing.Point(405, 204);
            this.eMIS_NumberTextBox.Name = "eMIS_NumberTextBox";
            this.eMIS_NumberTextBox.Size = new System.Drawing.Size(167, 20);
            this.eMIS_NumberTextBox.TabIndex = 6;
            // 
            // gP_AppointmentLabel
            // 
            gP_AppointmentLabel.AutoSize = true;
            gP_AppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_AppointmentLabel.Location = new System.Drawing.Point(220, 230);
            gP_AppointmentLabel.Name = "gP_AppointmentLabel";
            gP_AppointmentLabel.Size = new System.Drawing.Size(127, 16);
            gP_AppointmentLabel.TabIndex = 7;
            gP_AppointmentLabel.Text = "GP Appointment:";
            // 
            // gP_AppointmentTextBox
            // 
            this.gP_AppointmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "GP Appointment", true));
            this.gP_AppointmentTextBox.Location = new System.Drawing.Point(405, 230);
            this.gP_AppointmentTextBox.Name = "gP_AppointmentTextBox";
            this.gP_AppointmentTextBox.Size = new System.Drawing.Size(167, 20);
            this.gP_AppointmentTextBox.TabIndex = 8;
            // 
            // patient_Full_NameLabel
            // 
            patient_Full_NameLabel.AutoSize = true;
            patient_Full_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_Full_NameLabel.Location = new System.Drawing.Point(220, 256);
            patient_Full_NameLabel.Name = "patient_Full_NameLabel";
            patient_Full_NameLabel.Size = new System.Drawing.Size(139, 16);
            patient_Full_NameLabel.TabIndex = 9;
            patient_Full_NameLabel.Text = "Patient Full Name:";
            // 
            // patient_Full_NameTextBox
            // 
            this.patient_Full_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient Full Name", true));
            this.patient_Full_NameTextBox.Location = new System.Drawing.Point(405, 256);
            this.patient_Full_NameTextBox.Name = "patient_Full_NameTextBox";
            this.patient_Full_NameTextBox.Size = new System.Drawing.Size(167, 20);
            this.patient_Full_NameTextBox.TabIndex = 10;
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_IDLabel.Location = new System.Drawing.Point(220, 282);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(83, 16);
            patient_IDLabel.TabIndex = 11;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Location = new System.Drawing.Point(405, 282);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(167, 20);
            this.patient_IDTextBox.TabIndex = 12;
            // 
            // medical_Centre_NameLabel
            // 
            medical_Centre_NameLabel.AutoSize = true;
            medical_Centre_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medical_Centre_NameLabel.Location = new System.Drawing.Point(220, 308);
            medical_Centre_NameLabel.Name = "medical_Centre_NameLabel";
            medical_Centre_NameLabel.Size = new System.Drawing.Size(167, 16);
            medical_Centre_NameLabel.TabIndex = 13;
            medical_Centre_NameLabel.Text = "Medical Centre Name:";
            // 
            // medical_Centre_NameTextBox
            // 
            this.medical_Centre_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Medical Centre Name", true));
            this.medical_Centre_NameTextBox.Location = new System.Drawing.Point(405, 308);
            this.medical_Centre_NameTextBox.Name = "medical_Centre_NameTextBox";
            this.medical_Centre_NameTextBox.Size = new System.Drawing.Size(167, 20);
            this.medical_Centre_NameTextBox.TabIndex = 14;
            // 
            // doctor_s_NHS_NoLabel
            // 
            doctor_s_NHS_NoLabel.AutoSize = true;
            doctor_s_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_s_NHS_NoLabel.Location = new System.Drawing.Point(220, 334);
            doctor_s_NHS_NoLabel.Name = "doctor_s_NHS_NoLabel";
            doctor_s_NHS_NoLabel.Size = new System.Drawing.Size(137, 16);
            doctor_s_NHS_NoLabel.TabIndex = 15;
            doctor_s_NHS_NoLabel.Text = "Doctor\'s NHS No:";
            // 
            // doctor_s_NHS_NoTextBox
            // 
            this.doctor_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Doctor\'s NHS No", true));
            this.doctor_s_NHS_NoTextBox.Location = new System.Drawing.Point(405, 334);
            this.doctor_s_NHS_NoTextBox.Name = "doctor_s_NHS_NoTextBox";
            this.doctor_s_NHS_NoTextBox.Size = new System.Drawing.Size(167, 20);
            this.doctor_s_NHS_NoTextBox.TabIndex = 16;
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
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "GP Appointment";
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
            this.panel2.Location = new System.Drawing.Point(17, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 46);
            this.panel2.TabIndex = 38;
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
            this.panel1.Controls.Add(this.gP_AppointmentDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 283);
            this.panel1.TabIndex = 37;
            // 
            // gP_AppointmentDataGridView
            // 
            this.gP_AppointmentDataGridView.AutoGenerateColumns = false;
            this.gP_AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gP_AppointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gP_AppointmentDataGridView.DataSource = this.gP_AppointmentBindingSource;
            this.gP_AppointmentDataGridView.Location = new System.Drawing.Point(3, 3);
            this.gP_AppointmentDataGridView.Name = "gP_AppointmentDataGridView";
            this.gP_AppointmentDataGridView.Size = new System.Drawing.Size(742, 273);
            this.gP_AppointmentDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn1.HeaderText = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Patient NHS Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient NHS Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EMIS Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "EMIS Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GP Appointment";
            this.dataGridViewTextBoxColumn4.HeaderText = "GP Appointment";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Patient Full Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Patient Full Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Patient ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Medical Centre Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Medical Centre Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Doctor\'s NHS No";
            this.dataGridViewTextBoxColumn8.HeaderText = "Doctor\'s NHS No";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(gP_Appointment_RefLabel);
            this.Controls.Add(this.gP_Appointment_RefTextBox);
            this.Controls.Add(patient_NHS_NumberLabel);
            this.Controls.Add(this.patient_NHS_NumberTextBox);
            this.Controls.Add(eMIS_NumberLabel);
            this.Controls.Add(this.eMIS_NumberTextBox);
            this.Controls.Add(gP_AppointmentLabel);
            this.Controls.Add(this.gP_AppointmentTextBox);
            this.Controls.Add(patient_Full_NameLabel);
            this.Controls.Add(this.patient_Full_NameTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(medical_Centre_NameLabel);
            this.Controls.Add(this.medical_Centre_NameTextBox);
            this.Controls.Add(doctor_s_NHS_NoLabel);
            this.Controls.Add(this.doctor_s_NHS_NoTextBox);
            this.Controls.Add(this.gP_AppointmentBindingNavigator);
            this.Name = "Form3";
            this.Text = "GP Appointment";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingNavigator)).EndInit();
            this.gP_AppointmentBindingNavigator.ResumeLayout(false);
            this.gP_AppointmentBindingNavigator.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource gP_AppointmentBindingSource;
        private PharmacyDataSetTableAdapters.GP_AppointmentTableAdapter gP_AppointmentTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gP_AppointmentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gP_AppointmentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox gP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox eMIS_NumberTextBox;
        private System.Windows.Forms.TextBox gP_AppointmentTextBox;
        private System.Windows.Forms.TextBox patient_Full_NameTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.TextBox medical_Centre_NameTextBox;
        private System.Windows.Forms.TextBox doctor_s_NHS_NoTextBox;
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
        private System.Windows.Forms.DataGridView gP_AppointmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}