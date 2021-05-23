using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WSB3.Domain;

namespace WSB3.DB
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private DbSet<BookEntity> Books { get; set; }

        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Books = dbContext.BookEntity;
        }

        public IEnumerable<BookEntity> GetAll()
        {
            return Books;
        }
        public bool Add(BookEntity bookEntity)
        {
            Books.Add(bookEntity);
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(BookEntity bookEntity)
        {
            Books.Remove(bookEntity);
            return _dbContext.SaveChanges() > 0;

        }
        public bool Edit(BookEntity bookEntity)
        {
            Books.Update(bookEntity);
            return _dbContext.SaveChanges() > 0;

        }
    }
}
