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
    public partial class frmUpdateMeal : Form
    {
        int Id;
        Meal meal = new Meal();
        database db = new database();
        public frmUpdateMeal()
        {
            InitializeComponent();
        }

        private void FrmUpdateMeal_Load(object sender, EventArgs e)
        {
            Id = frmMain.MealId;
            selectMeal();
        }
        private void selectMeal()
        {
            string query = "select * from meal where id = " + Id + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtName.Text = dr.ItemArray.GetValue(1).ToString();
                txtCalorieValue.Text = dr.ItemArray.GetValue(2).ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCalorieValue.Text != "" && txtName.Text != "")
            {
                if (meal.updateMeal(Id,txtName.Text,Convert.ToDouble(txtCalorieValue.Text)))
                {
                    MessageBox.Show("Meal updated succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
