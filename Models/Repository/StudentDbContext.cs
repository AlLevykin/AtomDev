﻿using AtomDev.Models.Organizations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomDev.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<EduOrg> Organizations { get; set; }
    }
}
