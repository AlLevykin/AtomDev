using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomDev.Models.Organizations;

namespace AtomDev.Models.Applications
{
    public class ApplicationForm
    {
        public int Id { get; set; }
        public EduOrg Organization { get; set; }
        public Applicant Applicant { get; set; }
        public DateTime AppDate { get; set; }
    }
}
