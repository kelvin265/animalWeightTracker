using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWeightTracker.classes
{
    class Meal
    {
        public Animal animalId;
        private int mealId;
        private string mealName;
        private double calorieValue;
        database db = new database();

        public string MealName { get; set; }
        public double CalorieValue { get; set; }
        public bool addMeal(string name, double calorieValue)
        {
            mealId = db.codeGenerator("meal");
            string query = "Insert into meal Values(" + mealId + ",'" + name + "'," + calorieValue + ")";

            if (db.insert(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateMeal(int Id, string name, double calorieValue)
        {
            string query = "Update meal set name='" + name + "',calorieValue=" + calorieValue + " where Id=" + Id + "";

            if (db.update(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteMeal(int Id)
        {
            string query = "delete from meal where Id=" + Id + "";

            if (db.delete(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void calculateCaloriesPerMeal()
        {
        }
    }
}
