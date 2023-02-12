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
    public partial class frmUpdateAnimalMeal : Form
    {
        public static int animalId;
        database db = new database();
        List<int> mealIds = new List<int>();
        Animal animal = new Animal();
        int mealId;
        int animalMealId;
        public frmUpdateAnimalMeal()
        {
            InitializeComponent();
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
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtGrams.Text != "" && cmbMeals.Text != "" && cmbDayTime.Text != "")
            {
                if (animal.updateAnimalMeal(animalMealId,mealId,animalId,Convert.ToDouble(txtGrams.Text),cmbDayTime.Text))
                {
                    MessageBox.Show("Animal meal updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update animal meal ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please fill all empty fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void selectAnimalMeal()
        {
            string query = "select * from animalMeal where animalMealId = " + animalMealId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                mealId = int.Parse(dr.ItemArray.GetValue(2).ToString());
                txtGrams.Text = dr.ItemArray.GetValue(3).ToString();
                cmbDayTime.Text = dr.ItemArray.GetValue(5).ToString();
            }
        }
        private void selectMeal()
        {
            int index = 0;
            cmbMeals.Items.Clear();
            string query = "select * from meal";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    index += 1;
                    cmbMeals.Items.Add(dr[1].ToString());
                    mealIds.Add(int.Parse(dr[0].ToString()));
                    if (mealId == int.Parse(dr[0].ToString()))
                    {
                        cmbMeals.SelectedIndex = index - 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("no product has been added. Please add a new product first", "System error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void FrmUpdateAnimalMeal_Load(object sender, EventArgs e)
        {
            animalId = frmAnimal.animalId;
            animalMealId = frmAnimal.animalMealId;
            selectAnimalName();
            selectAnimalMeal();
            selectMeal();
        }

        private void CmbMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            mealId = mealIds[cmbMeals.SelectedIndex];
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
