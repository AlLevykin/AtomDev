using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomDev.Models
{
    public class EFStudentRepository : IStudentRepository
    {
        public ApplicationDbContext context;

        public EFStudentRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Student> Students => context.Students;
    }
}
