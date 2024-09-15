using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_SchoolServise.Model
{
    public class Ride
    {
        public int Id { get; set; }
        public int DriverId { get; set; } // burda 1 gedisin coxlu sagirdleri ola biler .
        public Driver Driver { get; set; } // burda 1 gedisin coxlu sagirdleri ola biler .
        public ICollection<Student> Students { get; set; }
    }
}
