using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Supermarket
{

    public class Invoice : IPay
    {
        public Invoice() { }
        
        private List<Product> _products = new List<Product>();
        public decimal ValueToPay()
        {
            decimal AccumulatorProducts = 0;
            foreach(Product item in _products)
            {
                AccumulatorProducts += item.ValueToPay();
            }
            return AccumulatorProducts;

        }
        public override string ToString()
        {
            foreach(Product item in _products)
            {
                Console.WriteLine(item.ToString());
            }
            return $"                       -----------------" +
                $"\nTOTAL:                  {ValueToPay():N2}";
        }

        public void AddProduct(Product product1)
        {
            _products.Add(product1);
        }




    }
}
