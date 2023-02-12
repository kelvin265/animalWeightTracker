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
    public partial class frmAddAnimalMeasurement : Form
    {
        public int animalId;
        database db = new database();
        Measurement measurement = new Measurement();
        public frmAddAnimalMeasurement()
        {
            InitializeComponent();
        }

        private void FrmAddAnimalMeasurement_Load(object sender, EventArgs e)
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
            if(txtMeasurement.Text != "" && cmbDayTime.Text != "" && cmbMeasurement.Text != "")
            {
                if(measurement.enterMeasurement(animalId, cmbMeasurement.Text,Convert.ToDouble(txtMeasurement.Text), cmbDayTime.Text))
                {
                    MessageBox.Show("measurement saved succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("measurement not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please fill all empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
