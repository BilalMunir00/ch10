﻿namespace Uqs.AppointmentBooking.Domain.DomainObjects;

public class Employee : IEntity
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public Shift[]? Shifts { get; set; }
    //public string? Id { get; set; }
    //public string? Name { get; set; }
    //public bool IsActive { get; set; }
    //public short AppointmentTimeSpanInMin { get; set; }
    //public float Price { get; set; }
}
