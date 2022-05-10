using MVCWithEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEF.Context
{
    public class AppDbContext  : DbContext
    {
        public DbSet<Batch> Batches { get; set; }
    }
}