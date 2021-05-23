using System.Collections.Generic;


namespace WSB3.Domain
{
    public interface IBookRepository
    {
        bool Add(BookEntity bookEntity);
        bool Delete(BookEntity bookEntity);
        bool Edit(BookEntity bookEntity);
        IEnumerable<BookEntity> GetAll();
    }
}