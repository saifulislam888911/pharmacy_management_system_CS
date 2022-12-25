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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }




        //-------------------- Login Panel --------------------

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "manager" && txt_Password.Text == "1111")
            {
                MessageBox.Show("Welcome to Pharmacy Management System.", "Pharmacy Management System");

                txt_Username.Clear();
                txt_Password.Clear();

                Form1 Home_Page = new Form1();
                Home_Page.Show();
            }
            else if (txt_Username.Text == "admin" && txt_Password.Text == "2222")
            {
                MessageBox.Show("Welcome to Pharmacy Management System.", "Pharmacy Management System");

                txt_Username.Clear();
                txt_Password.Clear();

                Form1 Home_Page = new Form1();
                Home_Page.Show();
            }
            else if (txt_Username.Text == "recieptionist" && txt_Password.Text == "3333")
            {
                MessageBox.Show("Welcome to Pharmacy Management System.", "Pharmacy Management System");

                txt_Username.Clear();
                txt_Password.Clear();

                Form1 Home_Page = new Form1();
                Home_Page.Show();
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

      
        private void btn_Login_Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm , If you want to Exit.", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
