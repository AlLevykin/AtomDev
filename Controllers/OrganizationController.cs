using AtomDev.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomDev.Controllers
{
    [Route("api/Organization")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public OrganizationController(StudentDbContext context)
        {
            _context = context;
        }

    }
}
