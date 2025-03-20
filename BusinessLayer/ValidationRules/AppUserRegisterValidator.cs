using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.ComfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");

            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Adınız minimum 3 harften oluşmalıdır.");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Soyadınız minimum 2 harften oluşmalıdır.");
            RuleFor(x => x.UserName).MinimumLength(6).WithMessage("Kullanıcı adınız minimum 6 harften oluşmalıdır.");

            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Adınız maksimum 20 harften oluşmalıdır.");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Soyadınız maksimum 20 harften oluşmalıdır.");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Kullanıcı maksimum minimum 20 harften oluşmalıdır.");

            RuleFor(x => x.Password).Equal(y => y.ComfirmPassword).WithMessage("Şifreler birbiriyle uyuşmuyor");
        }
    }
}
