using Application.DTOs;
using Domain;
using FluentValidation;
using UnitsNet;

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

        RuleFor(p => p.Height).NotNull();
        RuleFor(p => p.Width).NotNull();
        RuleFor(p => p.Depth).NotNull();
        RuleFor(p => p.Thickness).NotNull();
        RuleFor(p => p.Weight).NotNull();

        /*
            temp: optimize json serialization by using double instead of Length and Mass
        */
        RuleFor(p => p.Height).GreaterThan(0);
        RuleFor(p => p.Width).GreaterThan(0);
        RuleFor(p => p.Depth).GreaterThan(0);
        RuleFor(p => p.Thickness).GreaterThan(0);
        RuleFor(p => p.Weight).GreaterThan(0);
        /*
            todo: see Domain.Box.cs constructor

            RuleFor(p => p.Height).GreaterThan(Length.Zero);
            RuleFor(p => p.Width).GreaterThan(Length.Zero);
            RuleFor(p => p.Depth).GreaterThan(Length.Zero);
            RuleFor(p => p.Thickness).GreaterThan(Length.Zero);
            RuleFor(p => p.Weight).GreaterThan(Mass.Zero);
        */
    }
}