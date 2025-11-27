using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{


    namespace BusinessLayer.ValidationRules
    {
        public class AddressValidator : AbstractValidator<Address>
        {
            public AddressValidator()
            {
                RuleFor(x => x.Description1)
                    .NotEmpty().WithMessage("Açıklama 1 boş geçilemez.")
                    .MaximumLength(250).WithMessage("Açıklama 1 en fazla 250 karakter olabilir.");

                RuleFor(x => x.Description2)
                    .NotEmpty().WithMessage("Açıklama 2 boş geçilemez.")
                    .MaximumLength(250).WithMessage("Açıklama 2 en fazla 250 karakter olabilir.");

                RuleFor(x => x.Description3)
                    .NotEmpty().WithMessage("Açıklama 3 boş geçilemez.")
                    .MaximumLength(250).WithMessage("Açıklama 3 en fazla 250 karakter olabilir.");

                RuleFor(x => x.PhoneNumber)
                    .NotEmpty().WithMessage("Telefon numarası boş geçilemez.").Length(14).WithMessage("Lütfen telefon numarasını eksiksiz giriniz");

                RuleFor(x => x.MapInfo)
                    .NotEmpty().WithMessage("Harita bilgisi boş geçilemez.")
                    .MaximumLength(500).WithMessage("Harita bilgisi en fazla 500 karakter olabilir.");
            }
        }
    }

}
