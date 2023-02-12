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
    public partial class frmMain : Form
    {
        database db = new database();
        public static  int StaffId,AnimalId,MealId,ExerciseId;
        Staff staff = new Staff();
        Animal animal = new Animal();
        Meal meal = new Meal();
        Exercise exercise = new Exercise();
        public frmMain()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        //viewAvailable
        void viewStaff()
        {
            string query = "select * from staff";
            DataSet ds = db.select(query);
            if(ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewStaff.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridViewStaff.Rows.Add();
                    dataGridViewStaff.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridViewStaff.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(1).ToString();
                    dataGridViewStaff.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(3).ToString();
                    dataGridViewStaff.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(4).ToString();
                    dataGridViewStaff.Rows[n].Cells[4].Value = dr.ItemArray.GetValue(5).ToString();
                }
            }
        }
        void viewAnimals()
        {
            string query = "select * from animal";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewAnimal.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridViewAnimal.Rows.Add();
                    dataGridViewAnimal.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridViewAnimal.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(1).ToString();
                    dataGridViewAnimal.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(2).ToString();
                    dataGridViewAnimal.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(3).ToString();
                    dataGridViewAnimal.Rows[n].Cells[4].Value = dr.ItemArray.GetValue(4).ToString();
                }
            }
        }
        void viewMeals()
        {
            string query = "select * from meal";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridViewMeal.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridViewMeal.Rows.Add();
                    dataGridViewMeal.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridViewMeal.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(1).ToString();
                    dataGridViewMeal.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(2).ToString();
                }
            }
        }
        void viewExercises()
        {
            string query = "select * from exercise";
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
                }
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            viewStaff();
            viewAnimals();
            viewMeals();
            viewExercises();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmAddStaff frm = new frmAddStaff();
            frm.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            viewStaff();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int count = dataGridViewStaff.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewStaff.Rows[i].Cells[5].Value != null)
                    {
                        items += 1;
                        if (items < 2)
                        {
                            StaffId = int.Parse(dataGridViewStaff.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one staff member only to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewStaff();
                            return;
                        }
                    }
                    else if (i == count - 1)
                    {
                        if (items == 0)
                        {
                            MessageBox.Show("please select the member to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewStaff();
                            return;
                        }
                    }

                }
                frmUpdateStaff frm = new frmUpdateStaff();
                frm.Show();
            }
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            frmAddAnimal frm = new frmAddAnimal();
            frm.Show();
        }

        private void BtnRefreshAnimal_Click(object sender, EventArgs e)
        {
            viewAnimals();
        }

        private void BtnUpdateAnimal_Click(object sender, EventArgs e)
        {
            int count = dataGridViewAnimal.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewAnimal.Rows[i].Cells[5].Value != null)
                    {
                        items += 1;
                        if (items < 2)
                        {
                            AnimalId = int.Parse(dataGridViewAnimal.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one animal only to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewAnimals();
                            return;
                        }
                    }
                    else if (i == count - 1)
                    {
                        if (items == 0)
                        {
                            MessageBox.Show("please select the animal to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewAnimals();
                            return;
                        }
                    }

                }
                frmUpdateAnimal frm = new frmUpdateAnimal();
                frm.Show();
            }
        }

        private void BtnDeleteAnimal_Click(object sender, EventArgs e)
        {
            int count = dataGridViewAnimal.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewAnimal.Rows[i].Cells[5].Value != null)
                    {
                        string name = dataGridViewAnimal.Rows[i].Cells[2].Value.ToString();
                        if (MessageBox.Show("Are you sure you want to delete the animal '"+ name + "'?") == DialogResult.OK)
                        {
                            AnimalId = int.Parse(dataGridViewAnimal.Rows[i].Cells[0].Value.ToString());
                            animal.deleteAnimal(AnimalId);
                        }
                        


                    }
                }
                dataGridViewAnimal.Rows.Clear();
                viewAnimals();
            }
        }

        private void BtnUpdateMeal_Click(object sender, EventArgs e)
        {
            int count = dataGridViewMeal.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewMeal.Rows[i].Cells[3].Value != null)
                    {
                        items += 1;
                        if (items < 2)
                        {
                            MealId = int.Parse(dataGridViewMeal.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one meal only to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewMeals();
                            return;
                        }
                    }
                    else if (i == count - 1)
                    {
                        if (items == 0)
                        {
                            MessageBox.Show("please select the meal to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewMeals();
                            return;
                        }
                    }

                }
                frmUpdateMeal frm = new frmUpdateMeal();
                frm.Show();
            }
        }

        private void BtnUpdateExercise_Click(object sender, EventArgs e)
        {
            int count = dataGridViewExercise.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewExercise.Rows[i].Cells[3].Value != null)
                    {
                        items += 1;
                        if (items < 2)
                        {
                            ExerciseId = int.Parse(dataGridViewExercise.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one exercise only to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewExercises();
                            return;
                        }
                    }
                    else if (i == count - 1)
                    {
                        if (items == 0)
                        {
                            MessageBox.Show("please select the exercise to update", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewExercises();
                            return;
                        }
                    }

                }
                frmUpdateExercise frm = new frmUpdateExercise();
                frm.Show();
            }
        }

        private void BtnAddExercise_Click(object sender, EventArgs e)
        {
            frmAddExercise frm = new frmAddExercise();
            frm.Show();
        }

        private void BtnAddMeal_Click(object sender, EventArgs e)
        {
            frmAddMeal frm = new frmAddMeal();
            frm.Show();
        }

        private void BtnDeleteMeal_Click(object sender, EventArgs e)
        {
            int count = dataGridViewMeal.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewMeal.Rows[i].Cells[3].Value != null)
                    {
                        MealId = int.Parse(dataGridViewMeal.Rows[i].Cells[0].Value.ToString());
                        meal.deleteMeal(MealId);


                    }
                }
                dataGridViewMeal.Rows.Clear();
                viewMeals();
            }
        }

        private void BtnDeleteExercise_Click(object sender, EventArgs e)
        {
            int count = dataGridViewExercise.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewExercise.Rows[i].Cells[3].Value != null)
                    {
                        ExerciseId = int.Parse(dataGridViewExercise.Rows[i].Cells[0].Value.ToString());
                        exercise.deleteExercise(ExerciseId);


                    }
                }
                dataGridViewExercise.Rows.Clear();
                viewExercises();
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            int count = dataGridViewAnimal.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewAnimal.Rows[i].Cells[5].Value != null)
                    {
                        AnimalId = int.Parse(dataGridViewAnimal.Rows[i].Cells[0].Value.ToString());

                        frmAnimal frm = new frmAnimal();
                        frm.Show();
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int count = dataGridViewAnimal.Rows.Count;
            int items = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewAnimal.Rows[i].Cells[5].Value != null)
                    {
                        items += 1;
                        if (items < 2)
                        {
                            AnimalId = int.Parse(dataGridViewAnimal.Rows[i].Cells[0].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("please select one animal only to view", "view info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewAnimals();
                            return;
                        }
                    }
                    else if (i == count - 1)
                    {
                        if (items == 0)
                        {
                            MessageBox.Show("please select the animal to view", "view info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            viewAnimals();
                            return;
                        }
                    }

                }
                frmAnimalProgress frm = new frmAnimalProgress();
                frm.Show();
            }
            
        }

        private void BtnRefreshMeals_Click(object sender, EventArgs e)
        {
            viewMeals();
        }

        private void BtnRefreshExercise_Click(object sender, EventArgs e)
        {
            viewExercises();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int count = dataGridViewStaff.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridViewStaff.Rows[i].Cells[5].Value != null)
                    {
                        StaffId = int.Parse(dataGridViewStaff.Rows[i].Cells[0].Value.ToString());
                        staff.DeleteStaff(StaffId);


                    }
                }
                dataGridViewStaff.Rows.Clear();
                viewStaff();
            }
        }
    }
}
