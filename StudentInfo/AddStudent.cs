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
    public partial class btnDelete : Form
    {
        public btnDelete()
        {
            InitializeComponent();
        }
        private void AddStudentLoad(object sender, EventArgs e)
        {
            var db = 
            dtpBirthDay.Value = DateTime.Now;
            FillDepartment();
            FillSex();
            FillShift();
            FillSemseter();
            FillGrid();
            FillAge();
        }
        private void FillAge()
        {
            cbxAge.Items.Add(10);
            cbxAge.Items.Add(12);
            cbxAge.Items.Add(15);
            cbxAge.Items.Add(20);
        }
        private void FillGrid()
        {
            var obj = new StudentManager();
            var list = obj.GetAllStudentInformation();
            datagridstdudentinfo.DataSource = list;
        }
        private void FillSemseter()
        {
            var studentManger = new StudentManager();
            var list = studentManger.GetAllSemester();
            cbxSemester.DisplayMember = "Semester";
            cbxSemester.ValueMember = "Id";
            cbxSemester.DataSource = list;
        }
        private void FillShift()
        {
            var studentManger = new StudentManager();
            var list = studentManger.GetAllShift();
            cbxShift.DisplayMember = "ShiftType";
            cbxShift.ValueMember = "Id";
            cbxShift.DataSource = list;
        }
        private void FillSex()
        {
            var studentManger = new StudentManager();
            var list = studentManger.GetAllGendar();
            cbxSex.DisplayMember = "Type";
            cbxSex.ValueMember = "ID";
            cbxSex.DataSource = list;
        }
        private void FillDepartment()
        {
            var studentManger = new StudentManager();
            var list = studentManger.GetAllDepartment();
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DataSource = list;
        }
        private void BtnAddClick(object sender, EventArgs e)
        {
            try
            {
                var misobj = new MISEntities();
                var objstudent = new StudentInfo();

                objstudent.StudentId = Convert.ToInt32(txtId.Text.Trim());
                objstudent.Name = txtName.Text.Trim();
                objstudent.Age = Convert.ToInt32(cbxAge.Text.Trim());
                objstudent.Adress = txtAdress.Text.Trim();
                objstudent.Session = txtSession.Text.Trim();
                objstudent.Contact = Convert.ToInt32(txtContact.Text.Trim());
                objstudent.DateofBirth = Convert.ToDateTime(dtpBirthDay.Value);
                
                objstudent.SemesterId = Convert.ToInt32(cbxSemester.SelectedValue);
                objstudent.DepId = Convert.ToInt32(cbxDepartment.SelectedValue);
                objstudent.ShiftId = Convert.ToInt32(cbxShift.SelectedValue);
                objstudent.GenderId = Convert.ToInt32(cbxSex.SelectedValue);

                misobj.AddToStudentInfoes(objstudent);
                misobj.SaveChanges();
                MessageBox.Show(@"Data Saved Successfully");
                ClearTxtbox();
                FillGrid();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Inpurt string was not correct format!! or Already StudentId is existed!");
            }

        }
        private void ClearTxtbox()
        {
            txtSession.Text = string.Empty;
            txtId.Text = string.Empty;
            txtSearchId.Text = string.Empty;
            txtContact.Text = string.Empty;
            cbxAge.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAdress.Text = string.Empty;
            cbxShift.SelectedValue = string.Empty;
            cbxSex.SelectedValue = string.Empty;
            cbxSemester.SelectedValue = string.Empty;
            cbxDepartment.SelectedValue = string.Empty;
        }
        private void BtnSearchClick(object sender, EventArgs e)
        {
            try
            {
                var misObj = new MISEntities();
                var std =
                     misObj.StudentInfoes.ToList().Where(x => x.StudentId == int.Parse(txtSearchId.Text.ToString())).FirstOrDefault();

                txtId.Text = std.StudentId.ToString();
                txtName.Text = std.Name;
                txtContact.Text = std.Contact.ToString();
                cbxAge.Text = std.Age.ToString();
                txtAdress.Text = std.Adress;
                txtSession.Text = std.Session;
                cbxShift.SelectedValue = std.ShiftId;
                cbxSex.SelectedValue = std.GenderId;
                cbxSemester.SelectedValue = std.SemesterId;
                cbxDepartment.SelectedValue = std.DepId;
                dtpBirthDay.Value = Convert.ToDateTime(std.DateofBirth);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,@"Error...!!");
            }
           

        }
        private void BtnUpdateClick(object sender, EventArgs e)
        {
            var misObj = new MISEntities();
            var std =
                 misObj.StudentInfoes.ToList().Where(x => x.StudentId == int.Parse(txtSearchId.Text.ToString())).FirstOrDefault();

            std.StudentId = Convert.ToInt32(txtId.Text.Trim());
            std.Name = txtName.Text.Trim();
            std.Age = Convert.ToInt32(cbxAge.Text.Trim());
            std.Adress = txtAdress.Text.Trim();
            std.Session = txtSession.Text.Trim();
            std.Contact = Convert.ToInt32(txtContact.Text.Trim());
            std.DateofBirth = Convert.ToDateTime(dtpBirthDay.Value);


            std.SemesterId = Convert.ToInt32(cbxSemester.SelectedValue);
            std.DepId = Convert.ToInt32(cbxDepartment.SelectedValue);
            std.ShiftId = Convert.ToInt32(cbxShift.SelectedValue);
            std.GenderId = Convert.ToInt32(cbxSex.SelectedValue);

            misObj.SaveChanges();
            MessageBox.Show(@"update");
            ClearTxtbox();
           FillGrid();
        }
        private void Button1Click(object sender, EventArgs e)
        {
            var misObj = new MISEntities();
            var std =
                 misObj.StudentInfoes.ToList().Where(x => x.StudentId == int.Parse(txtSearchId.Text.ToString())).FirstOrDefault();

            misObj.DeleteObject(std);
            misObj.SaveChanges();
            MessageBox.Show(@"Record Deleted!!");
            FillGrid();

        }

        private void txtSearchId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                
            }
        }
    }
}
