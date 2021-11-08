using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Validation;
using KutuphaneYonetimSistemi.DataAccess.Abstract;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.Business.Concrete
{
    public class DuyuruManager:ManagerCollection<Duyuru,IDuyuruDal,DuyuruValidator>,IDuyuruService
    {
        public DuyuruManager(IDuyuruDal dal, DuyuruValidator validator) : base(dal, validator)
        {
        }
    }
}
