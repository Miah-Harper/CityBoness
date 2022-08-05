using ShoppingCart.DataAccess.ViewModels;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repos
{
    public interface ICategoryRepos : IRepos<Category>
    {
        void Update(Category category);
        void Add(CategoryVM category);
        void Update(CategoryVM category);
    }
    
}
