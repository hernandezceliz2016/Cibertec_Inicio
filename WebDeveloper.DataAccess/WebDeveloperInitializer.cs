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
            /*Agregar productos*/
            var Products = new List<Product>
            {
                new Product {Name ="IOR EPOCIM",Description="Eritropoyetina Humana Recombinante tipo alfa" , Expiration=null,Price=12.36d},
                new Product {Name ="CIMAvax-EGF", Description="Conjugado Regf - Rp64k" , Expiration= DateTime.Parse("20/06/2016"),Price=5789.36d },
                new Product {Name ="HELIXOR P",Description="Extracto de Viscum album ssp. Austriacum" , Expiration=null,Price=12.36d},
                new Product {Name ="COLISTINA", Description="Metansulfonato de sodio 256 mg equivalente en base" , Expiration= DateTime.Parse("20/06/2016"),Price=5789.36d },
                new Product {Name ="KLEAN PREP",Description="Macrogol 3350 + Electrolitos" , Expiration=null,Price=12.36d},
                new Product {Name ="HEBERPROT P - 75", Description="Factor de crecimiento epidermico humano recombinante" , Expiration= DateTime.Parse("20/06/2016"),Price=5789.36d }
            };
            Products.ForEach(c => context.Products.Add(c));
            context.SaveChanges();

        }
    }
}
