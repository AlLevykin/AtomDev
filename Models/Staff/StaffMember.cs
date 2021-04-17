using AtomDev.Models.Organizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AtomDev.Models.Staff
{
    public class StaffMember
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public EduOrg Workplace { get; set; }
        public StaffCategory Category { get; set; }
        public Cat2NdLvl Cat2NdLvl { get; set; }
        public Cat3DLvl Cat3DLevel { get; set; }
    }
}
