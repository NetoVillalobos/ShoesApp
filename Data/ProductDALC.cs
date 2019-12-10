using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductDALC
    {
        public List<Products> GetProducts()
        {

            using (DataProductsEntities db = new DataProductsEntities())
            {
                List<Products> lstProd = new List<Products>();
                foreach (var item in db.Products.ToList())
                {
                    Products pet = new Products();
                    pet.IdType = item.IdType;
                    pet.IdColor = item.IdColor;
                    pet.IdBrand = item.IdBrand;
                    pet.IdProvider = item.IdProvider;
                    pet.IdCatalog = item.IdCatalog;
                    pet.Title = item.Title;
                    pet.Nombre = item.Nombre;
                    pet.Description = item.Description;
                    pet.Observations = item.Observations;
                    pet.PriceDistributor = item.PriceDistributor;
                    pet.PriceClient = item.PriceClient;
                    pet.PriceMember = item.PriceMember;
                    pet.IsEnabled = item.IsEnabled;
                    pet.Keywords = item.Keywords;
                    pet.DateUpdate = item.DateUpdate;

                    lstProd.Add(pet);
                }

                return lstProd;
            }
        }
    }
}
