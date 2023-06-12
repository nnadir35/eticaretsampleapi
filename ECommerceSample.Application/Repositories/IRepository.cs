using ECommerceSample.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSample.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {

        DbSet<T> Table { get; }

        Task<T> GetSingleAsync(System.Linq.Expressions.Expression<Func<T, bool>> method);
    }
}
