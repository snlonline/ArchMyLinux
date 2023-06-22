using Common.DomainDriven.Domain.Entities;
using Common.DomainDriven.Domain.Interfaces;

namespace CarServiceBooking.Domain.Entities;

public class Vehicle : Entity<Guid>, IAuditable, ISoftDeletable
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public double Mileage { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? DateUpdated { get; set; }
    public string UpdatedBy { get; set; }
    public bool Deleted { get; set; }
}