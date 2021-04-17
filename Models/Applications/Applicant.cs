using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomDev.Models.Applications
{
    public class Applicant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        public string BirthPlace { get; set; }
        public string Citizenship { get; set; }
        public string Document { get; set; }
        public string Seria { get; set; }
        public string Number { get; set; }
        public string IssuedBy { get; set; }
        public string IssuedWhen { get; set; }
        public Address Address { get; set; }
        public string MobPhone { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }
        public bool ManSex { get; set; }
        public bool Privileged { get; set; }
        public Parent Parent1 { get; set; }
        public Parent Parent2 { get; set; }
    }
}
