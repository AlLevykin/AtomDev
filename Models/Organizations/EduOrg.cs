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
        public Address Address { get; set; }
        public string Phone { get; set; }
        public double Latitude { get; set; }
        public double Longiitude { get; set; }
        public bool License { get; set; }
        public bool StateAccreditation { get; set; }
        public MunicipalUnit MunitipalUnit { get; set; }
        public Authorities Authoritiies { get; set; }
        public TypeAuthorities TypeAuthorities { get; set; }
        public EduOrg ParentOrg { get; set; }
    }
}
