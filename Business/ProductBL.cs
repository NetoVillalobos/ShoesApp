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
    }
}
