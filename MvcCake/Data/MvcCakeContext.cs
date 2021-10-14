using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCake.Models;

    public class MvcCakeContext : DbContext
    {
        public MvcCakeContext (DbContextOptions<MvcCakeContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCake.Models.Cake> Cake { get; set; }
    }
