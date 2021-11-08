using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Business.Validation
{
    public class YazarValidator:AbstractValidator<Yazar>
    {
        public YazarValidator()
        {
            this.RuleFor(c => c.Ad).NotNull().WithMessage("Ad alanı boş geçilemez.").Length(1, 50)
                .WithMessage("Ad alanı [1-50] karakter aralığından oluşmak zorundadır.");
            this.RuleFor(c => c.Soyad).NotNull().WithMessage("Soyad alanı boş geçilemez.").Length(1, 50)
                .WithMessage("Soyad alanı [1-50] karakter aralığından oluşmak zorundadır.");
            this.RuleFor(c => c.Detay).Length(1, 2500).WithMessage("Detay alanı [1-2500] karakter aralığından oluşmak zorundadır.");
        }
    }
}
