using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Volunteia.Models;

namespace Volunteia.Controllers
{
    public class UserActionsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly HttpClient _httpClient;

        public UserActionsController(AppDbContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;   
        }

        // GET: UserActions
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserActions.ToListAsync());
        }

        // GET: UserActions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAction = await _context.UserActions
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
            return View();
        }

        // POST: UserActions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActionId,Name,Patrocinador,ActionDate,ActionBio,ODS,ActionStatus,VolunteersTotal,NumberOfPeopleHelped,Rate")] UserAction userAction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userAction);
                await _context.SaveChangesAsync();
                
                var actionService = new ActionService(userAction, _httpClient); // Supondo que você tenha um construtor adequado
                var result = await actionService.PublishActionAsync(userAction.Name, userAction.ActionBio);

                if (result.Equals("Aprovado"))
                {
                    userAction.ActionStatus = ActionStatus.Ativa;
                    _context.UserActions.Update(userAction);
                    await _context.SaveChangesAsync();
                    return Ok($"Ação aprovada e publicada. {result}");
                }
                else
                {
                    userAction.ActionStatus = ActionStatus.Aguardandoaprovação;
                    return Ok($"Ação aguardando moderação. {result}");
                }
                //return RedirectToAction(nameof(Index));
            }

            return View(userAction);
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
            return View(userAction);
        }

        // POST: UserActions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ActionId,Name,Patrocinador,ActionDate,ActionBio,ODS,ActionStatus,VolunteersTotal,NumberOfPeopleHelped,Rate")] UserAction userAction)
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
