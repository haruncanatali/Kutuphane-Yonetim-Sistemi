using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Validation;
using KutuphaneYonetimSistemi.DataAccess.Abstract;
using KutuphaneYonetimSistemi.Entities.Abstract;

namespace KutuphaneYonetimSistemi.Business.Concrete
{
    public class ManagerCollection<TEntity,TDal,TValidator>:IServiceCollection<TEntity> where TEntity:class,IEntity,new() where TDal:IEntityRepository<TEntity>,IFilterRepository<TEntity> where TValidator:IValidator
    {
        private TDal dal;
        private TValidator validator;

        public ManagerCollection(TDal dal, TValidator validator)
        {
            this.dal = dal;
            this.validator = validator;
        }

        public void Add(TEntity entity)
        {
            //ValidationTool.Validate(validator,entity);
            dal.Add(entity);
        }

        public void Update(TEntity entity)
        {
            //ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            dal.Delete(entity);
        }

        public List<TEntity> GetEntities(Expression<Func<TEntity, bool>> filter = null)
        {
            return dal.GetEntities(filter);
        }

        public TEntity GetEntity(Expression<Func<TEntity, bool>> filter)
        {
            return dal.GetEntity(filter);
        }
    }
}
