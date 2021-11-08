using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Abstract;

namespace KutuphaneYonetimSistemi.Entities.Concrete
{
    public class Kategori:IEntity
    {
        public Kategori()
        {
            Kitaplari = new List<Kitap>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }

        public virtual List<Kitap> Kitaplari { get; set; }
    }
}
