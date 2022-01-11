using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace StudentInfo
{
    public partial class Department_Wise_Student_Info : Form
    {
        public Department_Wise_Student_Info()
        {
            InitializeComponent();
        }
        private void DepartmentWiseStudentInfoLoad(object sender, EventArgs e)
        {
            FillGrid();
            FillDepartment();
        }
        private void FillDepartment()
        {
            var mngr = new StudentManager();
            var departmentlist = mngr.GetAllDepartment();

            var d = new DepartmentInfo {Id = 0, DepartmentName = "All Department"};
            //var d = new DepartmentInfo();
            //d.Id = 0;
            //d.DepartmentName = "All Department";

            var list = new List<DepartmentInfo> {d};

            //var list = new List<DepartmentInfo>();
            //list.Add(d);
            list.AddRange(departmentlist);

            //foreach (var info in departmentlist)
            //{
            //    list.Add(info);
            //}
         
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DataSource = list;
        }
        private void FillGrid()
        {
            var mngr = new StudentManager();
            var list = mngr.GetAllStudentInformation();
            DepartmentGrid.DataSource = list;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var sId = Convert.ToInt32(txtStudentId.Text.Trim());
                var dId = Convert.ToInt32(cbxDepartment.SelectedValue);

                var smnr = new StudentManager();

                var list = smnr.GetDepartmentWiseStudent(sId, dId);
                DepartmentGrid.DataSource = list;

                //var mnr = new MISEntities();

                //var list = mnr.SP_DepartmentWiseStudentinfo(sId, dId);
                //DepartmentGrid.DataSource = list;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error..!");
            }

        }
        private Bitmap bm;
        private void btnPDFReport_Click(object sender, EventArgs e)
        {
            var print = new DGVPrinter();
            print.Title = "Department Wise StudentInfo";
            //print.SubTitle = "test";
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = false;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "TPI";
            print.FooterSpacing = 15;
            print.PrintDataGridView(DepartmentGrid);

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bm,0,0);
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

    }
}
