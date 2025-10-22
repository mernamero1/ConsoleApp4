using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace school
{
    internal class StudentManger
    {
        public List<Student> students = [];
        public List<Course> Courses = [];
        public List<Instructor> instructors = [];

        public StudentManger(List<Student> students, List<Course> courses,
            List<Instructor> instructors)
        {
            this.students = students;
            Courses = courses;
            this.instructors = instructors;
        }
        public bool AddStudent(Student student)
        {
            students.Add(student);
            return true;

        }
        public bool AddCourse(Course cour)
        {
            Courses.Add(cour);
            return true;

        }
        public bool AddIns(Instructor ins)
        {
            instructors.Add(ins);
            return true;

        }
        public Student? Findstudent(int? studentid , string? stuname)

        {


            for (int i = 0; i < students.Count; i++)
            {

                if ((studentid!= null&& studentid == students[i].StudentId) ||
                    (stuname != null && stuname == students[i].Name))

                    return students[i];
            }
            return null;
        }
        public Course? FindCourse(int? courseid , string? coname)

        {


            for (int i = 0; i < Courses.Count; i++)
            {

                if ((courseid!= null &&courseid == Courses[i].CourseId) ||
                    (coname != null && coname == Courses[i].Title))

                    return Courses[i];
            }
            return null;
        }
        public Instructor? FindInstructor(int insId)

        {


            for (int i = 0; i < instructors.Count; i++)
            {

                if (insId == instructors[i].InstructorId)

                    return instructors[i];
            }
            return null;
        }
        public bool EnrollStuCour(int stdid, int courid)
        {
            bool findstudent = true;
            for (int i = 0; i < students.Count; i++)
            {

                if (stdid != students[i].StudentId)
                    findstudent = false;
            }
            for (int i = 0; i < Courses.Count; i++)
            {

                if (courid != Courses[i].CourseId)

                    findstudent = false;

            }
            for (int i = 0; i < students.Count; i++)
            {
                if (stdid == students[i].StudentId)
                {
                    for (int j = 0; j < students[i].Courses.Count; j++)
                    {
                        if (courid == students[i].Courses[j].CourseId)
                        {
                            findstudent = true;

                        }
                    }
                }


            }
            if (!findstudent)
                return false;
            else
                return true;
        }
        public List<Student> ViewAllStudents()
        {
            return students;
        }
        public bool update(int id, string? name, int? age, Course? Acourse, Course? Rcourse)
        {
            bool isok = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == id) {

                    isok = true;
                    if (name != null)
                        students[i].Name = name;

                    if (age.HasValue)
                        students[i].Age = age.Value;

                    if (Acourse != null)
                        students[i].Courses.Add(Acourse);

                    if (Rcourse != null)
                        students[i].Courses.Remove(Rcourse);

                    break;

                }

            }
            return isok;
     

        }

        public bool Delete(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == id)
                {
                    students.Remove(students[i]);
                    return true;
                }
                
            }
            return false;



        }
        public List<Course> ViewAllCources()
        {
            return Courses;
        }
        public List<Instructor> ViewAllinstructor()
        {
            return instructors;
        }

        public bool EnrollStudInCourse(int id , Course course)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == id)
                    students[i].Courses.Add(course);
                    return true;
                    
            
            }
            return false;

        }
        public string? nameofins (string courname)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (courname == Courses[i].Title)
                {
                    return Courses[i].Instructor.Name;
                }
            }
            return null;
        }
    }
}

