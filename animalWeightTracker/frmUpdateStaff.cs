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
    public partial class frmUpdateStaff : Form
    {
        Staff staff = new Staff();
        database db = new database();
        string currentPassword;
        int staffId;
        public frmUpdateStaff()
        {
            InitializeComponent();
        }

        private void FrmUpdateStaff_Load(object sender, EventArgs e)
        {
            staffId = frmMain.StaffId;
            selectStaff();
        }

        private void selectStaff()
        {
            string query = "select * from staff where id = " + staffId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtUsername.Text = dr.ItemArray.GetValue(1).ToString();
                txtPassword.Text = dr.ItemArray.GetValue(2).ToString();
                currentPassword = dr.ItemArray.GetValue(2).ToString();
                txtName.Text = dr.ItemArray.GetValue(3).ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dr.ItemArray.GetValue(4).ToString());
                txtGender.Text = dr.ItemArray.GetValue(5).ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string date = DateFormatFixing(dateTimePicker1.Value.ToShortDateString());
            if (txtGender.Text != "" && txtName.Text != "" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                if(txtCornfirmPassword.Text == currentPassword)
                {
                    if(staff.UpdateStaff(staffId, txtUsername.Text, txtPassword.Text, txtName.Text, date, txtGender.Text))
                    {
                        MessageBox.Show("user updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to verify password", "Verification error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string DateFormatFixing(string date)
        {
            string sysFormat = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            return date = DateTime.ParseExact(date, sysFormat, System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
