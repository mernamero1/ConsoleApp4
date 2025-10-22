using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace school
{
    internal class Course
    {
        public Course(int courseId, string title, Instructor instructor)
        {
            CourseId = courseId;
            Title = title;
            Instructor = instructor;
        }

        public int CourseId { get; set; }
        public string? Title { get; set; }
        public Instructor Instructor { get; set; }

        public string? PrintDetails(int CourseId)
        {
            if (CourseId != this.CourseId)
                return null;


            return $"CourseId : {CourseId} , Title : {Title} ,Instructor Name {Instructor.Name}";
        }

    }
}
