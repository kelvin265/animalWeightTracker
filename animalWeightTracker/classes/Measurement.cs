using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWeightTracker.classes
{
    class Measurement
    {
        private float amount;
        private DateTime date;
        private string dayTime;
        private string measurementType;
        database db = new database();

        public float Amount{ get; set; }
   
        public DateTime Date { get; set; }

        public string DayTime { get; set; }

        public string  MeasurementType { get; set; }

        public bool enterMeasurement(int animalId,string type,double measurement, string dayTime)
        {
            int Id = db.codeGenerator("animalMeasurement");
            string date = DateFormatFixing(DateTime.Today.ToShortDateString());
            string query = "Insert into animalMeasurement values("+Id+","+animalId+",'"+type+"',"+measurement+",'"+dayTime+"','"+date+"')";
            if (db.insert(query))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool modifyMeasurement(int Id,int animalId, string type, double measurement, string dayTime)
        {
            string date = DateFormatFixing(DateTime.Today.ToShortDateString());
            string query = "update animalMeasurement set animalId=" + animalId + ",type='" + type + "',measurement=" + measurement + ",dayTime='" + dayTime + "',date='"+date+"' where Id=" + Id + "";
            if (db.update(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteMeasurement(int Id)
        {
            string query = "delete from animalMeasurement where Id=" + Id + "";
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
