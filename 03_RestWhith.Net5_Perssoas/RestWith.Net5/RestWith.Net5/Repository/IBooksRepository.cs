using RestWith.Net5.Model;
using System.Collections.Generic;

namespace RestWith.Net5.Repository
{
    public interface IBooksRepository
    {
        Books Create(Books books);

        void Delete(long id);

        List<Books> FindAll();

        Books FindByID(long id);

        Books Update(Books books);

        bool Exists(long id);
    }
}