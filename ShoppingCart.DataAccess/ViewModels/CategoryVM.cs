using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.ViewModels
{
    public class CategoryVM
    {
        public CategoryVM Category { get; set; } = new CategoryVM();

        public IEnumerable<Category> categories { get; set; } = new List<Category>();
        public int Id { get; set; }
    }
}
