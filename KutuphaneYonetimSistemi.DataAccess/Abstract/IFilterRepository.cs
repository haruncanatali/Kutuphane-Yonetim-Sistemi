using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Abstract;

namespace KutuphaneYonetimSistemi.DataAccess.Abstract
{
    public interface IFilterRepository<TEntity> where TEntity:class,IEntity,new()
    {
        List<TEntity> GetEntities(Expression<Func<TEntity,bool>> filter=null);
        TEntity GetEntity(Expression<Func<TEntity,bool>> filter);
    }
}
