using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AtomDev.Models.Organizations
{
    public class EduOrg
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double Latitude { get; set; }
        public double Longiitude { get; set; }
        public bool License { get; set; }
        public bool StateAccreditation { get; set; }
        public MunicipalUnit MunitipalUnits { get; set; }
        public Authorities Authoritiy { get; set; }
        public TypeAuthorities TypesAuthoritiy { get; set; }
    }
}
