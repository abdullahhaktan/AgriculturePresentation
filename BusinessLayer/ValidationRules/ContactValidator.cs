using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("İsim alanı boş bırakılamaz.")
                .MaximumLength(100).WithMessage("İsim en fazla 100 karakter olabilir.");

            RuleFor(x => x.Mail)
                .NotEmpty().WithMessage("Mail adresi boş bırakılamaz.")
                .EmailAddress().WithMessage("Geçerli bir mail adresi giriniz.")
                .MaximumLength(150).WithMessage("Mail en fazla 150 karakter olabilir.");

            RuleFor(x => x.Message)
                .NotEmpty().WithMessage("Mesaj alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("Mesaj en az 10 karakter olmalıdır.")
                .MaximumLength(1000).WithMessage("Mesaj en fazla 1000 karakter olabilir.");

            RuleFor(x => x.Date)
                .NotEmpty()
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Tarih gelecekte olamaz.");
        }
    }
}
