using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private DbSet<TEntity> _entities;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public async Task<int> Delete(int id)
        {
            TEntity entity = _entities.FirstOrDefault(e => e.Id == id)
                ?? throw new ArgumentNullException("entity null");
            _context.Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<TEntity?> Get(int id)
        {
            TEntity? entity = await _entities.FirstOrDefaultAsync(e => e.Id == id);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<int> Insert(TEntity entity)
        {
            _context.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(TEntity entity)
        {
            _context.Update(entity);
            return await _context.SaveChangesAsync();
        }
    }
}
