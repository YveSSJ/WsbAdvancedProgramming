using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WSB3.Domain;

namespace WSB3.DB
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private DbSet<PersonEntity> People { get; set; }

        public PersonRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            People = dbContext.PersonEntity;
        }

        public IEnumerable<PersonEntity> GetAll()
        {
            return People;
        }
        public bool Add(PersonEntity personEntity)
        {
            People.Add(personEntity);
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(PersonEntity personEntity)
        {
            People.Remove(personEntity);
            return _dbContext.SaveChanges() > 0;

        }
        public bool Edit(PersonEntity personEntity)
        {
            People.Update(personEntity);
            return _dbContext.SaveChanges() > 0;

        }
    }
}
