using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleStore.Data;
using SimpleStore.Models;

namespace SimpleStore.Controllers
{
	//[Authorize(Roles = "Admin")]
	public class ProductController : Controller
	{
		private readonly ApplicationDBContext _context;
        public ProductController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
		{
			var products = _context.Products.ToList();
			return View(products);
		}

		public IActionResult Create()
		{
			return View();
		}

		// POST: /Product/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Product products)
		{
			if (ModelState.IsValid)
			{
				_context.Products.Add(products);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			return View();
		}

		// GET: /Product/Edit/{id}
		public IActionResult Edit(int id)
		{
			var product = _context.Products.Find(id);
			if (product == null)
			{
				return NotFound();
			}
			return View(product);
		}

		// POST: /Product/Edit/{id}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Product product)
		{
			if(ModelState.IsValid)
			{
				_context.Products.Update(product);
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			return View(product);
		}

		// GET: /Product/Delete/{id}
		public IActionResult Delete(int id)
		{
			var product = _context.Products.Find(id);
			if (product == null)
			{
				return NotFound();
			}
			return View(product);
		}

		// POST: /Product/Delete/{id}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteDbData(int id)
		{
			var product = _context.Products.Find(id);
			if (product != null)
			{
				_context.Products.Remove(product);
				_context.SaveChanges();
			}
			return RedirectToAction(nameof(Index));
		}
	}
}
