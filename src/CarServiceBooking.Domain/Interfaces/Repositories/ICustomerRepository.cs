using CarServiceBooking.Domain.Entities;
using Common.DomainDriven.Domain.Interfaces;

namespace CarServiceBooking.Domain.Interfaces.Repositories;

public interface ICustomerRepository : IRepository<Guid, Customer>
{
    
}