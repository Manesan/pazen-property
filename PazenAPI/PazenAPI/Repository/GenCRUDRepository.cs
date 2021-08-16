using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PazenAPI.Data;
using PazenAPI.Models;
using PazenAPI.Repository.IRepository;

namespace PazenAPI.Repository
{
    public class GenCRUDRepository<T> : IGenCRUDRepository<T>
         where T : BaseEntity
    {
        private readonly DataContext db;
        public GenCRUDRepository(DataContext _db)
        {
            db = _db;
        }

        public Task<T> AddAndReturnAsync(T baseEntity)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddAsync(T baseEntity)
        {
            baseEntity.CreatedDate = DateTime.Now;

            await db.Set<T>().AddAsync(baseEntity);
            await db.SaveChangesAsync();
            return baseEntity.Id;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> lines;

            lines = db.Set<T>();

            return lines.AsQueryable();
        }

        public IQueryable<T> GetAll(bool isDeleted, bool isInActive)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByPrimaryKeyAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate, bool isDeleted, bool isInactive)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhereWithInclude(Expression<Func<T, bool>> predicate, string include)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task TrashAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateAsync(T baseEntity)
        {
            db.Set<T>().Update(baseEntity);
            await db.SaveChangesAsync();

            return baseEntity;
        }
    }
}
