using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomDev.Models.Organizations
{
    public class TypeAuthorities
    {
        public int Id;
        public string Name { get; set; }
        public Authorities Authorities { get; set; }
    }
}
