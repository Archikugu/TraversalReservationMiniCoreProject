using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please enter the guide name");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please enter the guide description");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please enter the guide photo");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Up to 30 characters can be written");


        }
    }
}
