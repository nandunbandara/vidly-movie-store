using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Vidly.Models;

namespace Vidly.DB
{
    public class DBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DBContext()
        {

        }
    }
}