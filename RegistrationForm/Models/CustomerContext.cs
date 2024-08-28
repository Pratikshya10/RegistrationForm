using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RegistrationForm.Models
{
    public class CustomerContext:DbContext
    {
            public CustomerContext() : base("customerdetails")
        {

        }
        public DbSet<CustomerDetails> CustomerDetails { get; set; } 
    }
}