using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace WorkoutHunter.Models
{
    public class userSController : Controller
    {
        private readonly userContext _context;

        public userSController(userContext context)
        {
            _context = context;
        }

        // GET: userS
        public async Task<IActionResult> Index()
        {
            return View(await _context.user_Status.ToListAsync());
        }

        // GET: userS/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Status = await _context.user_Status
                .FirstOrDefaultAsync(m => m.UID == id);
            if (user_Status == null)
            {
                return NotFound();
            }

            return View(user_Status);
        }

        // GET: userS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: userS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UID,Strength,Vitality,Agility,PunishDay")] user_Status user_Status)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user_Status);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user_Status);
        }

        // GET: userS/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Status = await _context.user_Status.FindAsync(id);
            if (user_Status == null)
            {
                return NotFound();
            }
            return View(user_Status);
        }

        // POST: userS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UID,Strength,Vitality,Agility,PunishDay")] user_Status user_Status)
        {
            if (id != user_Status.UID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user_Status);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!user_StatusExists(user_Status.UID))
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
            return View(user_Status);
        }

        // GET: userS/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Status = await _context.user_Status
                .FirstOrDefaultAsync(m => m.UID == id);
            if (user_Status == null)
            {
                return NotFound();
            }

            return View(user_Status);
        }

        // POST: userS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user_Status = await _context.user_Status.FindAsync(id);
            _context.user_Status.Remove(user_Status);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool user_StatusExists(string id)
        {
            return _context.user_Status.Any(e => e.UID == id);
        }
    }
}
