using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalWeightTracker.classes
{
    class Staff
    {
        private int staffId;
        private string username;
        private string password;
        private string name;
        private string birthday;
        private string gender;
        database db = new database();

        public string Username { get; set; }

        public string Password { get; set; }
        public string Name { get; set; }

        public string Birthday { get; set; }

        public string Gender { get; set; }
        public bool AddStaff(string username,string password,string name, string birthday, string gender)
        {
            staffId = db.codeGenerator("staff");
            string query = "insert into staff Values("+staffId+",'"+username+"','"+password+"','"+name+"','"+birthday+"','"+gender+"')";
            if (db.insert(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateStaff(int Id, string username, string password, string name, string birthday, string gender)
        {
            string query = "update staff set username='" + username + "', password='" + password + "', name='" + name + "', birthday='" + birthday + "', gender='" + gender + "' where Id="+Id+"";
            if (db.update(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteStaff(int Id)
        {
            string query = "delete from staff where Id=" + Id + "";
            if (db.delete(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Login(string username, string password)
        {
            string query = "select * from staff where username='" + username + "' and password='" + password + "'";
            DataSet ds = db.select(query);
            if(ds.Tables[0].Rows.Count > 0)
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
