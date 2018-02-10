using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.DB;

namespace Vidly.Repositories
{
    public class CustomerRepository
    {
        private DBContext _context;

        public CustomerRepository()
        {
            _context = new DBContext();
        }

        protected void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }
}