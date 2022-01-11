using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInfo
{
   public class StudentManager
    {
        public List<DepartmentInfo> GetAllDepartment()
        {
            var context = new MISEntities();

            var q = from dep in context.DepartmentInfoes
                    select dep;
            return q.ToList();
        }
        public List<GenderId> GetAllGendar()
        {
            var context = new MISEntities();

            var q = from g in context.GenderIds
                    select g;
            return q.ToList();
        }
        public List<ShiftInfo> GetAllShift()
        {
            var context = new MISEntities();

            var q = from s in context.ShiftInfoes
                    select s;
            return q.ToList();
        }
        public List<SemesterInfo> GetAllSemester()
        {
            var context = new MISEntities();

            var q = from sem in context.SemesterInfoes
                    select sem;
            return q.ToList();
        }
        public List<SP_GRIDVIEWDISPLAYS_Result> GetAllStudentInformation()
        {
            var context = new MISEntities();
            var q = context.SP_GRIDVIEWDISPLAYS();
            return q.ToList();
        }
        public List<SP_DepartmentWiseStudentinfo_Result> GetDepartmentWiseStudent(int sId, int dId)
        {
            var context = new MISEntities();
            var q = context.SP_DepartmentWiseStudentinfo(sId, dId);
            return q.ToList();
        }
    }
}
