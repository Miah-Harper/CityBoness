using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repos
{
    //contains public properties
    public interface IUnitOfWork
    {
        ICategoryRepos Category { get; }

        IProductRepos Product { get; }

        //ICartRepos Cart {get;}
        //IApplicationUser ApplicationUser {get;}
        //IOrderHeaderRepos OrderHeader {get;}
        //IOrderDetailRepos OrderDetail {get;}

        void Save();
    }
   
}
