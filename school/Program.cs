using System.Net;
using System.Threading.Channels;
using school;

int choice ;
StudentManger studentmanger = new StudentManger([], [], []);
do
{
    Console.WriteLine("         1. Add Student");
    Console.WriteLine("         2. Add Instructor");
    Console.WriteLine("         3. Add Course");
    Console.WriteLine("         4. Enroll Student in Course");
    Console.WriteLine("         5. Show All Students");
    Console.WriteLine("         6. Show All Courses");
    Console.WriteLine("         7. Show All Instructors");
    Console.WriteLine("         8. Find Student by ID or Name");
    Console.WriteLine("         9. Find Course by ID or Name");
    Console.WriteLine("         10. Check if the student enrolled in specific course");
    Console.WriteLine("         11. Return the instructor name by course name");
    Console.WriteLine("         12. Exit");
    Console.Write("Choose an option: ");
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (choice == 1)
    {
        Console.WriteLine("Enter Student ID:");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Age");
        int age = Convert.ToInt32(Console.ReadLine());

        Student s = new(id, name, age, [] );

        studentmanger.AddStudent(s);
        Console.WriteLine("Student added successfully!");
    }
    if (choice == 2)
    {
        Console.WriteLine("Enter Instructor ID:");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter  Instructor name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Specialization");
        string Specialization =Console.ReadLine();

        Instructor ins = new(id, name, Specialization);

        studentmanger.AddIns(ins);
        Console.WriteLine("Instructor added successfully!");
    }
    if (choice == 3)
    {
        Console.WriteLine("Enter Course ID:");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter  Course name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Instructor ID");
        int insid =Convert.ToInt32( Console.ReadLine());

        Instructor ins = studentmanger.FindInstructor(insid);


        Course c = new(id, name,ins );

        studentmanger.AddCourse(c);
        Console.WriteLine("Course added successfully!");
    }
    if (choice == 4)
    {
        Console.WriteLine("Enter Student ID:");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Course ID:");
        int courseid = Convert.ToInt32(Console.ReadLine());

        Course c1 = studentmanger.FindCourse(courseid , null);
        

        if (c1 == null)
        {
            Console.WriteLine("Course not found");
        }
        else
        {
            if (studentmanger.EnrollStudInCourse(id, c1))
            {
                Console.WriteLine(" Done!");
            }
            else
            {
                Console.WriteLine(" Error");
            }
        }



    }
    if(choice == 5)
    {
        List<Student> students = studentmanger.ViewAllStudents();
        if (students.Count ==0)
            Console.WriteLine("List Empty");
        else 
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].PrintDetails(students[i].StudentId));
            }
        }

            
    }
    if(choice == 6)
    {
        List<Course> courses = studentmanger.ViewAllCources();
        if (courses.Count ==0)
            Console.WriteLine("List Empty");
        else 
        {
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine(courses[i].PrintDetails(courses[i].CourseId));
            }
        }

            
    }
    if(choice == 7)
    {
        List<Instructor> instructors = studentmanger.ViewAllinstructor();
        if (instructors.Count ==0)
            Console.WriteLine("List Empty");
        else 
        {
            for (int i = 0; i < instructors.Count; i++)
            {
                Console.WriteLine(instructors[i].PrintDetails(instructors[i].InstructorId));
            }
        }

            
    }
    if (choice == 8)
    {
        Console.WriteLine("Enter ID or Name");
        Console.WriteLine("1. ID");
        Console.WriteLine("2. Name");
        int option = Convert.ToInt32(Console.ReadLine());
        Student? s = null;
        if (option == 1)
        {
            Console.WriteLine("Enter ID");
            int num = Convert.ToInt32( Console.ReadLine());
            s =studentmanger.Findstudent(num, null);
        }
        else if (option == 2)
        {
            Console.WriteLine("Enter Name");
            string n = Console.ReadLine();
            s= studentmanger.Findstudent( null, n);
        }
        if (s != null)
            Console.WriteLine(s.PrintDetails(s.StudentId)); 
        else
            Console.WriteLine("Student not found.");

    }
    if (choice == 9)
    {
        Console.WriteLine("Enter ID or Title");
        Console.WriteLine("1. ID");
        Console.WriteLine("2. Title");
        int option = Convert.ToInt32(Console.ReadLine());
        Course? s = null;
        if (option == 1)
        {
            Console.WriteLine("Enter ID");
            int num = Convert.ToInt32( Console.ReadLine());
             s = studentmanger.FindCourse(num, null);
            
        }
        else if (option == 2)
        {
            Console.WriteLine("Enter Title");
            string n = Console.ReadLine();
             s = studentmanger.FindCourse( null, n);
        }
        if (s != null)
            Console.WriteLine(s.PrintDetails(s.CourseId));
        else
            Console.WriteLine("Course not found.");
    }
    if(choice ==10)
    {
        Console.WriteLine("Enter Student ID:");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Course ID");
        int couid = Convert.ToInt32(Console.ReadLine());
        bool l =  studentmanger.EnrollStuCour(id, couid);
        if (l)
            Console.WriteLine("Student Enrolled");
        else
        {
            Console.WriteLine("Not Enrolled");
        }

    }
    if(choice  == 11)
    {
        Console.WriteLine("Enter Course Name");
        string s = Console.ReadLine();

        string res = studentmanger.nameofins(s);
        if (res is null )
              Console.WriteLine("course not found");
        else
            Console.WriteLine(res);
    }
} while (choice != 12);
