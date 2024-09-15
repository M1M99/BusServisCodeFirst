using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_SchoolServise.Model
{
    public class ClassForSchool
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
