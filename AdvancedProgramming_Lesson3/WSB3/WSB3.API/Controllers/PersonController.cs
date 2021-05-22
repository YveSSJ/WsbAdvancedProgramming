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
    [Route("api/Person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IPersonRepository _personRepository;
        private static PersonDTO personDTO(PersonEntity personEntity) => new PersonDTO
        {
            Id = personEntity.Id,
            FirstName = personEntity.FirstName,
            LastName = personEntity.LastName
        };

        public PersonController(ApplicationDbContext context, IPersonRepository personRepository, IConfiguration configuration)
        {
            _context = context;
            _personRepository = personRepository;
            _configuration = configuration;
        }

        // GET: api/Person
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonDTO>>> GetPersonEntity()
        {
            return await _context.PersonEntity
                .Select(x => personDTO(x))
                .ToListAsync();
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonDTO>> GetPersonEntity(long id)
        {
            var personEntity = await _context.PersonEntity.FindAsync(id);

            if (personEntity == null)
            {
                return NotFound();
            }

            return personDTO(personEntity);
        }

        // PUT: api/Person/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePersonEntity(long id, PersonDTO _personDTO)
        {
            if (id != _personDTO.Id)
            {
                return BadRequest();
            }

            var personEntity = await _context.PersonEntity.FindAsync(id);
            if (personEntity == null)
            {
                return NotFound();
            }
            personEntity.FirstName = _personDTO.FirstName;
            personEntity.LastName = _personDTO.LastName;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!PersonEntityExists(id))
            {
                return NotFound();
            }
            return NoContent();
        }

        // POST: api/Person
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonDTO>> CreatePersonEntity(PersonDTO _personDTO)
        {
            var personEntity = new PersonEntity
            {
                FirstName = _personDTO.FirstName,
                LastName = _personDTO.LastName
            };
            _context.PersonEntity.Add(personEntity);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
            nameof(GetPersonEntity),
            new { id = personEntity.Id },
            personDTO(personEntity));
        }

        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonEntity(long id)
        {
            var personEntity = await _context.PersonEntity.FindAsync(id);
            if (personEntity == null)
            {
                return NotFound();
            }

            _context.PersonEntity.Remove(personEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonEntityExists(long id)
        {
            return _context.PersonEntity.Any(e => e.Id == id);
        }
    }
}
