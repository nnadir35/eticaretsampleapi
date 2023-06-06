using ECommerceSample.Domain.Entities.Common;

namespace ECommerceSample.Domain.Entities;

public class Customer:BaseEntity
{
    public String Name { get; set; }
    public ICollection<Order> Orders { get; set; }
}