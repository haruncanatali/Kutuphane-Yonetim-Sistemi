using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Business.Validation
{
    public class PersonelValidator:AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
            this.RuleFor(c => c.Ad).NotNull().WithMessage("Ad alanı boş geçilemez.").Length(1, 50)
                .WithMessage("Ad alanı [1-50] karakter aralığından oluşmak zorundadır.");
            this.RuleFor(c => c.Soyad).NotNull().WithMessage("Soyad alanı boş geçilemez.").Length(1, 50)
                .WithMessage("Soyad alanı [1-50] karakter aralığından oluşmak zorundadır.");
            this.RuleFor(c => c.Tckn).NotNull().WithMessage("TcKimlikNo alanı boş geçilemez.").Length(11, 11).WithMessage("TcKimlikNo alanı [11] karakter aralığından oluşmak zorundadır.");
            this.RuleFor(c => c.Telefon).NotNull().WithMessage("Telefon alanı boş geçilemez.").Length(1, 20).WithMessage("Telefon alanı [1-20] karakter aralığından oluşmak zorundadır.");
            this.RuleFor(c => c.Adres).NotNull().WithMessage("Adres alanı boş geçilemez.").Length(1, 350)
                .WithMessage("Adres alanı [1-350] karakter aralığından oluşmak zorundadır.");
            this.RuleFor(c => c.KullaniciAdi).NotNull().WithMessage("Kullanıcı adı alanı boş geçilemez.").Length(1, 15).WithMessage("Kullanıcı adı alanı [1-15] karakter aralığından oluşmak zorundadır.");
            this.RuleFor(c => c.Sifre).NotNull().WithMessage("Şifre alanı boş geçilemez.").Length(1, 15)
                .WithMessage("Şifre alanı [1-15] karakter aralığından oluşmak zorundadır.");
        }
    }
}
