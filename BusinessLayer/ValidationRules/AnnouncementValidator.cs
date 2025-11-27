using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator:AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.")
                .NotNull().WithMessage("Başlık alanı null olamaz.")
                .Length(3, 100).WithMessage("Başlık 3 ile 100 karakter arasında olmalıdır.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.")
                .NotNull().WithMessage("Açıklama alanı null olamaz.")
                .MaximumLength(500).WithMessage("Açıklama en fazla 500 karakter olmalıdır.");

            RuleFor(x => x.Date)
                .NotEmpty().WithMessage("Tarih alanı boş bırakılamaz.")
                .LessThanOrEqualTo(DateTime.Today.AddDays(1)).WithMessage("Tarih gelecekte olamaz (maksimum yarın olabilir).");
        }
    }
}
