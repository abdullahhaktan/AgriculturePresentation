using FluentValidation;
using EntityLayer.Concrete; // SocialMedia sınıfının bulunduğu namespace

public class SocialMediaValidator : AbstractValidator<SocialMedia>
{
    public SocialMediaValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Sosyal medya adı boş geçilemez.")
            .MinimumLength(2).WithMessage("Sosyal medya adı en az 2 karakter olmalıdır.")
            .MaximumLength(50).WithMessage("Sosyal medya adı en fazla 50 karakter olmalıdır.");

        RuleFor(x => x.Icon)
            .NotEmpty().WithMessage("İkon alanı boş geçilemez.")
            .MaximumLength(100).WithMessage("İkon alanı en fazla 100 karakter olmalıdır.");
        RuleFor(x => x.Url)
            .NotEmpty().WithMessage("URL alanı boş geçilemez.");
        RuleFor(x => x.Url)
            .MinimumLength(10).WithMessage("URL en az 10 karakter olmalıdır.");
    }
}