using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Code_.Data;
using Code_.Models;

namespace Code_.Controllers
{
    public class AbilityController : Controller
    {
        private readonly MvcAbilityContext _context;

        public AbilityController(MvcAbilityContext context)
        {
            _context = context;
        }

        // GET: Ability
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ability.ToListAsync());
        }

        // GET: Ability/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ability = await _context.Ability
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ability == null)
            {
                return NotFound();
            }

            return View(ability);
        }

        // GET: Ability/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ability/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title")] Ability ability)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ability);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ability);
        }

        // GET: Ability/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ability = await _context.Ability.FindAsync(id);
            if (ability == null)
            {
                return NotFound();
            }
            return View(ability);
        }

        // POST: Ability/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title")] Ability ability)
        {
            if (id != ability.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ability);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AbilityExists(ability.Id))
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
            return View(ability);
        }

        // GET: Ability/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ability = await _context.Ability
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ability == null)
            {
                return NotFound();
            }

            return View(ability);
        }

        // POST: Ability/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ability = await _context.Ability.FindAsync(id);
            _context.Ability.Remove(ability);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AbilityExists(int id)
        {
            return _context.Ability.Any(e => e.Id == id);
        }
    }
}
