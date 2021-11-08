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
    public class HareketDal:EntityRepositoryBase<Hareket,KutuphaneYonetimSistemiDbContext>,IHareketDal
    {
        public List<Hareket> GetEntities(Expression<Func<Hareket, bool>> filter = null)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return filter == null
                    ? context.Tbl_Hareket.Include(c=>c.Kitabi).Include(c=>c.Personeli).Include(c=>c.Uyesi).Include(c => c.Cezalar).ToList()
                    : context.Tbl_Hareket.Where(filter).Include(c => c.Kitabi).Include(c => c.Personeli).Include(c => c.Uyesi).Include(c => c.Cezalar).ToList();
            }
        }

        public Hareket GetEntity(Expression<Func<Hareket, bool>> filter)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return context.Tbl_Hareket.Include(c => c.Personeli).Include(c => c.Kitabi).Include(c => c.Uyesi).Include(c => c.Cezalar).FirstOrDefault(filter);
            }
        }
    }
}
