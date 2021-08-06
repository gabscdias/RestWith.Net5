using RestWith.Net5.Model;
using System.Collections.Generic;

namespace RestWith.Net5.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);

        void Delete(long id);

        List<Person> FindAll();

        Person FindByID(long id);

        Person Update(Person person);

        bool Exists(long id);
    }
}