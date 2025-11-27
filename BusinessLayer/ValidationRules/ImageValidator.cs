using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(i => i.Title).NotEmpty().WithMessage("Başlık boş olamaz");
            RuleFor(i => i.Description).NotEmpty().WithMessage("Açıklama boş olamaz");
            RuleFor(i => i.ImageUrl).NotEmpty().WithMessage("Görsel url boş olamaz");
            RuleFor(i => i.Title).MinimumLength(8).WithMessage("Lütfen en az 8 karakter girişi yapın");
            RuleFor(i => i.Title).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter girişi yapın");
            RuleFor(i => i.Description).MinimumLength(20).WithMessage("Lütfen en az 20 karakter girişi yapınız");
            RuleFor(i => i.Description).MaximumLength(60).WithMessage("Lütfen en fazla 60 karakter girişi yapınız");

        }
    }
}
