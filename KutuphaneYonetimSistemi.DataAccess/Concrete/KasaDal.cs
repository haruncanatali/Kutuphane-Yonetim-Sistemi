using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.DataAccess.Abstract;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.DataAccess.Concrete
{
    public class KasaDal:EntityRepositoryBase<Kasa,KutuphaneYonetimSistemiDbContext>,IKasaDal
    {
        public List<Kasa> GetEntities(Expression<Func<Kasa, bool>> filter = null)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return filter == null ? context.Tbl_Kasa.ToList() : context.Tbl_Kasa.Where(filter).ToList();
            }
        }

        public Kasa GetEntity(Expression<Func<Kasa, bool>> filter)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return context.Tbl_Kasa.FirstOrDefault(filter);
            }
        }
    }
}
