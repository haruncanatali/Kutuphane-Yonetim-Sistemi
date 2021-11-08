using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Business.Validation
{
    public class UyeValidator:AbstractValidator<Uye>
    {
        public UyeValidator()
        {
            this.RuleFor(c => c.Ad).NotNull().WithMessage("Ad alanı boş geçilemez.").Length(1, 50)
                .WithMessage("Ad alanı [1-50] karakter aralığında olmalıdır.");
            this.RuleFor(c => c.Soyad).NotNull().WithMessage("Soyad alanı boş geçilemez.").Length(1, 50)
                .WithMessage("Soyad alanı [1-50] karakter aralığında olmalıdır.");
            this.RuleFor(c => c.Mail).Length(1, 150).WithMessage("Mail alanı [1-150] karakter aralığında olmalıdır.");
            this.RuleFor(c => c.KullaniciAdi).NotNull().WithMessage("Kullanıcı adı alanı boş geçilemez.").Length(1, 15).WithMessage("Kullanıcı adı alanı [1-15] karakter aralığında olmalıdır.");
            this.RuleFor(c => c.Sifre).NotNull().WithMessage("Şife alanı boş geçilemez.").Length(1, 15).WithMessage("Şifre alanı [1-15] karakter aralığında olmalıdır.");
            this.RuleFor(c => c.Fotograf).NotNull().WithMessage("Fotograf alanı boş geçilemez.").Length(1, 500).WithMessage("Fotograf alanı [1-500] karakter aralığında olmalıdır.");
            this.RuleFor(c => c.Okul).NotNull().WithMessage("Okul alanı boş geçilemez.").Length(1, 150).WithMessage("Okul alanı [1-150] karakter aralığında olmalıdır.");
            this.RuleFor(c => c.Telefon).NotNull().WithMessage("Telefon alanı boş geçilemez.").Length(1, 20).WithMessage("Telefon alanı [1-20] karakter aralığında olmalıdır.");
            this.RuleFor(c => c.Tckn).NotNull().WithMessage("TcKimlikNo alanı boş geçilemez.").Length(11, 11).WithMessage("TcKimlikNo alanı 11 karakter aralığında olmalıdır.");
            this.RuleFor(c => c.Adres).NotNull().WithMessage("Adres alanı boş geçilemez.").Length(1, 350).WithMessage("Adres alanı [1-350] karakter aralığında olmalıdır.");
        }
    }
}
