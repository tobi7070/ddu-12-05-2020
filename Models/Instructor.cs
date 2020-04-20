using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolNetwork.Models
{
    public class Instructor : Person
    {
        public DateTime HireDate { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
}
