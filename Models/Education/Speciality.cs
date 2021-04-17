using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomDev.Models.Education
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public EduProgramType ProgramType { get; set; }
    }
}
