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
    public partial class frmUpdateExercise : Form
    {
        int Id;
        database db = new database();
        Exercise exercise = new Exercise();
        public frmUpdateExercise()
        {
            InitializeComponent();
        }

        private void FrmUpdateExercise_Load(object sender, EventArgs e)
        {
            Id = frmMain.ExerciseId;
            selectExercise();
        }
        private void selectExercise()
        {
            string query = "select * from exercise where id = " + Id + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtType.Text = dr.ItemArray.GetValue(1).ToString();
                txtCalorieValue.Text = dr.ItemArray.GetValue(2).ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCalorieValue.Text != "" && txtType.Text != "")
            {
                if (exercise.updateExercise(Id,txtType.Text,Convert.ToDouble(txtCalorieValue.Text)))
                {
                    MessageBox.Show("Exercise updated succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
