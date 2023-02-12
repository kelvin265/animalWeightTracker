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
    public partial class frmAddActivityLevel : Form
    {
        public int animalId;
        database db = new database();
        Activity activity = new Activity();
        public frmAddActivityLevel()
        {
            InitializeComponent();
        }

        private void FrmAddActivityLevel_Load(object sender, EventArgs e)
        {
            animalId = frmAnimal.animalId;
            selectAnimalName();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cmbActivity.Text != "")
            {
                if(activity.addActivitylLevel(animalId, cmbActivity.Text))
                {
                    MessageBox.Show("activity level set successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("failed to set activity level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
