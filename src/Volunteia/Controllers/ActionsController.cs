using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Volunteia.Models;
using Action = Volunteia.Models.Action;

namespace Volunteia.Controllers
{
    public class ActionsController : Controller
    {
        private readonly AppDbContext _context;

        // Construtor que recebe o contexto do banco de dados
        public ActionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Actions
        // Ação para listar todas as ações
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Actions.Include(a => a.User); // Inclui informações do usuário
            return View(await appDbContext.ToListAsync()); // Retorna a lista de ações
        }

        // GET: Actions/Details/5
        // Ação para visualizar detalhes de uma ação
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound(); // Retorna 404 se o ID for nulo

            var action = await _context.Actions
                .Include(a => a.User) // Inclui informações do usuário
                .FirstOrDefaultAsync(m => m.ActionId == id); // Busca a ação pelo ID
            if (action == null) return NotFound(); // Retorna 404 se a ação não for encontrada

            return View(action); // Retorna a view com os detalhes da ação
        }

        // GET: Actions/Create
        // Ação para exibir o formulário de criação de uma nova ação
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email"); // Popula o dropdown com usuários
            return View(); // Retorna a view de criação
        }

        // POST: Actions/Create
        // Ação para processar a criação de uma nova ação
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActionId,UserId,Foto,Name,Patrocinador,ActionDate,ActionBio,ODS,VolunteersTotal,Alcance")] Action action)
        {
            if (ModelState.IsValid)
            {
                _context.Add(action); // Adiciona a nova ação ao contexto
                await _context.SaveChangesAsync(); // Salva as alterações no banco de dados
                return RedirectToAction(nameof(Index)); // Redireciona para a lista de ações
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", action.UserId); // Re-popula o dropdown em caso de erro
            return View(action); // Retorna a view com os dados da ação se houver erro
        }

        // GET: Actions/Edit/5
        // Ação para exibir o formulário de edição de uma ação existente
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound(); // Retorna 404 se o ID for nulo

            var action = await _context.Actions.FindAsync(id); // Busca a ação pelo ID
            if (action == null) return NotFound(); // Retorna 404 se a ação não for encontrada

            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", action.UserId); // Popula o dropdown com usuários
            return View(action); // Retorna a view de edição
        }

        // POST: Actions/Edit/5
        // Ação para processar a edição de uma ação existente
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ActionId,UserId,Foto,Name,Patrocinador,ActionDate,ActionBio,ODS,VolunteersTotal,Alcance")] Action action)
        {
            if (id != action.ActionId) return NotFound(); // Retorna 404 se o ID não corresponder

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(action); // Atualiza a ação no contexto
                    await _context.SaveChangesAsync(); // Salva as alterações
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActionExists(action.ActionId)) return NotFound(); // Retorna 404 se a ação não for encontrada
                    throw; // Re-lança a exceção se ocorrer outro erro
                }
                return RedirectToAction(nameof(Index)); // Redireciona para a lista de ações
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", action.UserId); // Re-popula o dropdown em caso de erro
            return View(action); // Retorna a view com os dados da ação se houver erro
        }

        // GET: Actions/Delete/5
        // Ação para exibir a confirmação de exclusão de uma ação
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound(); // Retorna 404 se o ID for nulo

            var action = await _context.Actions
                .Include(a => a.User) // Inclui informações do usuário
                .FirstOrDefaultAsync(m => m.ActionId == id); // Busca a ação pelo ID
            if (action == null) return NotFound(); // Retorna 404 se a ação não for encontrada

            return View(action); // Retorna a view de confirmação de exclusão
        }

        // POST: Actions/Delete/5
        // Ação para processar a exclusão de uma ação
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var action = await _context.Actions.FindAsync(id); // Busca a ação pelo ID
            if (action != null)
            {
                _context.Actions.Remove(action); // Remove a ação do contexto
                await _context.SaveChangesAsync(); // Salva as alterações
            }
            return RedirectToAction(nameof(Index)); // Redireciona para a lista de ações
        }

        // Método privado para verificar se uma ação existe
        private bool ActionExists(int id)
        {
            return _context.Actions.Any(e => e.ActionId == id); // Retorna verdadeiro se a ação existir
        }
    }
}
