using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomDev.Models.Education;

namespace AtomDev.Models.Admission
{
    public class AdmissionPlan
    {
        public int Id { get; set; }
        public DateTime Year { get; set; }
        public int AdmissionNumber { get; set; }
        public bool TargetedAdmission { get; set; }
        public EduProgram EduProgram { get; set; }
        public TypeOfAdmission TypeOfAdmission { get; set; }
    }
}
