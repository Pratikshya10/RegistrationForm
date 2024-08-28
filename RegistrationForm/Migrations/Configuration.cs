namespace RegistrationForm.Migrations
{
    using RegistrationForm.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.Remoting.Contexts;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistrationForm.Models.CustomerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RegistrationForm.Models.CustomerContext context)
        {
            var Customer = new List<CustomerDetails>()
            {
             
            };
           // Context.SaveChanges();
           context.SaveChanges();
        }
    }
}
