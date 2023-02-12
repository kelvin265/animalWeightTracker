using animalWeightTracker.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalWeightTracker
{
    public partial class frmAddAnimal : Form
    {
        Animal animal = new Animal();
        public frmAddAnimal()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(txtSpecies.Text != "" && txtName.Text != "" && txtGender.Text != "" && txtAge.Text != "")
            {
                if (animal.addAnimal(txtSpecies.Text, txtName.Text, int.Parse(txtAge.Text), txtGender.Text))
                {
                    MessageBox.Show("Animal added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSpecies.Text = "";
                    txtAge.Text = "";
                    txtGender.Text = "";
                    txtName.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to add animal", "Insert error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please fill in all empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
