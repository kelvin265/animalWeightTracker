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
    public partial class frmAddMeal : Form
    {
        Meal meal = new Meal();
        public frmAddMeal()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(txtCalorieValue.Text != "" && txtName.Text != "")
            {
                if (meal.addMeal(txtName.Text, Convert.ToDouble(txtCalorieValue.Text))){
                    MessageBox.Show("Details added succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCalorieValue.Text = "";
                    txtName.Text ="";
                }
            }
            else
            {
                MessageBox.Show("Please fill in all field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
