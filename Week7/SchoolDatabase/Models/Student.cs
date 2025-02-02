using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDatabase.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
        public Student(int studentId, string studentName,int classId)
        {
            StudentId = studentId;
            StudentName = studentName;
            ClassId= classId;
        }
    }
}
