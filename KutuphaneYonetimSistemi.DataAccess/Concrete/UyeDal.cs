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
    public class UyeDal:EntityRepositoryBase<Uye,KutuphaneYonetimSistemiDbContext>,IUyeDal
    {
        public List<Uye> GetEntities(Expression<Func<Uye, bool>> filter = null)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return filter == null
                    ? context.Tbl_Uye.Include(c => c.Cezalar).Include(c => c.Hareketler).ToList()
                    : context.Tbl_Uye.Where(filter).Include(c => c.Cezalar).Include(c => c.Hareketler).ToList();
            }
        }

        public Uye GetEntity(Expression<Func<Uye, bool>> filter)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return context.Tbl_Uye.Include(c => c.Cezalar).Include(c => c.Hareketler).FirstOrDefault(filter);
            }
        }
    }
}
