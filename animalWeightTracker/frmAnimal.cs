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
    public partial class frmAnimal : Form
    {
        public static int animalId, animalMealId, animalExerciseId, animalMeasurementId, animalActivityId;
        database db = new database();
        Animal animal = new Animal();
        Measurement measurement = new Measurement();
        string date;
        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
        }
        public frmAnimal()
        {
            InitializeComponent();
        }

        private void BtnAddMeal_Click(object sender, EventArgs e)
        {
            frmAddAnimalMeal frm = new frmAddAnimalMeal();
            frm.Show();
        }

        private void FrmAnimal_Load(object sender, EventArgs e)
        {
            date = DateFormatFixing(DateTime.Today.ToShortDateString());
            animalId = frmMain.AnimalId;
            selectAnimalName();
            selectAnimalMeals();
            selectAnimalExercise();
            selectAnimalMeasurement();
            selectAnimalActivity();
            calculateWeight();
            calculateWaist();
        }
        void selectAnimalName()
        {
            string query = "select name from animal where Id=" + animalId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblAnimalExercise.Text = ds.Tables[0].Rows[0][0].ToString();
                lblAnimalMeal.Text = ds.Tables[0].Rows[0][0].ToString();
                lblAnimalMeasurement.Text = ds.Tables[0].Rows[0][0].ToString();
            }
        }

        void selectAnimalMeals()
        {
            string query = "select animalMealId x, name m, calorieValue m, gramsFed x, dayTime x from meal m, animalMeal x where x.animalId = "+animalId+" and m.Id = x.mealId and x.date='"+date+"'";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewMeals.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridViewMeals.Rows.Add();
                    dataGridViewMeals.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridViewMeals.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(1).ToString();
                    dataGridViewMeals.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(2).ToString();
                    double x = Convert.ToDouble(dr.ItemArray.GetValue(2).ToString());
                    dataGridViewMeals.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(3).ToString();
                    double y = Convert.ToDouble(dr.ItemArray.GetValue(3).ToString());

                    dataGridViewMeals.Rows[n].Cells[4].Value = (x * y).ToString();
                    dataGridViewMeals.Rows[n].Cells[5].Value = dr.ItemArray.GetValue(4).ToString();
                }

            }
        }
        void selectAnimalActivity()
        {
            string query = "select * from activity where animalId = " + animalId + " and date='"+date+"'";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewActivity.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridViewActivity.Rows.Add();
                    dataGridViewActivity.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridViewActivity.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(2).ToString();

                }

            }
        }
        void selectAnimalMeasurement()
        {
            string query = "select * from animalMeasurement where animalId = " + animalId + " and date='"+date+"'";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewMeasurement.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridViewMeasurement.Rows.Add();
                    dataGridViewMeasurement.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridViewMeasurement.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(2).ToString();
                    dataGridViewMeasurement.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(3).ToString();
                    dataGridViewMeasurement.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(4).ToString();

                }

            }
        }
        void selectAnimalExercise()
        {
            string query = "select animalExerciseId x, type m, calorieValue m, minutesSpent x from exercise m, animalExercise x where x.animalId = " + animalId + " and m.Id = x.exerciseId and x.date='"+date+"'";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewExercise.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridViewExercise.Rows.Add();
                    dataGridViewExercise.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridViewExercise.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(1).ToString();
                    dataGridViewExercise.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(2).ToString();
                    double x = Convert.ToDouble(dr.ItemArray.GetValue(2).ToString());
                    dataGridViewExercise.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(3).ToString();
                    double y = Convert.ToDouble(dr.ItemArray.GetValue(3).ToString());

                    dataGridViewExercise.Rows[n].Cells[4].Value = (x * y).ToString();
                }

            }
        }
        void calculateWeight()
        {
            double number = 0;
            double weight = 0;
            int count = dataGridViewMeasurement.Rows.Count;
            if ( count > 0)
            {
                for(int i = 0; i<count; i++)
                {
                    if(dataGridViewMeasurement.Rows[i].Cells[1].Value.ToString() == "Weight")
                    {
                        weight += Convert.ToDouble(dataGridViewMeasurement.Rows[i].Cells[2].Value.ToString());
                        number += 1;
                    }
                }
                lblWeight.Text = (weight / number).ToString();
            }

        }
        void calculateWaist()
        {
            double number = 0;
            double waist = 0;
            int count = dataGridViewMeasurement.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewMeasurement.Rows[i].Cells[1].Value.ToString() == "Waist")
                    {
                        waist += Convert.ToDouble(dataGridViewMeasurement.Rows[i].Cells[2].Value.ToString());
                        number += 1;
                    }
                }
                lblWaist.Text = (waist / number).ToString();
            }
            
        }
        private void BtnRefreshExercise_Click(object sender, EventArgs e)
        {
            selectAnimalExercise();
        }

        private void BtnAddExercise_Click(object sender, EventArgs e)
        {
            frmAddAnimalExercise frm = new frmAddAnimalExercise();
            frm.Show();
        }

        private void BtnUpdateExercise_Click(object sender, EventArgs e)
        {
            int count = dataGridViewExercise.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewExercise.Rows[i].Cells[5].Value != null)
                    {
                        items += 1;
                        if (items < 2)
                        {
                            animalExerciseId = int.Parse(dataGridViewExercise.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one exercise only to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            selectAnimalExercise();
                            return;
                        }
                    }
                    else if (i == count - 1)
                    {
                        if (items == 0)
                        {
                            MessageBox.Show("please select the exercise to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            selectAnimalExercise();
                            return;
                        }
                    }

                }
                frmUpdateAnimalExercise frm = new frmUpdateAnimalExercise();
                frm.Show();
            }
        }

        private void BtnDeleteExercise_Click(object sender, EventArgs e)
        {
            int count = dataGridViewExercise.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewExercise.Rows[i].Cells[5].Value != null)
                    {
                        animalExerciseId = int.Parse(dataGridViewExercise.Rows[i].Cells[0].Value.ToString());
                        animal.deleteAnimalExercise(animalExerciseId);
                    }
                }
                dataGridViewExercise.Rows.Clear();
                selectAnimalExercise();
            }
        }

        private void BtnRefreshAnimalMeasurement_Click(object sender, EventArgs e)
        {
            selectAnimalMeasurement();
            calculateWeight();
            calculateWaist();
        }

        private void BtnAddAnimalMeasurement_Click(object sender, EventArgs e)
        {
            frmAddAnimalMeasurement frm = new frmAddAnimalMeasurement();
            frm.Show();
        }

        private void BtnUpdateAnimalMeasurement_Click(object sender, EventArgs e)
        {
            int count = dataGridViewMeasurement.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewMeasurement.Rows[i].Cells[4].Value != null)
                    {
                        items += 1;
                        if (items < 2)
                        {
                            animalMeasurementId = int.Parse(dataGridViewMeasurement.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one Measurement only to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            selectAnimalExercise();
                            return;
                        }
                    }
                    else if (i == count - 1)
                    {
                        if (items == 0)
                        {
                            MessageBox.Show("please select the Measurement to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            selectAnimalExercise();
                            return;
                        }
                    }

                }
                frmUpdateAnimalMeasurement frm = new frmUpdateAnimalMeasurement();
                frm.Show();
            }
        }

        private void BtnDeleteAnimalMeasurement_Click(object sender, EventArgs e)
        {
            int count = dataGridViewMeasurement.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewMeasurement.Rows[i].Cells[4].Value != null)
                    {
                        animalMeasurementId = int.Parse(dataGridViewMeasurement.Rows[i].Cells[0].Value.ToString());
                        measurement.deleteMeasurement(animalMeasurementId);


                    }
                }
                dataGridViewMeasurement.Rows.Clear();
                selectAnimalMeasurement();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int count = dataGridViewActivity.Rows.Count;
            if(count < 1)
            {
                frmAddActivityLevel frm = new frmAddActivityLevel();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Activity level already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int count = dataGridViewActivity.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewActivity.Rows[i].Cells[2].Value != null)
                    {
                        items += 1;
                        if (items < 2)
                        {
                            animalActivityId = int.Parse(dataGridViewActivity.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one Activity only to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            selectAnimalActivity();
                            return;
                        }
                    }
                    else if (i == count - 1)
                    {
                        if (items == 0)
                        {
                            MessageBox.Show("please select the Activity to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            selectAnimalActivity();
                            return;
                        }
                    }

                }
                frmUpdateActivityLevel frm = new frmUpdateActivityLevel();
                frm.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            selectAnimalActivity();
        }

        private void BtnRefreshMeals_Click(object sender, EventArgs e)
        {
            selectAnimalMeals();
        }

        private void BtnDeleteMeal_Click(object sender, EventArgs e)
        {
            int count = dataGridViewMeals.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewMeals.Rows[i].Cells[6].Value != null)
                    {
                        animalMealId = int.Parse(dataGridViewMeals.Rows[i].Cells[0].Value.ToString());
                        animal.deleteAnimalMeal(animalMealId);
                    }
                }
                dataGridViewMeals.Rows.Clear();
                selectAnimalMeals();
            }
        }

        private void BtnUpdateMeal_Click(object sender, EventArgs e)
        {
            int count = dataGridViewMeals.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewMeals.Rows[i].Cells[6].Value != null)
                    {
                        items += 1;
                        if (items < 2)
                        {
                            animalMealId = int.Parse(dataGridViewMeals.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one meal only to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            selectAnimalMeals();
                            return;
                        }
                    }
                    else if (i == count - 1)
                    {
                        if (items == 0)
                        {
                            MessageBox.Show("please select the meal to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            selectAnimalMeals();
                            return;
                        }
                    }

                }
                frmUpdateAnimalMeal frm = new frmUpdateAnimalMeal();
                frm.Show();
            }
        }
    }
}
