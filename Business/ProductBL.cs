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
        public static List<Products> GetProducts()
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
    }
}
