using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(0);
            //RuleFor(c => c.Descriptions).Must(StartWithO).WithMessage("Açıklama o harfi ile başlamalı.");
            
        }

        private bool StartWithO(string arg)
        {
            return arg.StartsWith("O");
        }
    }
}
