using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWeightTracker.classes
{
    class Exercise
    {
        private int exerciseId;
        private float calorieValue;
        private string type;
        database db = new database();

        public float CalorieValue { get; set; }
        public string Type { get; set; }

        public void calculateCaloriesBurned()
        {
        }
        public bool addExercise(string type, double calorieValue)
        {
            exerciseId = db.codeGenerator("exercise");
            string query = "Insert into exercise Values("+exerciseId+",'"+type+"',"+calorieValue+")";
            if (db.insert(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateExercise(int Id, string type, double calorieValue)
        {
            string query = "Update exercise set type='" + type + "', calorieValue=" + calorieValue + " where Id=" + Id + "";
            if (db.update(query))
            {
                return true;  
            }
            else
            {
                return false;
            }
        }
        public bool deleteExercise(int Id)
        {
            string query = "delete from exercise where Id=" + Id + "";
            if (db.delete(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
