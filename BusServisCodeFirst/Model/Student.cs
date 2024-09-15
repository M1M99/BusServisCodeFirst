using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_SchoolServise.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ParentId { get; set; }
        public Parent Parent { get; set; }
        public int ClassId { get; set; }
        public Ride Rides { get; set; }
        public ClassForSchool Class { get; set; }
        public int RideId { get; set; }
        public string? HomeAdress { get; set; }
        public string? OtherAdress { get; set; }

    }
}
