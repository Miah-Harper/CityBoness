using ShoppingCart.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repos
{
    public class UnitOfWork :IUnitOfWork
    {
        private ApplicationDbContext _context;

        public ICategoryRepos Category { get; private set; }

        public IProductRepos Product { get; private set; }

        //public ICategoryRepos Cart {get; private set;}
        //public IApplicateUser ApplicationUser {get; private set;}
        //public IOrderHeaderRepos OrderHeader {get; private set;}
        //public IOrderDetailRepos OrderDetail {get; private set;}

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepos(context);
            Product = new ProductRepos(context);

            //Cart = new CartRepos(context);
            //ApplicationUser = new ApplicationRepos(context);
            //OrderDetail = new OrderDetailRepos(context);
            //OrderHeader = new OrderHeaderRepos(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
        
   
}
