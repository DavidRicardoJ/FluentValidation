using FluentValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidation.ModelsValidator
{
    public class BeerValidator : AbstractValidator<Beer>
    {
        public BeerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().MinimumLength(3).WithMessage("Nome inválido");
            RuleFor(x => x.Alcohol).NotNull().WithMessage("Valor obrigatório").GreaterThan(0).WithMessage("Valor tem que ser maior que zero.");
            RuleFor(x => x.Brand).NotNull().WithMessage("Campo não pode ser nulo.").MaximumLength(20).NotEqual("Corona").WithMessage("Não pode ser igual a Corona!");
        }


    }
}
