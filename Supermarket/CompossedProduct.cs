using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket;


namespace Supermarket
{
    public class CompossedProduct : Product
    {
        

        public float Discount { get; set; }
        public List<Product> Products = new List<Product>();
        public override decimal ValueToPay()
        {
            decimal AccumulatorProducts = 0;
            foreach (Product item in Products)
            {
                AccumulatorProducts += item.ValueToPay();
            }
            return AccumulatorProducts;

        }

        public override string ToString()
        {
            return
                $"\n{Id} - {Description}, " +
                $"\n\tProduct......:{Products}," +
                $"\n\tDiscount..:   {Discount}" +
                $"\n\tValue........:{ValueToPay():C2}";

            



        } 
    
    
    
    }

    
}
