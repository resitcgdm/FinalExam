using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class OwnerValidation: AbstractValidator<Owner>
    {
        public OwnerValidation()
        {
            RuleFor(x => x.OwnerName).NotNull().NotEmpty().WithMessage("Ad  Boş geçilemez!").WithMessage("Ad  Boş geçilemez!").
                 MinimumLength(2).WithMessage("Ad  en az 2 karaktere sahip olmalı!").
                 MaximumLength(20).WithMessage("Ad  en fazla 20 karaktere sahip olmalı");
            RuleFor(x => x.OwnerSurName).NotNull().NotEmpty().WithMessage("Soyad  Boş geçilemez!").WithMessage("Soyad Boş geçilemez!").
                MinimumLength(3).WithMessage("Soyad  en az 3 karaktere sahip olmalı!").
                MaximumLength(20).WithMessage("Soyad  en fazla 20 karaktere sahip olmalı");
        }
    }
}
