using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using homework5.Dtos.Car;
using homework5.Interfaces;
using homework5.Services;

namespace homework5.Validators
{
    public class UpdateCarDtoValidator : AbstractValidator<UpdateCarDto>
    {
        public UpdateCarDtoValidator(ICarService carService)
        {
            var reservedBrand = carService.GetAll(0)
                .Cars
                .Select(x => x.Brand);

            RuleFor(x => x.Brand)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(255)
            .Must(n => !reservedBrand.Contains(n))
            .WithMessage("Car Brand must be unique");

            RuleFor(x => x.Model)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(255);

            RuleFor(x => x.Price)
            .NotEmpty()
            .GreaterThan(0);
        }
    }
}
