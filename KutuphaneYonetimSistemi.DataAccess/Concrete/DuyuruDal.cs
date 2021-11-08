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
    public class DuyuruDal:EntityRepositoryBase<Duyuru,KutuphaneYonetimSistemiDbContext>,IDuyuruDal
    {
        public List<Duyuru> GetEntities(Expression<Func<Duyuru, bool>> filter = null)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return filter == null ? context.Tbl_Duyuru.ToList() : context.Tbl_Duyuru.Where(filter).ToList();
            }
        }

        public Duyuru GetEntity(Expression<Func<Duyuru, bool>> filter)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return context.Tbl_Duyuru.FirstOrDefault(filter);
            }
        }
    }
}
