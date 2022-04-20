#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcStudent.Controllers;

namespace MvcStudent.Data
{
    public class MvcStudentContext : DbContext
    {
        public MvcStudentContext (DbContextOptions<MvcStudentContext> options)
            : base(options)
        {
        }

        public DbSet<MvcStudent.Controllers.student> student { get; set; }
    }
}
