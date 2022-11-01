using Application.DTOs;
using Domain;
using FluentValidation;


namespace Application.Validators;

public class CreateBoxValidator : AbstractValidator<CreateBoxDTO>
{
    public CreateBoxValidator()
    {
        RuleFor(p => p.ImageUrl).NotNull();
        RuleFor(p => p.Description).NotEmpty();

        RuleFor(p => p.Height).GreaterThan(0);
        RuleFor(p => p.Width).GreaterThan(0);
        RuleFor(p => p.Depth).GreaterThan(0);
        RuleFor(p => p.Thickness).GreaterThan(0);
        RuleFor(p => p.Weight).GreaterThan(0);
    }
}

public class BoxValidator : AbstractValidator<Box>
{
    public BoxValidator()
    {
        RuleFor(p => p.Id).GreaterThan(0);
        RuleFor(p => p.ImageUrl).NotNull();
        RuleFor(p => p.Description).NotEmpty();

        RuleFor(p => p.Height).GreaterThan(0);
        RuleFor(p => p.Width).GreaterThan(0);
        RuleFor(p => p.Depth).GreaterThan(0);
        RuleFor(p => p.Thickness).GreaterThan(0);
        RuleFor(p => p.Weight).GreaterThan(0);
    }
}