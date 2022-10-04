using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cannot be empty ...!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Please select an image");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Write a description of at least 50 characters");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Please shorten the description");
        }
    }
}
