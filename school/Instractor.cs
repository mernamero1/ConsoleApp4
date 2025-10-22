using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    internal class Instructor
    {
        public Instructor(int instructorId, string name, string specialization)
        {
            InstructorId = instructorId;
            Name = name;
            Specialization = specialization;
        }

        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public string? PrintDetails(int instructorid)
        {
            if (instructorid != InstructorId)
                return null;
            return $"Name : {Name} , Specialization : {Specialization}";
        }
    }
}
