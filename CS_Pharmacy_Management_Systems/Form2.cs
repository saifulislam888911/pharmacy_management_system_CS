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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.pharmacyDataSet.Doctor);

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Are you want to Close this Page ?", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }



        //------------------- Crud Operation ----------------------------

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.AddNew();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.RemoveCurrent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.MoveNext();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.MovePrevious();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }
    }
}
