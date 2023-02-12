using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWeightTracker.classes
{
    class Animal
    {
        database db = new database();
        public int animalId;
        private string animalSpecie;
        private string animalName;
        private int animalAge;
        public string animalGender;
        public string AnimalSpecie { get; set; }
        public string AnimalName { get; set; }
        public int AnimalAge { get; set; }
        public string AnimalGender { get; set; }


        public bool addAnimal(string species, string name, int age, string gender)
        {
            animalId = db.codeGenerator("animal");
            string query = "Insert into animal values("+animalId+",'"+species+"','"+name+"','"+gender+"',"+age+")";
            if (db.insert(query))
            {
                return true;  
            }
            else
            {
                return false;
            }
        }
        public bool updateAnimal(int Id, string species, string name, string gender, int age)
        {
            string query = "update animal set species='" + species + "', name='" + name + "',gender='" + gender + "', age=" + age + " where Id="+Id+"";
            if (db.update(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteAnimal(int Id)
        {
            string query = "delete from animal where Id=" + Id + "";
            if (db.delete(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool addAnimalExercise(int exerciseId, int animalId, double minutesSpent)
        {
            string date = DateFormatFixing(DateTime.Now.ToShortDateString());
            int Id = db.codeGeneratorForAnimalExercise("animalExercise");
            string query="insert into animalExercise Values("+Id+","+animalId+","+exerciseId+","+minutesSpent+",'"+date+"')";

            if (db.insert(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateAnimalExercise(int Id, int exerciseId, int animalId, double minutesSpent)
        {
            string date = DateFormatFixing(DateTime.Now.ToShortDateString());
            string query = "update animalExercise set animalId=" + animalId + ", exerciseId=" + exerciseId + ",minutesSpent=" + minutesSpent + ", date ='" + date + "' where animalExerciseId=" + Id + "";
            if (db.update(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteAnimalExercise(int Id)
        {
            string query = "delete from animalExercise where animalExerciseId=" + Id + "";
            if (db.delete(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool addAnimalMeal(int mealId, int animalId, double gramsFed, string dayTime)
        {
            string date = DateFormatFixing(DateTime.Now.ToShortDateString());
            int Id = db.codeGeneratorForAnimalMeal("animalMeal");
            string query = "insert into animalMeal Values(" + Id + "," + animalId + "," + mealId + "," + gramsFed + ",'"+date+"','"+dayTime+"')";

            if (db.insert(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateAnimalMeal(int Id, int mealId, int animalId, double gramsFed, string dayTime)
        {
            string date = DateFormatFixing(DateTime.Now.ToShortDateString());
            string query = "update animalMeal set animalId=" + animalId + ", mealId=" + mealId + ",gramsFed=" + gramsFed + ", date ='"+date+"',dayTime='"+dayTime+"' where animalMealId=" + Id + "";
            if (db.update(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteAnimalMeal(int Id)
        {
            string query = "delete from animalMeal where animalMealId=" + Id + "";
            if (db.delete(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
        }
    }
}
