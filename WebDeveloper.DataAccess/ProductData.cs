using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {
        public Product GetProduct(int id)
        {
            using (var dbcontext = new WebContextDb())
            {
                return dbcontext.Products.FirstOrDefault(x => x.ID == id);
            }
        }
        /*Inicio : Pactica de Raizor*/
        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product {ID=1 ,Description="Cristal" ,Price=3.5, Expiration=null},
                new Product {ID=1 , Description="Pilsen" ,Price=0.0 , Expiration=System.DateTime.Now},
                new Product {ID=1 ,Description="Cuzqueña" ,Price=2.6, Expiration =null },
                new Product {ID=1 , Description="Sublime" ,Price=0.0 , Expiration =DateTime.Now},
                new Product {ID=1 ,Description="Coca Cola" ,Price=6.5, Expiration =null },
                new Product {ID=1 , Description="Inka Cola" ,Price=8.6 , Expiration =DateTime.Now}
            };
        }
        /*Final : Pactica de Raizor*/
    }



}
