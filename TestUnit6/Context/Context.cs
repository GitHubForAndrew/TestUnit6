using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestUnit6.Models.Data;

namespace TestUnit6.Context
{
    public class Context : DbContext
    {
        public Context() : base("AppConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}