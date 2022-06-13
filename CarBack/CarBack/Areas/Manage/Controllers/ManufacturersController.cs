using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarBack.DAL;
using CarBack.Models;

namespace CarBack.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ManufacturersController : Controller
    {
        private readonly AppDbContext _context;

        public ManufacturersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Manufacturer> manufacturers = await _context.Manufacturers.ToListAsync();
            return View(manufacturers );
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                _context.Manufacturers.Add(manufacturer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(manufacturer);
        }
        public async Task<IActionResult> Update(int id)
        {
            var manufacturer = await _context.Manufacturers.FindAsync(id);
            if (manufacturer == null)
                return NotFound();

            return View(manufacturer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Manufacturer manufacturer)
        {
            if (!ModelState.IsValid)
                return View(manufacturer);

            Manufacturer dbmanufacturer = await _context.Manufacturers.FindAsync(manufacturer.Id);
            dbmanufacturer.Name = manufacturer.Name.Trim();
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var manufacturer = await _context.Manufacturers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (manufacturer == null)
                return NotFound();

            _context.Remove(manufacturer);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
