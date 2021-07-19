using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkoutHunter.Models;

namespace WorkoutHunter.Controllers
{
    public class userController : Controller
    {
        private readonly userContext _context;

        public userController(userContext context)
        {
            _context = context;
        }

        // GET: user
        public async Task<IActionResult> Index()
        {
            return View(await _context.user_Info.ToListAsync());
        }

        // GET: user/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Info = await _context.user_Info
                .FirstOrDefaultAsync(m => m.UID == id);
            if (user_Info == null)
            {
                return NotFound();
            }

            return View(user_Info);
        }

        // GET: user/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: user/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UID,Email,PassWord,Role,SignDate,Class")] user_Info user_Info)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user_Info);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user_Info);
        }

        // GET: user/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Info = await _context.user_Info.FindAsync(id);
            if (user_Info == null)
            {
                return NotFound();
            }
            return View(user_Info);
        }

        // POST: user/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UID,Email,PassWord,Role,SignDate,Class")] user_Info user_Info)
        {
            if (id != user_Info.UID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user_Info);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!user_InfoExists(user_Info.UID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user_Info);
        }

        // GET: user/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Info = await _context.user_Info
                .FirstOrDefaultAsync(m => m.UID == id);
            if (user_Info == null)
            {
                return NotFound();
            }

            return View(user_Info);
        }

        // POST: user/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user_Info = await _context.user_Info.FindAsync(id);
            _context.user_Info.Remove(user_Info);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool user_InfoExists(string id)
        {
            return _context.user_Info.Any(e => e.UID == id);
        }
    }
}
