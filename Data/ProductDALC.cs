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
                    pet.Id = item.Id;
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

        
        public List<JEVJ1_MuestraProductos_Result> GetProducts_SP()
        {
            using (DataProductsEntities db = new DataProductsEntities())
            {
                List<JEVJ1_MuestraProductos_Result> lstProd = new List<JEVJ1_MuestraProductos_Result>();
                foreach (var item in db.JEVJ1_MuestraProductos().ToList())
                {
                    JEVJ1_MuestraProductos_Result pet = new JEVJ1_MuestraProductos_Result();
                    pet.Id = item.Id;
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

        
        public List<JEVJ1_BuscaProductoPorID_Result> GetProductById(int pId)
        {
            using (DataProductsEntities db = new DataProductsEntities())
            {
                List<JEVJ1_BuscaProductoPorID_Result> lstProd = new List<JEVJ1_BuscaProductoPorID_Result>();
                foreach (var item in db.JEVJ1_BuscaProductoPorID(pId))
                {
                    if (item.Id == pId)
                    {
                        JEVJ1_BuscaProductoPorID_Result pet = new JEVJ1_BuscaProductoPorID_Result();
                        pet.Id = item.Id;
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
                    
                }

                return lstProd;
            }
        }



        public List<JEVJ1_BuscaProductoPorNombre_Result> GetProductByName(string pName)
        {
            using (DataProductsEntities db = new DataProductsEntities())
            {
                List<JEVJ1_BuscaProductoPorNombre_Result> lstProd = new List<JEVJ1_BuscaProductoPorNombre_Result>();
                foreach (var item in db.JEVJ1_BuscaProductoPorNombre(pName))
                {
                    if (item.Nombre.ToUpper() == pName.ToUpper())
                    {
                        JEVJ1_BuscaProductoPorNombre_Result pet = new JEVJ1_BuscaProductoPorNombre_Result();
                        pet.Id = item.Id;
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

                }

                return lstProd;
            }
        }



        //public void InsertProduct(string pName)
        //{
        //    using(DataProductsEntities db = new DataProductsEntities())
        //    {
        //        db.JEVJ1_InsertaNuevoProducto(null, null, null, null, null, pName, pName, pName, pName, pName, null, null, null, null);
        //    }
        //}

    }
}
