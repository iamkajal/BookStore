﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace BookStore.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize]
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IHostingEnvironment _hostingEnvironment;

        public BookController(IBookRepository book, ICategoryRepository category, IHostingEnvironment environment)
        {
            _bookRepo = book;
            _categoryRepo = category;
            _hostingEnvironment = environment;
        }

        //Get: /Dashboard/Book/GetData
        public IActionResult GetData()
        {
            var listItem = _bookRepo.Books;
            var lists = JsonConvert.SerializeObject(
                listItem,
                Formatting.Indented,
                new JsonSerializerSettings() {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
            return Content(lists, "application/json");
        }

        //Get: /Dashboard/Book/_AddOrEdit
        public IActionResult AddOrEdit(int? id)
        {
            var catagories = _categoryRepo.Categories.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(CultureInfo.CurrentCulture),
                Text = a.Name
            }).ToList();
            ViewData["Catagories"] = catagories;

            if (id == null)
            {
                return View();
            }
            else
            {
                var book = _bookRepo.Books.FirstOrDefault(f => f.Id == id);
                return View(book);
            }
        }

        //Post: /Dashboard/Book/_AddOrEdit
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(Models.Book book)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    if (book != null && book.ImgFile != null)
                    {
                        //Destination FileName
                        var fileName = Path.Combine(_hostingEnvironment.WebRootPath + "/images/", Path.GetFileName(book.ImgFile.FileName));
                        FileStream fileStream = new FileStream(fileName, FileMode.Create);
                        //Coping File to Server
                        book.ImgFile.CopyTo(fileStream);
                        book.ImgUrl = "/images/" + Path.GetFileName(fileName);
                    }

                    if (_bookRepo.AddOrEdit(book))
                    {
                        return Json(new { success = true, message = "Saved Successfull" });
                    }
                    else
                    {
                        return Json(new { success = false, message = "Saved Failed" });
                    }
                }

                return Json(new { success = false, message = "Failed" });
            }
            catch (Exception e)
            {
                return Json(new { success = false, message = e.Message });
                throw;
            }
        }

    }
}