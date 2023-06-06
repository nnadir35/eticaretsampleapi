using ECommerceSample.Domain.Entities.Common;

namespace ECommerceSample.Domain.Entities;

public class Product:BaseEntity
{
    public String Name { get; set; }
    public int Stock { get; set; }
    public long Price { get; set; }
}