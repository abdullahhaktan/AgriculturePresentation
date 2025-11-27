using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AdminValidator:AbstractValidator<Admin>
    {
        public AdminValidator() 
        {
            RuleFor(x => x.AdminUserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez").MinimumLength(8).WithMessage("En az 8 karakter girişi olmalı").MaximumLength(50).WithMessage("50 karakterden fazla giriş yapılmaz");
            RuleFor(x => x.AdminPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez").MinimumLength(8).WithMessage("En az 8 karakter girişi olmalı").MaximumLength(50).WithMessage("50 karakterden fazla giriş yapılmaz");
        }
    }
}
