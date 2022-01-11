using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }
        private void btnAdddep_Click(object sender, EventArgs e)
        {

            try
            {
                var m = new MISEntities();

                var d = new DepartmentInfo();
                d.Id = Convert.ToInt32(txtDid.Text.Trim());
                d.DepartmentName = txtName.Text.Trim();

                m.AddToDepartmentInfoes(d);
                m.SaveChanges();
                MessageBox.Show(@"Add new Department");
                cleartext();
            
            }
            catch (Exception  )
            {
                MessageBox.Show("@Input string was not correct format or already exists");
            }
            
        }
        private void cleartext()
        {
            txtName.Text = txtDid.Text = string.Empty;
        }
    }
}
