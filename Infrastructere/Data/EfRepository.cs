using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructere.Data
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;

        public EfRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task DeleteAsnyc(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> FirstOrDefaultAsync(ISpecification<T> specification)
        {
            var entity = await _context.Set<T>().WithSpecification(specification).FirstOrDefaultAsync();
            if (entity == null) return null;
            return entity;
            
        }

        public async Task<List<T>> GetAllAsync(ISpecification<T> specification)
        {
            var entityList = await _context.Set<T>().ToListAsync(specification);
            if (entityList == null) return null;
            return entityList;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _context.FindAsync<T>(id);
            if (entity == null) return null;
            return entity;
        }

        public async Task<T> GetByIdAsync(ISpecification<T> specification)
        {

            var entity = await _context.Set<T>().WithSpecification(specification).FirstOrDefaultAsync();
            if (entity != null)
            {
                return entity;
            }
            return null;
        }

        public async Task<T> UpdateAsync(T Entity)
        {
            _context.Update(Entity);
            await _context.SaveChangesAsync();
            return Entity;
        }
    }
}
