using ECommerceSample.Application.Repositories;
using ECommerceSample.Domain.Entities.Common;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSample.Persistence.Repositories
{
    internal class ReadRepsitory<T> : IReadRepository<T> where T : BaseEntity
    {

        private readonly ECommerceSampleDbContext _context;

        public ReadRepsitory(ECommerceSampleDbContext eCommerceSampleDbContext)
        {
            _context = eCommerceSampleDbContext;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table;

        public async Task<T> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)=>Table.Where(method);   
    }
}
