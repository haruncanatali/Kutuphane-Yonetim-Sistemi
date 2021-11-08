using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Abstract;

namespace KutuphaneYonetimSistemi.Entities.Concrete
{
    public class Duyuru:IEntity
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}
