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
    public partial class frmAddStaff : Form
    {
        Staff staff = new Staff();
        public frmAddStaff()
        {
            InitializeComponent();
        }
        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(txtGender.Text != "" && txtName.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                string date = DateFormatFixing(dateTimePicker1.Value.ToShortDateString());
                if (staff.AddStaff(txtUsername.Text, txtPassword.Text, txtName.Text, date, txtGender.Text))
                {
                    MessageBox.Show("User added successfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtName.Text = "";
                    txtGender.Text = "";
                    dateTimePicker1.Value = DateTime.Today;
                }
                else
                {
                    MessageBox.Show("User coould not be added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all empty fields", "Empty fiels", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
