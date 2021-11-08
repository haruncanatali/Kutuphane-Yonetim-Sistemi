using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.DataAccess.Abstract;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.DataAccess.Concrete
{
    public class YazarDal:EntityRepositoryBase<Yazar,KutuphaneYonetimSistemiDbContext>,IYazarDal
    {
        public List<Yazar> GetEntities(Expression<Func<Yazar, bool>> filter = null)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return filter == null
                    ? context.Tbl_Yazar.Include(c => c.Kitaplari).ToList()
                    : context.Tbl_Yazar.Where(filter).Include(c => c.Kitaplari).ToList();
            }
        }

        public Yazar GetEntity(Expression<Func<Yazar, bool>> filter)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return context.Tbl_Yazar.Include(c => c.Kitaplari).FirstOrDefault(filter);
            }
        }
    }
}
