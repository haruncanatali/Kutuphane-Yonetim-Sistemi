using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Business.Validation
{
    public class KitapValidator:AbstractValidator<Kitap>
    {
        public KitapValidator()
        {
            this.RuleFor(c => c.Ad).NotNull().WithMessage("Kitap adı alanı boş olamaz.").Length(1, 150)
                .WithMessage("Kitap adı alanı [1-150] karakter aralığından oluşmak zorundadır.");
            this.RuleFor(c => c.BasimYili).NotNull().WithMessage("Basım yılı alanı boş olamaz.").Length(1, 4).WithMessage("Basım yılı alanı [1-4] karakter aralığından oluşmak zorundadır.");
            this.RuleFor(c => c.YayinEvi).NotNull().WithMessage("Yayınevi alanı boş olamaz.").Length(1, 100)
                .WithMessage("Yayınevi alanı [1-100] karakter aralığından oluşmak zorundadır.");
            this.RuleFor(c => c.SayfaSayisi).NotNull().WithMessage("Sayfa sayısı boş geçilemez.");
            this.RuleFor(c => c.KategoriId).NotNull().WithMessage("Kategori ID boş geçilemez.");
            this.RuleFor(c => c.YazarId).NotNull().WithMessage("Yazar ID boş geçilemez.");
            this.RuleFor(c => c.Durum).NotNull().WithMessage("Durum boş geçilemez.");
            this.RuleFor(c => c.KitapFotoUrl).Length(1, 500)
                .WithMessage("Kitap fotoğraf alanı [1-500] karakter aralığından oluşmak zorundadır.");
        }
    }
}
