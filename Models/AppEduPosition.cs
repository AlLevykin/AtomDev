using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomDev.Models.Applications;
using AtomDev.Models.Admission;

namespace AtomDev.Models
{
    public class AppEduPosition
    {
        public int Id { get; set; }
        public ApplicationForm ApplicationForm { get; set; }
        public AdmissionPlan AdmissionPlan { get; set; }
    }
}
