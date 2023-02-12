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
    
    public partial class frmAddAnimalMeal : Form
    {
        public static int animalId ;
        database db = new database();
        List<int> mealIds = new List<int>();
        Animal animal = new Animal();
        int mealId;
        public frmAddAnimalMeal()
        {
            InitializeComponent();
        }

        private void FrmAddAnimalMeal_Load(object sender, EventArgs e)
        {
            animalId = frmAnimal.animalId;
            selectAnimalName();
            selectMeals();
        }
        void selectAnimalName()
        {
            string query = "select name from animal where Id=" + animalId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblAnimalName.Text = ds.Tables[0].Rows[0][0].ToString();
               
            }
        }
        void selectMeals()
        {
            string query = "select * from meal";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbMeals.Items.Add(dr.ItemArray.GetValue(1));
                    mealIds.Add(int.Parse(dr.ItemArray.GetValue(0).ToString()));
                }

            }
        }

        private void CmbMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            mealId = mealIds[cmbMeals.SelectedIndex];
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(txtGrams.Text != "" && cmbMeals.Text != "" && cmbDayTime.Text != "")
            {
                if (animal.addAnimalMeal(mealId, animalId, Convert.ToDouble(txtGrams.Text), cmbDayTime.Text))
                {
                    MessageBox.Show("Animal meal added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add animal meal ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please fill all empty fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
