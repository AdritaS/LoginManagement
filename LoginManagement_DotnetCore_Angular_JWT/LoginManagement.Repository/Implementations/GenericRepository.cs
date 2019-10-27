using LoginManagement.Data;
using LoginManagementRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace LoginManagementRepository.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected LoginManagementDbContext _context;
        protected DbSet<T> DbSet;

        public GenericRepository(LoginManagementDbContext context)
        {
            _context = context;
            DbSet = _context.Set<T>();
        }

        public T GetById(object id)
        {
            return DbSet.Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return DbSet.AsEnumerable<T>();
        }
        public T FirstOrDefault(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
                return DbSet.FirstOrDefault();
            else
                return DbSet.FirstOrDefault(predicate);
        }
        public T Add(T entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public T Delete(T entity)
        {
            DbSet.Remove(entity);
            return entity;
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public bool Any(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
                return DbSet.Any();
            else
                return DbSet.Any(predicate);
        }
    }
}
