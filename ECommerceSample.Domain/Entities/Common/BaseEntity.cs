﻿namespace ECommerceSample.Domain.Entities.Common;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedTime { get; set; }
}