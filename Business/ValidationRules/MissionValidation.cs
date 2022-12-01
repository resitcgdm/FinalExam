using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class MissionValidation:AbstractValidator<Mission>
    {
        public MissionValidation()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Başlık  Boş geçilemez!").WithMessage("Başlık  Boş geçilemez!").
                  MinimumLength(2).WithMessage("Başlık  en az 2 karaktere sahip olmalı!").
                  MaximumLength(20).WithMessage("Başlık  en fazla 20 karaktere sahip olmalı");
            RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("Açıklama  Boş geçilemez!").WithMessage("Açıklama Boş geçilemez!").
                MinimumLength(3).WithMessage("Açıklama  en az 3 karaktere sahip olmalı!").
                MaximumLength(50).WithMessage("Açıklama  en fazla 50 karaktere sahip olmalı");
        }    
    }
}
