using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomDev.Models.Organizations;

namespace AtomDev.Models.Education
{
    public class EduProgram
    {
        public int Id { get; set; }
        public EduProgramType ProgramType { get; set; }
        public Speciality Speciality { get; set; }
        public Qualification Qualification { get; set; }
        public EduForm Form { get; set; }
        public EduLvl Level { get; set; }
        public EduBase Base { get; set; }
        public EduOrg Organization { get; set; }
    }
}
