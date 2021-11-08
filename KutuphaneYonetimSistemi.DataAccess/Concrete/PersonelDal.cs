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
    public class PersonelDal:EntityRepositoryBase<Personel,KutuphaneYonetimSistemiDbContext>,IPersonelDal
    {
        public List<Personel> GetEntities(Expression<Func<Personel, bool>> filter = null)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return filter == null
                    ? context.Tbl_Personel.Include(c => c.Hareketler).ToList()
                    : context.Tbl_Personel.Where(filter).Include(c => c.Hareketler).ToList();
            }
        }

        public Personel GetEntity(Expression<Func<Personel, bool>> filter)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return context.Tbl_Personel.Include(c => c.Hareketler).FirstOrDefault(filter);
            }
        }
    }
}
