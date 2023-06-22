using Common.DomainDriven.Domain.Interfaces;
using FluentValidation;
using FluentValidation.Results;

namespace CarServiceBooking.Application.DTOs;

public class CustomerDto: IValidatable
{
    public Guid Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Idnumber { get; set; }
    public string Cellnumber { get; set; }
    public string Emailaddress { get; set; }
    
    public ValidationResult Validate()
    {
        var validator = new CustomerDtoValidator();
        return validator.Validate(this);
    }
}
public class CustomerDtoValidator : AbstractValidator<CustomerDto>
{
    public CustomerDtoValidator()
    {
        RuleFor(x => x.Firstname).NotEmpty();
    }
}