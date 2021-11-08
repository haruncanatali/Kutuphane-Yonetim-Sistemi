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
    public class KategoriDal:EntityRepositoryBase<Kategori,KutuphaneYonetimSistemiDbContext>,IKategoriDal
    {
        public List<Kategori> GetEntities(Expression<Func<Kategori, bool>> filter = null)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return filter == null
                    ? context.Tbl_Kategori.Include(c => c.Kitaplari).ToList()
                    : context.Tbl_Kategori.Where(filter).Include(c => c.Kitaplari).ToList();
            }
        }

        public Kategori GetEntity(Expression<Func<Kategori, bool>> filter)
        {
            using (KutuphaneYonetimSistemiDbContext context = new KutuphaneYonetimSistemiDbContext())
            {
                return context.Tbl_Kategori.Include(c => c.Kitaplari).FirstOrDefault(filter);
            }
        }
    }
}
