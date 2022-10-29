using Application.DTOs;
using Domain;
using FluentValidation;


namespace Application.Validators;

public class CreateBoxValidator : AbstractValidator<CreateBoxDTO>
{
    public CreateBoxValidator()
    {
      
    }
}

public class BoxValidator : AbstractValidator<Box>
{
    public BoxValidator()
    {
        RuleFor(p => p.Id).GreaterThan(0);
        RuleFor(p => p.Price).GreaterThanOrEqualTo(0);
        RuleFor(p => p.Quantity).GreaterThanOrEqualTo(0);
        RuleFor(p => p.Tags).NotEmpty();
        RuleFor(p => p.ImageUrl).NotNull();
        RuleFor(p => p.Description).NotEmpty();
        RuleFor(p => p.Tags).Must(t => t.Count <= 5);
        RuleFor(p => p.Tags).Must(t => t.All(tag => tag.Length <= 20));

        RuleFor(p => p.Height).GreaterThan(0);
        RuleFor(p => p.Width).GreaterThan(0);
        RuleFor(p => p.Depth).GreaterThan(0);
        RuleFor(p => p.Thickness).GreaterThan(0);
        RuleFor(p => p.Weight).GreaterThan(0);
    }
}