using LibrariryForm.DAL;
using LibrariryForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;

namespace LibrariryForm.Controllers
{
    public class AdminController : Controller
    {
       private readonly AppDbContext _Db;
        public AdminController(AppDbContext Db)
        {
            _Db= Db;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            ViewBag.Page = page;
            ViewBag.Pagecount = Math.Ceiling((decimal)_Db.Users.Count() / 8);
            List<User> users = await _Db.Users.OrderByDescending(x => x.Id).Skip((page - 1) * 8).Take(8).ToListAsync();
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            _Db.Users.Add(user);
            _Db.SaveChanges();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            User user = await _Db.Users.FirstOrDefaultAsync(x => x.Id == id);
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int?id,User user)
        {
            User users = await _Db.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (id == null) return NotFound();
            users.Number=user.Number;
            users.PrivateInfo=user.PrivateInfo;
            users.SeriyaNumber=user.SeriyaNumber;
            users.Adress=user.Adress;
            users.WorkInfo=user.WorkInfo;
            users.BookInfo=user.BookInfo;
            users.Email=user.Email;
            users.Fin=user.Fin;
            await _Db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            User user = await _Db.Users.FirstOrDefaultAsync(x => x.Id == id);
            if(id==null) return NotFound();
            _Db.Remove(user);
            _Db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}