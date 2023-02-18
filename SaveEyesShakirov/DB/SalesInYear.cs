using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveEyesShakirov.DB
{
    public partial class Agent
    {
        public int SalesCount => ProductSale.Count(a => a.SaleDate >= DateTime.Now.AddYears(-1));

        public int Discount
        {
            get
            {
                var sum = ProductSale.Sum(a => a.ProductCount * a.Product.MinCostForAgent);
                if (sum < 10_000) return 0;
                else if (sum < 50_000) return 5;
                else if (sum < 150_000) return 10;
                else if (sum < 500_000) return 20;
                else return 25;
            }

        }
    }
}
