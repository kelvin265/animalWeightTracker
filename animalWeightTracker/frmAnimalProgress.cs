using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace animalWeightTracker
{
    public partial class frmAnimalProgress : Form
    {
        int animalId;
        database db = new database();
        dsWeight.WeightDataTable dt = new dsWeight.WeightDataTable();
        dsWeight.WeightRow dr;
        List<double> weights = new List<double>();
        List<string> dates = new List<string>();
        public frmAnimalProgress()
        {
            InitializeComponent();
        }

        private void FrmAnimalProgress_Load(object sender, EventArgs e)
        {
            
            animalId = frmMain.AnimalId;
            loadWeightDataIntoDatasetAndWeightDatagridview();
            loadDataOnChart();
            selectAnimalName();
            calculateWeightChange();
            lblAverage.Text = calculateAverageWeightLossOrGain().ToString();
        }

        void loadWeightDataIntoDatasetAndWeightDatagridview()
        {

            string type = "Weight";
            string  date;
            double weight;
            string query = "select measurement, date, dayTime from animalMeasurement where animalId=" + animalId + " and type='"+type+"' order by date ASC";
            DataSet ds = db.select(query);
            int count = ds.Tables[0].Rows.Count;
            if (count>0)
            {
                for(int i = 0; i < count; i++)
                {
                    weight = Convert.ToDouble(ds.Tables[0].Rows[i][0].ToString());
                    date = ds.Tables[0].Rows[i][1].ToString();
                    int n = dataGridViewMeasurement.Rows.Add();
                    dataGridViewMeasurement.Rows[n].Cells[0].Value = (n + 1).ToString();
                    dataGridViewMeasurement.Rows[n].Cells[1].Value = date;
                    dataGridViewMeasurement.Rows[n].Cells[2].Value = ds.Tables[0].Rows[i][2].ToString();
                    dataGridViewMeasurement.Rows[n].Cells[3].Value = weight.ToString();
                    if (i > 0)
                    {
                        if(date == ds.Tables[0].Rows[i - 1][1].ToString())
                        {
                            
                            weight = (Convert.ToDouble(ds.Tables[0].Rows[i][0].ToString()) + Convert.ToDouble(ds.Tables[0].Rows[i-1][0].ToString()))/2;
                            dr = dt.NewWeightRow();
                            dr["weight"] = weight;
                            dr["date"] = date;
                            dt.Rows.Add(dr);
                            weights.Add(weight);
                            dates.Add(date);
                            selectDailyCalories(date);
                        }
                        
                    }
                }
            }
            
             
        }
        void loadDataOnChart()
        {
            chart1.DataSource = dt;
            chart1.Series["Weight"].XValueMember = "date";
            chart1.Series["Weight"].YValueMembers = "weight";
            this.chart1.Titles.Add("Average of Daily Morning and Evining Recorded Weights");
            chart1.Series["Weight"].ChartType = SeriesChartType.Line;
            chart1.Series["Weight"].IsValueShownAsLabel = true;
            this.chart1.Titles["Kgs"].Text = "Weight in (Kgs)";
            this.chart1.Titles["Dates"].Text = "Dates";
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
        void calculateWeightChange()
        {
            int count = weights.Count;
            double firstWeight = weights[0];
            double lastweight = weights[count - 1];
            lblWeightChange.Text = (firstWeight - lastweight).ToString();
        }

        void selectDailyCalories(string date)
        {
            double minutesSpent = 0, gramsFed = 0,exerciseCalorieValue = 0,CaloriesGained = 0, caloriesLost=0, mealCalorieValue=0;
            string activityLevel = "";
            string query = "select  minutesSpent x,  calorieValue e from animalExercise x, exercise e where x.animalId="+animalId+" and e.Id=x.exerciseId and date='"+date+"'";
            DataSet ds = db.select(query);
            if(ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow d in ds.Tables[0].Rows)
                {
                    minutesSpent = Convert.ToDouble(d.ItemArray.GetValue(0).ToString());
                    exerciseCalorieValue = Convert.ToDouble(d.ItemArray.GetValue(1).ToString());
                    caloriesLost += minutesSpent * exerciseCalorieValue;
                }
            }

            query = "select  gramsFed y, calorieValue m from animalMeal y, meal m where  y.animalId=" + animalId + " and m.Id=y.mealId and date='" + date + "'";
            ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow d in ds.Tables[0].Rows)
                {
                    gramsFed = Convert.ToDouble(d.ItemArray.GetValue(0).ToString());
                    mealCalorieValue = Convert.ToDouble(d.ItemArray.GetValue(1).ToString());
                    CaloriesGained += gramsFed * mealCalorieValue;
                }
                
            }

            query = "select  activityLevel from activity  where  animalId=" + animalId + " and date='" + date + "'";
            ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {

                activityLevel = ds.Tables[0].Rows[0][0].ToString();
            }

            int n = dataGridViewCalorie.Rows.Add();
            dataGridViewCalorie.Rows[n].Cells[0].Value = (n + 1).ToString();
            dataGridViewCalorie.Rows[n].Cells[1].Value = date;
            dataGridViewCalorie.Rows[n].Cells[2].Value = CaloriesGained.ToString();
            dataGridViewCalorie.Rows[n].Cells[3].Value = caloriesLost.ToString();
            dataGridViewCalorie.Rows[n].Cells[4].Value = (CaloriesGained - caloriesLost).ToString();
            dataGridViewCalorie.Rows[n].Cells[5].Value = activityLevel;
            dataGridViewCalorie.Rows[n].Cells[6].Value = EstimateCalorieIntake(activityLevel, date).ToString();
        }

        double calculateAverageWeightLossOrGain()
        {
            double weight = 0;
            double result = 0;
            int count = weights.Count;
            if(count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (i > 0)
                    {
                        weight += weights[i - 1] - weights[i];
                    }
                }
                result = weight / (count - 1);
            }
            return result;
        }

        double EstimateCalorieIntake(string activityLevel, string date)
        {
            int index = dates.Count - 1;
            double weight = weights[index];
            double estimate = 0;
            string gender;
            string query = "select gender from animal where Id=" + animalId + "";
            DataSet ds = db.select(query);
            if(ds.Tables[0].Rows.Count > 0)
            {
                gender = ds.Tables[0].Rows[0][0].ToString();
                lblGender.Text = gender;
                if (activityLevel == "Inactive")
                {
                    if(gender == "male")
                    {
                        estimate = 8 * weight;
                    }
                    else if(gender == "female")
                    {
                        estimate = 6 * weight;
                    }
                }
                else if (activityLevel == "Moderately active")
                {
                    if (gender == "male")
                    {
                        estimate = 10 * weight;
                    }
                    else if (gender == "female")
                    {
                        estimate = 8 * weight;
                    }
                }
                else if (activityLevel == "Active")
                {
                    if (gender == "male")
                    {
                        estimate = 12 * weight;
                    }
                    else if (gender == "female")
                    {
                        estimate = 10 * weight;
                    }
                }
                
            }
            return estimate;
        }
    }
}
