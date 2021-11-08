using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Business.Validation
{
    public class CezaValidator:AbstractValidator<Ceza>
    {
        public CezaValidator()
        {
            this.RuleFor(c => c.BaslangicTarihi).NotNull().WithMessage("Başlangıç tarihi boş olamaz.");
            this.RuleFor(c => c.BitisTarihi).NotNull().WithMessage("Bitis tarihi boş olamaz.");
            this.RuleFor(c => c.UyeId).NotNull().WithMessage("Üye boş olamaz.");
            this.RuleFor(c => c.HareketId).NotNull().WithMessage("Hareket boş olamaz.");
        }
    }
}
