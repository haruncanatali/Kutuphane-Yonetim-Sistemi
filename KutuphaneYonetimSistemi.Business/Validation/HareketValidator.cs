using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Business.Validation
{
    public class HareketValidator:AbstractValidator<Hareket>
    {
        public HareketValidator()
        {
            this.RuleFor(c => c.AlisTarihi).NotNull().WithMessage("Alış tarihi boş olamaz.");
            this.RuleFor(c => c.IadeTarihi).NotNull().WithMessage("Iade tarihi boş olamaz.");
            this.RuleFor(c => c.KitapId).NotNull().WithMessage("Kitap ID boş olamaz.");
            this.RuleFor(c => c.UyeId).NotNull().WithMessage("Uye ID boş olamaz.");
            this.RuleFor(c => c.PersonelId).NotNull().WithMessage("Personel ID boş olamaz.");
        }
    }
}
