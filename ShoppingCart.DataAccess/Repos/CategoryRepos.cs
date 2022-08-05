using ShoppingCart.DataAccess.Data;
using ShoppingCart.DataAccess.ViewModels;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repos
{
    public class CategoryRepos : Repository<Category>, ICategoryRepos
    {
        private ApplicationDbContext _context;
        public CategoryRepos(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Add(CategoryVM category)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            var categoryDB = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
            if(categoryDB != null)
            {
                categoryDB.Name = category.Name;
                category.DisplayOrder = category.DisplayOrder;
            }
        }

        public void Update(CategoryVM category)
        {
            throw new NotImplementedException();
        }
    }
}
