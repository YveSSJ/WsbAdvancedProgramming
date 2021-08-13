using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdvancedProgramming_Lesson4;
using AdvancedProgramming_Lesson4.Data;

namespace AdvancedProgramming_Lesson4.Controllers
{
    public class ChatMessagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChatMessagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChatMessages
        public async Task<IActionResult> Index()
        {
            return View(await _context.Messages.ToListAsync());
        }

        // GET: ChatMessages/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chatMessage = await _context.Messages
                .FirstOrDefaultAsync(m => m.id == id);
            if (chatMessage == null)
            {
                return NotFound();
            }

            return View(chatMessage);
        }

        // GET: ChatMessages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChatMessages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,User,Message")] ChatMessage chatMessage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chatMessage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chatMessage);
        }

        // GET: ChatMessages/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chatMessage = await _context.Messages.FindAsync(id);
            if (chatMessage == null)
            {
                return NotFound();
            }
            return View(chatMessage);
        }

        // POST: ChatMessages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("id,User,Message")] ChatMessage chatMessage)
        {
            if (id != chatMessage.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chatMessage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChatMessageExists(chatMessage.id))
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
            return View(chatMessage);
        }

        // GET: ChatMessages/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chatMessage = await _context.Messages
                .FirstOrDefaultAsync(m => m.id == id);
            if (chatMessage == null)
            {
                return NotFound();
            }

            return View(chatMessage);
        }

        // POST: ChatMessages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var chatMessage = await _context.Messages.FindAsync(id);
            _context.Messages.Remove(chatMessage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChatMessageExists(long id)
        {
            return _context.Messages.Any(e => e.id == id);
        }
    }
}
