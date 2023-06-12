using ECommerceSample.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSample.Application.Repositories
{
    internal interface IWriteRepository<T>:IRepository<T> where T : BaseEntity
    {    
        Task<bool> AddAsync(T entity);
        Task<bool> AddAsync(List<T> list);
        Task<bool> Remove(T entity);   
        Task<bool> Remove(string id);
        Task<bool> UpdateAsync(T entity);       
        
    }
}
