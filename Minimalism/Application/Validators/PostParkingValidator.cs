using FastEndpoints;
using FluentValidation;
using Minimalism.Application.Contracts.Requests;

namespace Minimalism.Application.Validators;

public class PostParkingValidator : Validator<PostParkingRequest>
{
    public PostParkingValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("parking name is required!")
            .MinimumLength(2)
            .WithMessage("parking name is too short!");
        
        RuleFor(x => x.NumberOfSlots)
            .NotEmpty()
            .WithMessage("you must specify number of slots in parking")
            .LessThanOrEqualTo(0)
            .WithMessage("it must be greater than zero");
    }
}