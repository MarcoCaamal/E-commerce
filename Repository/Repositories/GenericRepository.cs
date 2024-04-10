using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        public readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity?> GetById(TId id) => await _context.Set<TEntity>().FindAsync(id);

        public IQueryable<TEntity> GetAll() => _context.Set<TEntity>().AsQueryable();

        public async Task<int> HardDelete(TId id)
        {
            TEntity? entity = await GetById(id);
            if (entity is null) return 0;

            _context.Set<TEntity>().Remove(entity);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Insert(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> SoftDelete(TId id)
        {
            TEntity? entity = await GetById(id);
            if (entity == null) return 0;

            entity.IsDeleted = true;
            entity.UpdateAt = DateTime.Now;

            _context.Set<TEntity>().Update(entity);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            return await _context.SaveChangesAsync();
        }
    }
}
