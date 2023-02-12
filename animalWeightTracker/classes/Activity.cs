using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWeightTracker.classes
{
    class Activity
    {
        private string activityLevel;
        database db = new database();

        public string ActivityLevel { get; set; }

        public bool addActivitylLevel(int animalId, string activityLevel)
        {
            string date = DateFormatFixing(DateTime.Today.ToShortDateString());
            int Id = db.codeGenerator("activity");
            string query = "insert into activity values("+Id+","+animalId+",'"+activityLevel+"','"+date+"')";
            if (db.insert(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool modifyActivitylLevel(int Id, int animalId, string activityLevel)
        {
            string date = DateFormatFixing(DateTime.Today.ToShortDateString());
            string query = "update activity set animalId=" + animalId + ", activityLevel='" + activityLevel + "', date='"+date+ "' where Id=" + Id + "";
            if (db.update(query))
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
