using FastEndpoints;
using FluentValidation;
using Minimalism.Application.Contracts.Requests;

namespace Minimalism.Application.Validators;

public class PutParkingSpotRequestValidator : Validator<PutParkingSpotRequest>
{
    public PutParkingSpotRequestValidator()
    {
        RuleFor(x => x.ParkingId)
            .NotEmpty()
            .WithMessage("parking id is required!");

        RuleFor(x => x.Available)
            .NotNull()
            .WithMessage("available needs to be presented");
        
        RuleFor(x => x.Size)
            .NotNull()
            .WithMessage("size needs to be presented");
        
        RuleFor(x => x.SpotId)
            .NotEmpty()
            .WithMessage("spot id needs to be presented");
    }
}