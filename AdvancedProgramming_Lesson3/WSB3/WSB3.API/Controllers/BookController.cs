using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WSB3.DB;
using WSB3.Domain;

namespace WSB3.API.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IBookRepository _bookRepository;

        public BookController(ApplicationDbContext context, IConfiguration configuration, IBookRepository bookRepository)
        {
            _context = context;
            _configuration = configuration;
            _bookRepository = bookRepository;
        }
        private static BookDTO bookDTO(BookEntity bookEntity) => new BookDTO
        {
            Id = bookEntity.Id,
            Title = bookEntity.Title,
            Author = bookEntity.Author,
            Genre = bookEntity.Genre
        };

        // GET: api/Book
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDTO>>> GetBookEntity()
        {
            return await _context.BookEntity
                .Select(x => bookDTO(x))
                .ToListAsync();
        }

        // GET: api/Book/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookDTO>> GetBookEntity(long id)
        {
            var bookEntity = await _context.BookEntity.FindAsync(id);

            if (bookEntity == null)
            {
                return NotFound();
            }

            return bookDTO(bookEntity);
        }

        // PUT: api/Book/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookEntity(long id, BookDTO _bookDTO)
        {
            if (id != _bookDTO.Id)
            {
                return BadRequest();
            }

            var bookEntity = await _context.BookEntity.FindAsync(id);
            if (bookEntity == null)
            {
                return NotFound();
            }
            bookEntity.Title = _bookDTO.Title;
            bookEntity.Author = _bookDTO.Author;
            bookEntity.Genre = _bookDTO.Genre;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!BookEntityExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/Book
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookDTO>> PostBookEntity(BookDTO _bookDTO)
        {
            var bookEntity = new BookEntity
            {
                Title = _bookDTO.Title,
                Author = _bookDTO.Author,
                Genre = _bookDTO.Genre
            };
            _context.BookEntity.Add(bookEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetBookEntity),
                new { id = bookEntity.Id }, bookDTO(bookEntity));
        }

        // DELETE: api/Book/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookEntity(long id)
        {
            var bookEntity = await _context.BookEntity.FindAsync(id);
            if (bookEntity == null)
            {
                return NotFound();
            }

            _context.BookEntity.Remove(bookEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookEntityExists(long id)
        {
            return _context.BookEntity.Any(e => e.Id == id);
        }
    }
}
