using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator: AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım Arkadaşı boş geçemezsiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev kısmını boş geçemezsiniz");
            RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Resim yolu boş geçilemez");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapın");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("lütfen en az 5 karakter veri girişi yapın");
            RuleFor(x=>x.Title).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapın");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen 3 karakterden fazla veri girişi yapın");
        }
    }
}
