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
    public partial class frmUpdateAnimalExercise : Form
    {
        public int animalId, animalExerciseId;
        database db = new database();
        List<int> exerciseIds = new List<int>();
        Animal animal = new Animal();
        int exerciseId;
        public frmUpdateAnimalExercise()
        {
            InitializeComponent();
        }

        private void FrmUpdateAnimalExercise_Load(object sender, EventArgs e)
        {
            animalId = frmAnimal.animalId;
            animalExerciseId = frmAnimal.animalExerciseId;
            selectAnimalName();
            selectAnimalExercise();
            selectExercise();
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
        private void selectAnimalExercise()
        {
            string query = "select * from animalExercise where animalExerciseId = " + animalExerciseId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                exerciseId = int.Parse(dr.ItemArray.GetValue(2).ToString());
                txtMinutes.Text = dr.ItemArray.GetValue(3).ToString();
            }
        }

        private void CmbExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            exerciseId = exerciseIds[cmbExercise.SelectedIndex];
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtMinutes.Text != "" && cmbExercise.Text != "")
            {
                if (animal.updateAnimalExercise(animalExerciseId,exerciseId,animalId,Convert.ToDouble(txtMinutes.Text)))
                {
                    MessageBox.Show("Animal exercise updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update animal exercise ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please fill all empty fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectExercise()
        {
            int index = 0;
            cmbExercise.Items.Clear();
            string query = "select * from exercise";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    index += 1;
                    cmbExercise.Items.Add(dr[1].ToString());
                    exerciseIds.Add(int.Parse(dr[0].ToString()));
                    if (exerciseId == int.Parse(dr[0].ToString()))
                    {
                        cmbExercise.SelectedIndex = index - 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("no product has been added. Please add a new product first", "System error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
    }
}
