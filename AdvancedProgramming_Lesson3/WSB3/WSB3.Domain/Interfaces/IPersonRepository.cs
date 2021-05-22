using System.Collections.Generic;


namespace WSB3.Domain
{
    public interface IPersonRepository
    {
        bool Add(PersonEntity personEntity);
        bool Delete(PersonEntity personEntity);
        bool Edit(PersonEntity personEntity);
        IEnumerable<PersonEntity> GetAll();
    }
}