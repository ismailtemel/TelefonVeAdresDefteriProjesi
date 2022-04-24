using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        // Burada Kullanıcı kayıt sayfası için fluent validation kullanıldı.
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad kısmı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad kısmı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
        }
    }
}
