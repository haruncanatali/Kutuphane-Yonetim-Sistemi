using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.API.Entities
{
    public class Duyuru
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}

