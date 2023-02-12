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
    public partial class frmUpdateAnimalMeasurement : Form
    {
        public int animalId, measurementId;
        database db = new database();
        Measurement measurement = new Measurement();
        public frmUpdateAnimalMeasurement()
        {
            InitializeComponent();
        }

        private void FrmUpdateAnimalMeasurement_Load(object sender, EventArgs e)
        {
            animalId = frmAnimal.animalId;
            measurementId = frmAnimal.animalMeasurementId;
            selectAnimalName();
            selectAnimalMeasurement();
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
            if (txtMeasurement.Text != "" && cmbDayTime.Text != "" && cmbMeasurement.Text != "")
            {
                if (measurement.modifyMeasurement(measurementId,animalId, cmbMeasurement.Text, Convert.ToDouble(txtMeasurement.Text), cmbDayTime.Text))
                {
                    MessageBox.Show("measurement modified succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("measurement not modified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void selectAnimalMeasurement()
        {
            string query = "select * from animalMeasurement where Id = " + measurementId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                cmbMeasurement.Text = dr.ItemArray.GetValue(2).ToString();
                txtMeasurement.Text = dr.ItemArray.GetValue(3).ToString();
                cmbDayTime.Text = dr.ItemArray.GetValue(4).ToString();
            }
        
        }
    }
}
