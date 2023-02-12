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
    public partial class frmAddAnimalExercise : Form
    {
        public static int animalId;
        database db = new database();
        List<int> exerciseIds = new List<int>();
        Animal animal = new Animal();
        int exerciseId;
        public frmAddAnimalExercise()
        {
            InitializeComponent();
        }

        private void FrmAddAnimalExercise_Load(object sender, EventArgs e)
        {
            animalId = frmAnimal.animalId;
            selectAnimalName();
            selectExercises();
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

        void selectExercises()
        {
            string query = "select * from exercise";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbExercise.Items.Add(dr.ItemArray.GetValue(1));
                    exerciseIds.Add(int.Parse(dr.ItemArray.GetValue(0).ToString()));
                }

            }
        }

        private void CmbExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            exerciseId = exerciseIds[cmbExercise.SelectedIndex];
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtMinutes.Text != "" && cmbExercise.Text != "")
            {
                if (animal.addAnimalExercise(exerciseId,animalId,Convert.ToDouble(txtMinutes.Text)))
                {
                    MessageBox.Show("Animal exercise added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add animal exercise ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
