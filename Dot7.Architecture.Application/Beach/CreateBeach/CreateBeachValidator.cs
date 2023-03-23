
using FluentValidation;

namespace Dot7.Architecture.Application.Beach.CreateBeach;

public class CreateBeachValidator : AbstractValidator<CreateBeachRequest>
{
    public CreateBeachValidator()
    {
        RuleFor(x => x.BeachName).NotEmpty();
    }

}