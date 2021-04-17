using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomDev.Models
{
    public interface IStudentRepository
    {
        public IQueryable<Student> Students { get; }
    }
}
