using Common.DomainDriven.Domain.Entities;
using Common.DomainDriven.Domain.Interfaces;

namespace CarServiceBooking.Domain.Entities;

public class Booking : Entity<Guid>, IAuditable, ISoftDeletable
{
    public Guid VehicleId { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime Bookingdate { get; set; }
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? DateUpdated { get; set; }
    public string UpdatedBy { get; set; }
    public bool Deleted { get; set; }
}