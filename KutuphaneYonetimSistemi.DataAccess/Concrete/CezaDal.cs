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
    public class CezaDal : EntityRepositoryBase<Ceza, KutuphaneYonetimSistemiDbContext>, ICezaDal
    {
        public List<Ceza> GetEntities(Expression<Func<Ceza, bool>> filter = null)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return filter == null ? context.Tbl_Ceza.Include(c=>c.Uyesi).ToList() : context.Tbl_Ceza.Include(c=>c.Uyesi).Where(filter).ToList();
            }
        }

        public Ceza GetEntity(Expression<Func<Ceza, bool>> filter)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return context.Tbl_Ceza.Include(c=>c.Uyesi).FirstOrDefault(filter);
            }
        }
    }
}
