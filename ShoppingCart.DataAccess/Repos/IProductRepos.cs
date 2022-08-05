using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repos
{
   public interface IProductRepos : IRepos<Product>
    {
        void Update(Product product);
    }
}
