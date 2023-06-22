using Common.DomainDriven.Domain.Interfaces;
using FluentValidation;
using FluentValidation.Results;

namespace CarServiceBooking.Application.DTOs;

public class BookingDto : IValidatable
{
    public Guid Customerid { get; set; }
    public Guid Vehicleid { get; set; }
    public DateTime BookingDate { get; set; }


    public ValidationResult Validate()
    {
        var validator = new BookingDtoValidator();
        return validator.Validate(this);
    }
}

public class BookingDtoValidator : AbstractValidator<BookingDto>
{
    public BookingDtoValidator()
    {
        RuleFor(x => x.Customerid).NotEmpty();
        RuleFor(x => x.Vehicleid).NotEmpty();
        RuleFor(x => x.BookingDate).NotEmpty();
    }
}