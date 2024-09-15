using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_SchoolServise.Model
{
    public class Holiday
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly BeginDate { get; set; }
        public DateOnly LastDate { get; set; }
    }
}
