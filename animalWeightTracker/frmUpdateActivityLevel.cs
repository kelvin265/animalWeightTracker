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
    public partial class frmUpdateActivityLevel : Form
    {
        public int animalId,animalActivityId;
        database db = new database();
        Activity activity = new Activity();
        public frmUpdateActivityLevel()
        {
            InitializeComponent();
        }

        private void FrmUpdateActivityLevel_Load(object sender, EventArgs e)
        {
            animalId = frmAnimal.animalId;
            animalActivityId = frmAnimal.animalActivityId;
            selectAnimalName();
            selectAnimalActivity();
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
            if (cmbActivity.Text != "")
            {
                if (activity.modifyActivitylLevel(animalActivityId,animalId, cmbActivity.Text))
                {
                    MessageBox.Show("activity level updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("failed to update activity level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please choose activity level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void selectAnimalActivity()
        {
            string query = "select activityLevel from activity where Id=" + animalActivityId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbActivity.Text = ds.Tables[0].Rows[0][0].ToString();

            }
        }
    }
}
