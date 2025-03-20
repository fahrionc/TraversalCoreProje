using DTOLayer.DTOs.AnnouncemenetDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncemenetValidator : AbstractValidator<AnnouncemenetAddDTO>
    {
        public AnnouncemenetValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyin");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen duyuru içeriğini boş geçmeyin");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen başlığa en az 5 karakter veri girişi yapınız");
            RuleFor(x => x.Content).MinimumLength(15).WithMessage("Lütfen duyuruya en az 15 karakter veri girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(25).WithMessage("Lütfen başlığa en fazla 25 karakter veri girişi yapınız");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen duyuruya en fazla 500 karakter veri girişi yapınız");
        }
    }
}
