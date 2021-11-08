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
    public class KitapDal:EntityRepositoryBase<Kitap,KutuphaneYonetimSistemiDbContext>,IKitapDal
    {
        public List<Kitap> GetEntities(Expression<Func<Kitap, bool>> filter = null)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return filter == null
                    ? context.Tbl_Kitap.Include(c => c.Yazari).Include(c=>c.Kategorisi).Include(c => c.Hareketleri).ToList()
                    : context.Tbl_Kitap.Where(filter).Include(c => c.Yazari).Include(c => c.Kategorisi).Include(c => c.Hareketleri).ToList();
            }
        }

        public Kitap GetEntity(Expression<Func<Kitap, bool>> filter)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return context.Tbl_Kitap.Include(c => c.Yazari).Include(c => c.Kategorisi).Include(c => c.Hareketleri).FirstOrDefault(filter);
            }
        }
    }
}
