using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Volunteia.Models;

namespace Volunteia.Controllers
{
    public class UserActionsController : Controller
    {
        private readonly AppDbContext _context;

        public UserActionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: UserActions
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.UserActions.Include(u => u.User);
            return View(await appDbContext.ToListAsync());
        }

        // GET: UserActions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAction = await _context.UserActions
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.ActionId == id);
            if (userAction == null)
            {
                return NotFound();
            }

            return View(userAction);
        }

        // GET: UserActions/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email");
            return View();
        }

        // POST: UserActions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActionId,UserId,Foto,Name,Patrocinador,ActionDate,ActionBio,ODS,ActionStatus,VolunteersTotal,NumberOfPeopleHelped,Rate")] UserAction userAction, IFormFile Foto)
        {
            {
                if (Foto != null && Foto.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        await Foto.CopyToAsync(ms);
                        userAction.Foto = ms.ToArray();
                    }
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        var user = await _context.Users.FindAsync(userAction.UserId);
                        if (user == null)
                        {
                            ModelState.AddModelError("UserId", "Invalid UserId");
                            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", userAction.UserId);
                            return View(userAction);
                        }

                        _context.UserActions.Add(userAction);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError(string.Empty, $"An error occurred: {ex.Message}");
                    }
                }

                ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", userAction.UserId);
                return View(userAction);
            }
        }
        // GET: UserActions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAction = await _context.UserActions.FindAsync(id);
            if (userAction == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", userAction.UserId);
            return View(userAction);
        }

        // POST: UserActions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ActionId,UserId,Foto,Name,Patrocinador,ActionDate,ActionBio,ODS,ActionStatus,VolunteersTotal,NumberOfPeopleHelped,Rate")] UserAction userAction)
        {
            if (id != userAction.ActionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userAction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserActionExists(userAction.ActionId))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", userAction.UserId);
            return View(userAction);
        }

        // GET: UserActions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAction = await _context.UserActions
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.ActionId == id);
            if (userAction == null)
            {
                return NotFound();
            }

            return View(userAction);
        }

        // POST: UserActions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userAction = await _context.UserActions.FindAsync(id);
            if (userAction != null)
            {
                _context.UserActions.Remove(userAction);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserActionExists(int id)
        {
            return _context.UserActions.Any(e => e.ActionId == id);
        }
    }
}
