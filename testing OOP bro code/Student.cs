using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_OOP_bro_code
{
    public class Student
    {
        public string name;
        public int age;
        public double gpa;
        public bool isEnrolled;

        public Student(string name, int age, double gpa)
        {
            this.name = name;
            this.age = age;
            this.gpa = gpa;
        }

    }
}
