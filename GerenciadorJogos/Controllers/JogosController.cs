using GerenciadorJogos.Data;
using GerenciadorJogos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorJogos.Controllers
{
    public class JogosController : Controller
    {
        private readonly AppDbContext _context;

        public JogosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var jogos = await _context.Jogos
                .Include(j => j.JogoPlataformas).ThenInclude(jp => jp.Plataforma)
                .Include(j => j.JogoGeneros).ThenInclude(jg => jg.Genero)
                .ToListAsync();
            return View(jogos);
        }

        public IActionResult Create()
        {
            ViewBag.Plataformas = _context.Plataformas.ToList();
            ViewBag.Generos = _context.Generos.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Titulo,Ano,Capa")] Jogo jogo, List<int> plataformaIds, List<int> generoIds)
        {
            if (string.IsNullOrWhiteSpace(jogo.Titulo))
            {
                ModelState.AddModelError("Titulo", "O título é obrigatório.");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Plataformas = _context.Plataformas.ToList();
                ViewBag.Generos = _context.Generos.ToList();
                return View(jogo);
            }

            _context.Add(jogo);
            await _context.SaveChangesAsync();

            foreach (var plataformaId in plataformaIds)
            {
                _context.JogoPlataformas.Add(new JogoPlataforma { JogoId = jogo.Id, PlataformaId = plataformaId, Valor = 100.00m });
            }
            foreach (var generoId in generoIds)
            {
                _context.JogoGeneros.Add(new JogoGenero { JogoId = jogo.Id, GeneroId = generoId });
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var jogo = await _context.Jogos
                .Include(j => j.JogoPlataformas)
                .Include(j => j.JogoGeneros)
                .FirstOrDefaultAsync(j => j.Id == id);
            if (jogo == null) return NotFound();
            ViewBag.Plataformas = _context.Plataformas.ToList();
            ViewBag.Generos = _context.Generos.ToList();
            ViewBag.SelectedPlataformaIds = jogo.JogoPlataformas.Select(jp => jp.PlataformaId).ToList();
            ViewBag.SelectedGeneroIds = jogo.JogoGeneros.Select(jg => jg.GeneroId).ToList();
            return View(jogo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Ano,Capa")] Jogo jogo, List<int> plataformaIds, List<int> generoIds)
        {
            if (id != jogo.Id) return NotFound();
            if (string.IsNullOrWhiteSpace(jogo.Titulo))
            {
                ModelState.AddModelError("Titulo", "O título é obrigatório.");
            }
            if (!ModelState.IsValid)
            {
                ViewBag.Plataformas = _context.Plataformas.ToList();
                ViewBag.Generos = _context.Generos.ToList();
                ViewBag.SelectedPlataformaIds = plataformaIds;
                ViewBag.SelectedGeneroIds = generoIds;
                return View(jogo);
            }
            _context.Update(jogo);
            var existingPlataformas = _context.JogoPlataformas.Where(jp => jp.JogoId == id).ToList();
            var existingGeneros = _context.JogoGeneros.Where(jg => jg.JogoId == id).ToList();
            _context.JogoPlataformas.RemoveRange(existingPlataformas);
            _context.JogoGeneros.RemoveRange(existingGeneros);
            foreach (var plataformaId in plataformaIds)
            {
                _context.JogoPlataformas.Add(new JogoPlataforma { JogoId = id, PlataformaId = plataformaId, Valor = 100.00m });
            }
            foreach (var generoId in generoIds)
            {
                _context.JogoGeneros.Add(new JogoGenero { JogoId = id, GeneroId = generoId });
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var jogo = await _context.Jogos
                .Include(j => j.JogoPlataformas).ThenInclude(jp => jp.Plataforma)
                .Include(j => j.JogoGeneros).ThenInclude(jg => jg.Genero)
                .FirstOrDefaultAsync(j => j.Id == id);
            if (jogo == null) return NotFound();
            return View(jogo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)  // <-- REMOVA ActionName("Delete")
        {
            var jogo = await _context.Jogos
                .Include(j => j.JogoPlataformas)
                .Include(j => j.JogoGeneros)
                .FirstOrDefaultAsync(j => j.Id == id);

            if (jogo == null) return NotFound();

            _context.JogoPlataformas.RemoveRange(jogo.JogoPlataformas);
            _context.JogoGeneros.RemoveRange(jogo.JogoGeneros);
            _context.Jogos.Remove(jogo);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var jogo = await _context.Jogos
                .Include(j => j.JogoPlataformas).ThenInclude(jp => jp.Plataforma)
                .Include(j => j.JogoGeneros).ThenInclude(jg => jg.Genero)
                .FirstOrDefaultAsync(j => j.Id == id);
            if (jogo == null) return NotFound();
            return View(jogo);
        }
    }
}