using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerCareAPI.Model;

namespace CustomerCareAPI.Data
{
    public class CustomerCareAPIContext : DbContext
    {
        public CustomerCareAPIContext (DbContextOptions<CustomerCareAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerCareAPI.Model.Message> Message { get; set; }
    }
}
