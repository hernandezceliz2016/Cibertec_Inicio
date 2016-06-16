using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
           {
               new Client {LastName ="Perez Rodas", Name ="Jose Luis" },
               new Client {LastName ="Perez Alcantara", Name ="Raul" },
               new Client {LastName ="Perez Montenegro", Name ="Luis Alberto" },
               new Client {LastName ="Perez Hernandez", Name ="Patricia" },
               new Client {LastName ="Perez Maytha", Name ="Tania" }
           };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();
        }
    }
}
