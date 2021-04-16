using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomDev.Models.Education
{
    public class Qualification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Speciality Speciality { get; set; }
    }
}
