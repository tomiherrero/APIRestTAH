using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Contexts
{
    public class StudentsContexts : DbContext
    {
        public StudentsContexts(DbContextOptions<StudentsContexts> options) : base(options)
        {

        }

        public DbSet<StudentsModels> Student { get; set; }
    }
}
