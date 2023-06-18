﻿using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repositories.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View(_unitOfWork.productRepository.GetAll().ToList());
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product? product = _unitOfWork.productRepository.Get(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.productRepository.Update(product);
                _unitOfWork.Save();
                TempData["success"] = "Product updated successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.productRepository.Add(product);
                _unitOfWork.Save();
                TempData["success"] = "Product created successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product? product = _unitOfWork.productRepository.Get(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            _unitOfWork.productRepository.Remove(product);
            _unitOfWork.Save();
            TempData["success"] = "Product deleted successfully!";
            return RedirectToAction("Index");
        }
    }
}