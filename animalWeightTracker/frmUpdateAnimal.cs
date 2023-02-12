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
    public partial class frmUpdateAnimal : Form
    {
        Animal animal = new Animal();
        database db = new database();
        int Id;
        public frmUpdateAnimal()
        {
            InitializeComponent();
        }

        private void FrmUpdateAnimal_Load(object sender, EventArgs e)
        {
            Id = frmMain.AnimalId;
            selectAnimals();
        }
        private void selectAnimals()
        {
            string query = "select * from animal where id = " + Id + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtSpecies.Text = dr.ItemArray.GetValue(1).ToString();
                txtName.Text = dr.ItemArray.GetValue(2).ToString();
                txtGender.Text = dr.ItemArray.GetValue(3).ToString();
                txtAge.Text = dr.ItemArray.GetValue(4).ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtSpecies.Text != "" && txtName.Text != "" && txtGender.Text != "" && txtAge.Text != "")
            {
                if (animal.updateAnimal(Id, txtSpecies.Text, txtName.Text, txtGender.Text, int.Parse(txtAge.Text))) { 
                    MessageBox.Show("Animal updated successfully", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update animal", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please fill in all empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
