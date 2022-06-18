using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync(ISpecification<T> specification);

        Task<List<T>> GetAllAsync(ISpecification<T> specification);

        Task DeleteAsnyc(T entity);

        Task<T> FirstOrDefaultAsync(ISpecification<T> specification);

        Task<T> UpdateAsync(T Entity);
    }
}
