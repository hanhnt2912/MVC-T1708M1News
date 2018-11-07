using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using T1708M1News.Models;

    public class T1708M1NewsContext : DbContext
    {
        public T1708M1NewsContext (DbContextOptions<T1708M1NewsContext> options)
            : base(options)
        {
        }

        public DbSet<T1708M1News.Models.Student> Student { get; set; }
    }
