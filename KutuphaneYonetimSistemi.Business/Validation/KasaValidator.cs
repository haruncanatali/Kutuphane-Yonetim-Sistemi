using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Business.Validation
{
    public class KasaValidator:AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            this.RuleFor(c => c.Ay).NotNull().WithMessage("Ay boş olamaz.").Length(1, 20)
                .WithMessage("Ay alanı [1-20] karakter aralığında olmalıdır.");
            this.RuleFor(c => c.Yil).NotNull().WithMessage("Yıl boş olamaz.").Length(1, 4)
                .WithMessage("Ay alanı [1-4] karakter aralığında olmalıdır.");
            this.RuleFor(c => c.Tutar).NotNull().WithMessage("Tutar alanı boş olamaz.");
        }
    }
}
