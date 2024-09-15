using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_SchoolServise.Model
{
    public class Parent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
