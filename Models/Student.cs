using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomDev.Models
{
    public class Student
    {
        public int Id { get; set; }
        public AppEduPosition AppEduPositions { get; set; }
        public bool Employed { get; set; }
        public bool DrivingLicenseB { get; set; }
        public DateTime Date { get; set; }
    }
}
