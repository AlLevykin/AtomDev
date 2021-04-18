using AtomDev.Models;
using AtomDev.Models.Organizations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly ApplicationDbContext _context;

        public OrganizationController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EduOrg>>> GetOrganizations()
        {
            var organizations = await _context.Organizations.ToListAsync();

            if (organizations == null)
            {
                return NotFound();
            }

            return organizations;
        }

        //GET: api/Students/{Id}
        [HttpGet("{id}")]
        public async Task<ActionResult<EduOrg>> GetOrganization(long id)
        {
            var prganization = await _context.Organizations.FindAsync(id);

            if (prganization == null)
            {
                return NotFound();
            }
            return prganization;
        }
    }
}
