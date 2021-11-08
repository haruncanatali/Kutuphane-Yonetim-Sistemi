using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Abstract;

namespace KutuphaneYonetimSistemi.Business.Abstract
{
    public interface IServiceCollection<TEntity> where TEntity:class,IEntity,new()
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetEntities(Expression<Func<TEntity,bool>> filter=null);
        TEntity GetEntity(Expression<Func<TEntity,bool>> filter);
    }
}
