using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class ProductBL
    {
        public static List<Product> GetProducts()
        {
            ProductDALC obj = new ProductDALC();
            return obj.GetProducts();
        }


        public static List<JEVJ1_MuestraProductos_Result> GetProducts_SP()
        {
            ProductDALC obj = new ProductDALC();
            return obj.GetProducts_SP();
        }



        public static List<JEVJ1_BuscaProductoPorID_Result> GetProductsById(int pId)
        {
            ProductDALC obj = new ProductDALC();
            return obj.GetProductById(pId);
        }



        public static List<JEVJ1_BuscaProductoPorNombre_Result> GetProductsByName(string pName)
        {
            ProductDALC obj = new ProductDALC();
            return obj.GetProductByName(pName);
        }

        public void InsertProduct(int pIdType, int pIdColor, int pIdBrand, int pIdProvider, int pIdCatalog, string pTitle, string pName, string pDescription, string pObservations, decimal pPriceDistributor, decimal pPriceClient, decimal pPriceMember, bool pIsEnabled, string pKeywords, DateTime pDateUpdate)
        {
            ProductDALC obj = new ProductDALC();
            obj.InsertProduct(pIdType, pIdColor, pIdBrand, pIdProvider, pIdCatalog, pTitle, pName, pDescription, pObservations, pPriceDistributor, pPriceClient, pPriceMember, pIsEnabled, pKeywords, pDateUpdate);
        }

        public void UpdateProduct(int pId, int pIdType, int pIdColor, int pIdBrand, int pIdProvider, int pIdCatalog, string pTitle, string pName, string pDescription, string pObservations, decimal pPriceDistributor, decimal pPriceClient, decimal pPriceMember, bool pIsEnabled, string pKeywords, DateTime pDateUpdate)
        {
            ProductDALC obj = new ProductDALC();
            obj.UpdateProduct(pId, pIdType, pIdColor, pIdBrand, pIdProvider, pIdCatalog, pTitle, pName, pDescription, pObservations, pPriceDistributor, pPriceClient, pPriceMember, pIsEnabled, pKeywords, pDateUpdate);
        }
    }
}
