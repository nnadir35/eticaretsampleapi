using ECommerceSample.Domain.Entities.Common;

namespace ECommerceSample.Domain.Entities;

public class Order:BaseEntity
{
    public ICollection<Product> Products { get; set; }
    public Customer Customer { get; set; }
}