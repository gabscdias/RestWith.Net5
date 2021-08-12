using RestWith.Net5.Model;
using System.Collections.Generic;

namespace RestWith.Net5.Business
{
    public interface IBooksBusiness
    {
        Books Create(Books books);

        void Delete(long id);

        List<Books> FindAll();

        Books FindByID(long id);

        Books Update(Books books);
    }
}