using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Pharmacy_Management_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Doctor.Enabled = false;
            btn_GP.Enabled = false;
            btn_Patient.Enabled = false;
            btn_Payment.Enabled = false;
            btn_Pharmacy.Enabled = false;
            btn_PharmacyOffice.Enabled = false;

            btn_Surgery.Enabled = false;
            btn_Hospital.Enabled = false;
            btn_Specialist.Enabled = false; 
            btn_Consaltant.Enabled = false;
            btn_Pharmacist.Enabled = false;
            btn_PharmacircleFirms.Enabled = false;
            btn_Help.Enabled = false;
        }



        private void btn_Doctor_Click(object sender, EventArgs e)
        {
            Form2 Doctor = new Form2();
            Doctor.Show();
        }

        private void btn_GP_Click(object sender, EventArgs e)
        {
            Form3 GP = new Form3();
            GP.Show();
        }

        private void btn_Patient_Click(object sender, EventArgs e)
        {
            Form4 Patient = new Form4();
            Patient.Show();
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            Form5 Payment = new Form5();
            Payment.Show();
        }

        private void btn_Pharmacy_Click(object sender, EventArgs e)
        {
            Form6 Pharmacy = new Form6();
            Pharmacy.Show();
        }

        private void btn_PharmacyOffice_Click(object sender, EventArgs e)
        {
            Form7 Pharmacy_Office = new Form7();
            Pharmacy_Office.Show();
        }



        //-------------------- Login Panel --------------------

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label_Username_Click(object sender, EventArgs e)
        {

        }

        private void label_Password_Click(object sender, EventArgs e)
        {

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_Username.Text == "manager" && txt_Password.Text == "1111")
            {
                btn_Doctor.Enabled = true;
                btn_GP.Enabled = true;
                btn_Patient.Enabled = true;
                btn_Payment.Enabled = true;
                btn_Pharmacy.Enabled = true;
                btn_PharmacyOffice.Enabled = true;

                btn_Surgery.Enabled = true;
                btn_Hospital.Enabled = true;
                btn_Specialist.Enabled = true;
                btn_Consaltant.Enabled = true;
                btn_Pharmacist.Enabled = true;
                btn_PharmacircleFirms.Enabled = true;
                btn_Help.Enabled = true;

                MessageBox.Show("Welcome to Pharmacy Management System.", "Pharmacy Management System");

                txt_Username.Clear();
                txt_Password.Clear();
            }
            else if (txt_Username.Text == "admin" && txt_Password.Text == "2222")
            {
                btn_Doctor.Enabled = true;
                btn_GP.Enabled = true;
                btn_Patient.Enabled = true;
                btn_Payment.Enabled = true;
                btn_Pharmacy.Enabled = true;
                btn_PharmacyOffice.Enabled = true;

                btn_Surgery.Enabled = true;
                btn_Hospital.Enabled = true;
                btn_Specialist.Enabled = true;
                btn_Consaltant.Enabled = true;
                btn_Pharmacist.Enabled = true;
                btn_PharmacircleFirms.Enabled = true;
                btn_Help.Enabled = true;

                MessageBox.Show("Welcome to Pharmacy Management System.", "Pharmacy Management System");

                txt_Username.Clear();
                txt_Password.Clear();
            }
            else if (txt_Username.Text == "recieptionist" && txt_Password.Text == "3333")
            {
                btn_Doctor.Enabled = true;
                btn_GP.Enabled = true;
                btn_Patient.Enabled = true;
                btn_Payment.Enabled = true;
                btn_Pharmacy.Enabled = true;
                btn_PharmacyOffice.Enabled = true;

                btn_Surgery.Enabled = true;
                btn_Hospital.Enabled = true;
                btn_Specialist.Enabled = true;
                btn_Consaltant.Enabled = true;
                btn_Pharmacist.Enabled = true;
                btn_PharmacircleFirms.Enabled = true;
                btn_Help.Enabled = true;

                MessageBox.Show("Welcome to Pharmacy Management System.", "Pharmacy Management System");

                txt_Username.Clear();
                txt_Password.Clear();
            } 
            else if (txt_Username.Text == "" && txt_Password.Text == "")
            {
                MessageBox.Show("Please Enter Login Information.", "Pharmacy Management System");

                txt_Username.Focus();
            }
            else
            {
                txt_Password.Clear();

                MessageBox.Show("Please insert Correct Username and Password.", "Pharmacy Management System");

                txt_Username.Focus();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
            txt_Password.Clear();

            txt_Username.Focus();
        }



        //-------------------- Exit --------------------

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm , If you want to Exit.", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
            txt_Password.Clear();

            btn_Doctor.Enabled = false;
            btn_GP.Enabled = false;
            btn_Patient.Enabled = false;
            btn_Payment.Enabled = false;
            btn_Pharmacy.Enabled = false;
            btn_PharmacyOffice.Enabled = false;

            btn_Surgery.Enabled = false;
            btn_Hospital.Enabled = false;
            btn_Specialist.Enabled = false;
            btn_Consaltant.Enabled = false;
            btn_Pharmacist.Enabled = false;
            btn_PharmacircleFirms.Enabled = false;
            btn_Help.Enabled = false;
        }
    }
}
