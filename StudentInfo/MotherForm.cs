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
    public partial class MotherForm : Form
    {
        public MotherForm()
        {
            InitializeComponent();
        }

        private void addStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new btnDelete();
            obj.Show();
        }

        private void addNewDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DepartmentForm();
            obj.ShowDialog();
        }

        private void departmentWiseStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new Department_Wise_Student_Info();
            obj.ShowDialog();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new CreateUserform();
            obj.ShowDialog();
        }

        private void deparmtmentCrystallReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DeparmentWiseReportForm();
            obj.ShowDialog();
        }
    }
}
