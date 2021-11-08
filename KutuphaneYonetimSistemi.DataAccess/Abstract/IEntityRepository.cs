using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Abstract;

namespace KutuphaneYonetimSistemi.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity: class,IEntity,new()
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
