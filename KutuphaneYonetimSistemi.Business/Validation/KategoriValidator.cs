using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Business.Validation
{
    public class KategoriValidator:AbstractValidator<Kategori>
    {
        public KategoriValidator()
        {
            this.RuleFor(c => c.Ad).NotNull().WithMessage("Kategori adı alanı boş olamaz.").Length(1, 50)
                .WithMessage("Kategori adı alanı [0-50] karakter aralığında olmalıdır.");
        }
    }
}
