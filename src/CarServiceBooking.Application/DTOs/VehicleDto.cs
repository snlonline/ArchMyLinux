using Common.DomainDriven.Domain.Interfaces;
using FluentValidation;
using FluentValidation.Results;

namespace CarServiceBooking.Application.DTOs;

public class VehicleDto:IValidatable
{
    public Guid Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Year { get; set; }
    public string Type { get; set; }
    public ValidationResult Validate()
    {
        var validator = new VehicleValidator();
        return validator.Validate(this);
    }
}
public class VehicleValidator : AbstractValidator<VehicleDto>
{
    public VehicleValidator()
    {
        RuleFor(x => x.Make).NotEmpty();
    }
}