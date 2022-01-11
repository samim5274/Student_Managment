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
    public partial class DeparmentWiseReportForm : Form
    {
        public DeparmentWiseReportForm()
        {
            InitializeComponent();
        }
        private void DeparmentWiseReportForm_Load(object sender, EventArgs e)
        {
            FillDepartment();
        }
        private void FillDepartment()
        {
            var mngr = new StudentManager();
            var departmentlist = mngr.GetAllDepartment();
            var d = new DepartmentInfo { Id = 0, DepartmentName = "All Department" };
            var list = new List<DepartmentInfo> { d };
            list.AddRange(departmentlist);
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DataSource = list;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {

            int stdId = Convert.ToInt32(txtStudentId.Text.Trim());
            int did = Convert.ToInt32(cbxDepartment.SelectedValue);

            var rpt = new rpt_StudentReport();
            var reportViewer = new ReportViewer();

            rpt.SetParameterValue("@StdId",stdId);
            rpt.SetParameterValue("@Did",did);
            // reportViewer.crystalReportViewer1.Show(); rpt.DataSourceConnections.Clear();
            reportViewer.crystalReportViewer1.ReportSource = rpt;


            reportViewer.ShowDialog();

            rpt.DataSourceConnections.Clear();
            reportViewer.crystalReportViewer1.ReportSource = rpt;


            reportViewer.ShowDialog();

        }

        
    }
}
