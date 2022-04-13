using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeReturnLesson
{
    class Group
    {
        public Student [] students = new Student [0];

        public int GroupNo { get; set; }

        public  void AddStudent(Student student)
        {
            Array.Resize(ref students,students.Length+1);
            students[students.Length-1] = student;
        }
    }
}
