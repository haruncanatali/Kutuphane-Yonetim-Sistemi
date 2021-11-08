using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Business.Validation
{
    public class DuyuruValidator:AbstractValidator<Duyuru>
    {
        public DuyuruValidator()
        {
            this.RuleFor(c => c.Tarih).NotNull().WithMessage("Tarih alanı boş geçilemez.");
            this.RuleFor(c => c.Aciklama).NotNull().WithMessage("Açıklama alanı boş geçilemez.").Length(1, 500)
                .WithMessage("Açıklama alanı 1-500 karakter aralığında olmalıdır.");
        }
    }
}
