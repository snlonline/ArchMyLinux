using Common.DomainDriven.Domain.Entities;
using Common.DomainDriven.Domain.Interfaces;

namespace CarServiceBooking.Domain.Entities;

public class Customer : Entity<Guid>, IAuditable, ISoftDeletable
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Idnumber { get; set; }
    public string Cellnumber { get; set; }
    public string Emailaddress { get; set; }
    
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? DateUpdated { get; set; }
    public string UpdatedBy { get; set; }
    public bool Deleted { get; set; }
}