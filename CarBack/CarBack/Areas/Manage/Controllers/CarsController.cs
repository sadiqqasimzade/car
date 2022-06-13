using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarBack.DAL;
using CarBack.Models;
using CarBack.Utilites;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace CarBack.Areas.Manage.Controllers
{
    [Area("Manage")][Authorize]
    public class CarsController : Controller
    {
        private readonly AppDbContext _context;

        public CarsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Cars.Include(c => c.Manufacturer).Take(5).ToListAsync());
        }


        public IActionResult Create()
        {
            ViewBag.ManufacturerList = new SelectList(_context.Manufacturers, nameof(Manufacturer.Id), nameof(Manufacturer.Name));
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Car car)
        {
            if (car.File == null)
            {
                ViewBag.ManufacturerList = new SelectList(_context.Manufacturers, nameof(Manufacturer.Id), nameof(Manufacturer.Name));
                ModelState.AddModelError("File", "File must exit");
                return View(car);
            }
            if (car.File.Length / 1024 > Consts.CarImgMaxSizeKb)
            {
                ViewBag.ManufacturerList = new SelectList(_context.Manufacturers, nameof(Manufacturer.Id), nameof(Manufacturer.Name));
                ModelState.AddModelError("File", "Too big must be smaller than:" + Consts.CarImgMaxSizeKb + "Kb");
                return View(car);
            }
            if (!car.File.ContentType.Contains("image"))
            {
                ViewBag.ManufacturerList = new SelectList(_context.Manufacturers, nameof(Manufacturer.Id), nameof(Manufacturer.Name));
                ModelState.AddModelError("File", "Invalid type");
                return View(car);
            }
            if (!ModelState.IsValid)
            {
                ViewBag.ManufacturerList = new SelectList(_context.Manufacturers, nameof(Manufacturer.Id), nameof(Manufacturer.Name));
                return View(car);
            }

            string filename = Guid.NewGuid().ToString() + car.File.FileName;
            if (filename.Length > Consts.CarImgNameMaxLength)
                filename = filename.Substring(filename.Length - Consts.CarImgNameMaxLength, Consts.CarImgNameMaxLength);

            using (FileStream fs = new FileStream(Path.Combine(Consts.CarImgPath, filename), FileMode.Create))
                await car.File.CopyToAsync(fs);

            car.Img = filename;
            car.Name = car.Name.Trim();
            car.Model = car.Model.Trim();

            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
                return NotFound();

            ViewBag.ManufacturerList = new SelectList(_context.Manufacturers, nameof(Manufacturer.Id), nameof(Manufacturer.Name));
            return View(car);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Car car)
        {
          
            if (!ModelState.IsValid)
            {
                ViewBag.ManufacturerList = new SelectList(_context.Manufacturers, nameof(Manufacturer.Id), nameof(Manufacturer.Name));
                return View(car);
            }
            Car dbcar =await _context.Cars.FindAsync(car.Id);
            dbcar.AirCondition = car.AirCondition;
            dbcar.AutoTransmission = car.AutoTransmission;
            dbcar.Doors = car.Doors;
            dbcar.Luggage = car.Luggage;
            dbcar.Seats = car.Seats;
            dbcar.Name = car.Name.Trim();
            dbcar.Model = car.Model.Trim();
            dbcar.ManufacturerId = car.ManufacturerId;
            dbcar.Price = car.Price;
            if (car.File != null)
            {
                if (car.File.Length / 1024 < Consts.CarImgMaxSizeKb || car.File.ContentType.Contains("image"))
                {
                    if (System.IO.File.Exists(Path.Combine(Consts.CarImgPath, dbcar.Img)))
                        System.IO.File.Delete(Path.Combine(Consts.CarImgPath, dbcar.Img));

                    string filename = Guid.NewGuid().ToString() + car.File.FileName;
                    if (filename.Length > Consts.CarImgNameMaxLength)
                        filename = filename.Substring(filename.Length - Consts.CarImgNameMaxLength, Consts.CarImgNameMaxLength);

                    using (FileStream fs = new FileStream(Path.Combine(Consts.CarImgPath, filename), FileMode.Create))
                        await car.File.CopyToAsync(fs);

                    dbcar.Img = filename;
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null) return NotFound();

            if(System.IO.File.Exists(Path.Combine(Consts.CarImgPath,car.Img)))
                System.IO.File.Delete(Path.Combine(Consts.CarImgPath, car.Img));

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
