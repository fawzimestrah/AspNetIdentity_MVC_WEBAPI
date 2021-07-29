using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.IRepositories
{
    public interface IGenericRepos<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetById(int Id);

        Task<T> GetById(string id);

        Task<T> Create(T entity);

        Task<T> Update(T entity);

        Task Delete(int id);
    }
}
