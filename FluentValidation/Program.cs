using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Models;
using FluentValidation.ModelsValidator;
using FluentValidation.Results;

namespace FluentValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            var beer = new Beer()
            {
                Name = "Tremens",
                Alcohol = 0,
                Brand = "Corona"
            };

            var validator = new BeerValidator();
            ValidationResult result = validator.Validate(beer);

            if (!result.IsValid)
            {
                result.Errors.ForEach(x => Console.WriteLine(x.ErrorMessage));
            }
            else Console.WriteLine("Ok!");


            Console.ReadLine();
        }
    }
}
