using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    internal class Student
    {
        public Student(int studentId, string name, int age,
            List<Course> courses)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
            Courses = courses;
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; set; } = [];


        public bool Enroll(int studentid, string name, Course course)
        {
            if (studentid != StudentId)
                return false;
            if (name != Name)
                return false;

            Courses.Add(course);
            return true;

        }
        public string? PrintDetails(int? studentid)
        {
            if (studentid != StudentId)
                return null;

            List<string> cc = [];

            for (int i = 0; i < Courses.Count; i++)
            {
                cc.Add(Courses[i].Title);
            }
            string allCourses = string.Join(",", cc);

            return $"Name : {Name} , Age : {Age} , {allCourses}";
        }
    }
}
