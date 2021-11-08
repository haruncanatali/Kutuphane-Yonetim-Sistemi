using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Abstract;

namespace KutuphaneYonetimSistemi.Entities.Concrete
{
    public class Kasa : IEntity
    {
        public int Id { get; set; }
        public string Ay { get; set; }
        public string Yil { get; set; }
        public Decimal Tutar { get; set; }

    }
}