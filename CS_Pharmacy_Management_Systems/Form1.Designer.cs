namespace CS_Pharmacy_Management_Systems
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_PharmacyOffice = new System.Windows.Forms.Button();
            this.btn_Pharmacy = new System.Windows.Forms.Button();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.btn_Patient = new System.Windows.Forms.Button();
            this.btn_GP = new System.Windows.Forms.Button();
            this.btn_Doctor = new System.Windows.Forms.Button();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_PharmacircleFirms = new System.Windows.Forms.Button();
            this.btn_Pharmacist = new System.Windows.Forms.Button();
            this.btn_Consaltant = new System.Windows.Forms.Button();
            this.btn_Specialist = new System.Windows.Forms.Button();
            this.btn_Hospital = new System.Windows.Forms.Button();
            this.btn_Surgery = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_Password);
            this.panel1.Controls.Add(this.label_Username);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Location = new System.Drawing.Point(281, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 402);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(89, 180);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(128, 29);
            this.label_Password.TabIndex = 6;
            this.label_Password.Text = "Password";
            this.label_Password.Click += new System.EventHandler(this.label_Password_Click);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(89, 82);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(132, 29);
            this.label_Username.TabIndex = 5;
            this.label_Username.Text = "Username";
            this.label_Username.Click += new System.EventHandler(this.label_Username_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(286, 177);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(250, 32);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(286, 82);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(250, 32);
            this.txt_Username.TabIndex = 3;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(94, 300);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(172, 41);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Log in";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(364, 300);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(172, 41);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(52, 503);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(172, 41);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_PharmacyOffice
            // 
            this.btn_PharmacyOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PharmacyOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PharmacyOffice.Location = new System.Drawing.Point(52, 442);
            this.btn_PharmacyOffice.Name = "btn_PharmacyOffice";
            this.btn_PharmacyOffice.Size = new System.Drawing.Size(172, 41);
            this.btn_PharmacyOffice.TabIndex = 10;
            this.btn_PharmacyOffice.Text = "Pharmacy Office";
            this.btn_PharmacyOffice.UseVisualStyleBackColor = true;
            this.btn_PharmacyOffice.Click += new System.EventHandler(this.btn_PharmacyOffice_Click);
            // 
            // btn_Pharmacy
            // 
            this.btn_Pharmacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pharmacy.Location = new System.Drawing.Point(52, 381);
            this.btn_Pharmacy.Name = "btn_Pharmacy";
            this.btn_Pharmacy.Size = new System.Drawing.Size(172, 41);
            this.btn_Pharmacy.TabIndex = 11;
            this.btn_Pharmacy.Text = "Pharmacy";
            this.btn_Pharmacy.UseVisualStyleBackColor = true;
            this.btn_Pharmacy.Click += new System.EventHandler(this.btn_Pharmacy_Click);
            // 
            // btn_Payment
            // 
            this.btn_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Payment.Location = new System.Drawing.Point(52, 319);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(172, 41);
            this.btn_Payment.TabIndex = 12;
            this.btn_Payment.Text = "Payment";
            this.btn_Payment.UseVisualStyleBackColor = true;
            this.btn_Payment.Click += new System.EventHandler(this.btn_Payment_Click);
            // 
            // btn_Patient
            // 
            this.btn_Patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patient.Location = new System.Drawing.Point(52, 259);
            this.btn_Patient.Name = "btn_Patient";
            this.btn_Patient.Size = new System.Drawing.Size(172, 41);
            this.btn_Patient.TabIndex = 13;
            this.btn_Patient.Text = "Patient";
            this.btn_Patient.UseVisualStyleBackColor = true;
            this.btn_Patient.Click += new System.EventHandler(this.btn_Patient_Click);
            // 
            // btn_GP
            // 
            this.btn_GP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GP.Location = new System.Drawing.Point(52, 199);
            this.btn_GP.Name = "btn_GP";
            this.btn_GP.Size = new System.Drawing.Size(172, 41);
            this.btn_GP.TabIndex = 14;
            this.btn_GP.Text = "GP Appointment";
            this.btn_GP.UseVisualStyleBackColor = true;
            this.btn_GP.Click += new System.EventHandler(this.btn_GP_Click);
            // 
            // btn_Doctor
            // 
            this.btn_Doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Doctor.Location = new System.Drawing.Point(52, 140);
            this.btn_Doctor.Name = "btn_Doctor";
            this.btn_Doctor.Size = new System.Drawing.Size(172, 41);
            this.btn_Doctor.TabIndex = 15;
            this.btn_Doctor.Text = "Doctor";
            this.btn_Doctor.UseVisualStyleBackColor = true;
            this.btn_Doctor.Click += new System.EventHandler(this.btn_Doctor_Click);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Title.Controls.Add(this.label_Title);
            this.panel_Title.Location = new System.Drawing.Point(12, 12);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1160, 77);
            this.panel_Title.TabIndex = 16;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Title.Location = new System.Drawing.Point(217, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(735, 55);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Pharmacy Management System";
            // 
            // btn_Help
            // 
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.Location = new System.Drawing.Point(960, 503);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(172, 41);
            this.btn_Help.TabIndex = 17;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // btn_PharmacircleFirms
            // 
            this.btn_PharmacircleFirms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PharmacircleFirms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PharmacircleFirms.Location = new System.Drawing.Point(960, 442);
            this.btn_PharmacircleFirms.Name = "btn_PharmacircleFirms";
            this.btn_PharmacircleFirms.Size = new System.Drawing.Size(172, 41);
            this.btn_PharmacircleFirms.TabIndex = 18;
            this.btn_PharmacircleFirms.Text = "Pharmacircle Firms";
            this.btn_PharmacircleFirms.UseVisualStyleBackColor = true;
            // 
            // btn_Pharmacist
            // 
            this.btn_Pharmacist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pharmacist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pharmacist.Location = new System.Drawing.Point(960, 381);
            this.btn_Pharmacist.Name = "btn_Pharmacist";
            this.btn_Pharmacist.Size = new System.Drawing.Size(172, 41);
            this.btn_Pharmacist.TabIndex = 19;
            this.btn_Pharmacist.Text = "Pharmacist";
            this.btn_Pharmacist.UseVisualStyleBackColor = true;
            // 
            // btn_Consaltant
            // 
            this.btn_Consaltant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consaltant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consaltant.Location = new System.Drawing.Point(960, 319);
            this.btn_Consaltant.Name = "btn_Consaltant";
            this.btn_Consaltant.Size = new System.Drawing.Size(172, 41);
            this.btn_Consaltant.TabIndex = 20;
            this.btn_Consaltant.Text = "Consaltant";
            this.btn_Consaltant.UseVisualStyleBackColor = true;
            // 
            // btn_Specialist
            // 
            this.btn_Specialist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Specialist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Specialist.Location = new System.Drawing.Point(960, 259);
            this.btn_Specialist.Name = "btn_Specialist";
            this.btn_Specialist.Size = new System.Drawing.Size(172, 41);
            this.btn_Specialist.TabIndex = 21;
            this.btn_Specialist.Text = "Specialist";
            this.btn_Specialist.UseVisualStyleBackColor = true;
            // 
            // btn_Hospital
            // 
            this.btn_Hospital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hospital.Location = new System.Drawing.Point(960, 199);
            this.btn_Hospital.Name = "btn_Hospital";
            this.btn_Hospital.Size = new System.Drawing.Size(172, 41);
            this.btn_Hospital.TabIndex = 22;
            this.btn_Hospital.Text = "Hospital";
            this.btn_Hospital.UseVisualStyleBackColor = true;
            // 
            // btn_Surgery
            // 
            this.btn_Surgery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Surgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Surgery.Location = new System.Drawing.Point(960, 140);
            this.btn_Surgery.Name = "btn_Surgery";
            this.btn_Surgery.Size = new System.Drawing.Size(172, 41);
            this.btn_Surgery.TabIndex = 23;
            this.btn_Surgery.Text = "Surgery";
            this.btn_Surgery.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Logout.Location = new System.Drawing.Point(533, 548);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(127, 41);
            this.btn_Logout.TabIndex = 17;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_PharmacircleFirms);
            this.Controls.Add(this.btn_Pharmacist);
            this.Controls.Add(this.btn_Consaltant);
            this.Controls.Add(this.btn_Specialist);
            this.Controls.Add(this.btn_Hospital);
            this.Controls.Add(this.btn_Surgery);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_PharmacyOffice);
            this.Controls.Add(this.btn_Pharmacy);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.btn_Patient);
            this.Controls.Add(this.btn_GP);
            this.Controls.Add(this.btn_Doctor);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_PharmacyOffice;
        private System.Windows.Forms.Button btn_Pharmacy;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.Button btn_Patient;
        private System.Windows.Forms.Button btn_GP;
        private System.Windows.Forms.Button btn_Doctor;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_PharmacircleFirms;
        private System.Windows.Forms.Button btn_Pharmacist;
        private System.Windows.Forms.Button btn_Consaltant;
        private System.Windows.Forms.Button btn_Specialist;
        private System.Windows.Forms.Button btn_Hospital;
        private System.Windows.Forms.Button btn_Surgery;
        private System.Windows.Forms.Button btn_Logout;
    }
}

