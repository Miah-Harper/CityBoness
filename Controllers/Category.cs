﻿using Microsoft.AspNetCore.Mvc;
using ShoppingCart.DataAccess.Repos;
using ShoppingCart.DataAccess.ViewModels;

namespace CityBoness.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private IUnitOfWork _unitofwork;

        public CategoryController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public IActionResult Index()
        {
            CategoryVM categoryVM = new CategoryVM();
            categoryVM.categories = _unitofwork.Category.GetAll();
            return View(categoryVM);
        }

        [HttpGet]
        public IActionResult CreateUpdate(int? id)
        {
            CategoryVM vm = new CategoryVM();
            if(id == null || id == 0)
            {
                return View(vm);
;           }

            else
            {
                var categoryVM = _unitofwork.Category.GetT(x => x.Id == id);
                if(categoryVM == null)
                {
                    return NotFound();
                }

                else
                {
                    return View(vm);
                }
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult CreateUpdate(CategoryVM vm)
        {
            if(ModelState.IsValid)
            {
                if(vm.Category.Id ==0 )
                {
                    _unitofwork.Category.Add(vm.Category);
                    TempData["success"] = "Category Created Done!";
                }

                else
                {
                    _unitofwork.Category.Update(vm.Category);
                    TempData["success"] = "Category Updated Done!";
                }

                _unitofwork.Save();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = _unitofwork.Category.GetT(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        
        
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteData(int? id)
        {

            var category = _unitofwork.Category.GetT(x => x.Id == id);
            if(category == null)
            {
                return NotFound();
            }
            _unitofwork.Category.Delete(category);
            _unitofwork.Save();
            TempData["success"] = "Category Deleted Done!";
            return RedirectToAction("Index");
        }
    }
}
