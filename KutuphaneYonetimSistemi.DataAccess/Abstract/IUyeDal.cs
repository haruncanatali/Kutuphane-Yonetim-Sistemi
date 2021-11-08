﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.DataAccess.Abstract
{
    public interface IUyeDal:IEntityRepository<Uye>,IFilterRepository<Uye>
    {
    }
}
