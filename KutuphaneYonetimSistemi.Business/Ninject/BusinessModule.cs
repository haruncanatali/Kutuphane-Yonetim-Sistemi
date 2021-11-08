using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Concrete;
using KutuphaneYonetimSistemi.DataAccess.Abstract;
using KutuphaneYonetimSistemi.DataAccess.Concrete;
using KutuphaneYonetimSistemi.Entities.Concrete;
using Ninject.Modules;

namespace KutuphaneYonetimSistemi.Business.Ninject
{
    class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICezaDal>().To<CezaDal>().InTransientScope();
            Bind<ICezaService>().To<CezaManager>().InTransientScope();

            Bind<IHareketDal>().To<HareketDal>().InTransientScope();
            Bind<IHareketService>().To<HareketManager>().InTransientScope();

            Bind<IKasaDal>().To<KasaDal>().InTransientScope();
            Bind<IKasaService>().To<KasaManager>().InTransientScope();

            Bind<IKategoriDal>().To<KategoriDal>().InTransientScope();
            Bind<IKategoriService>().To<KategoriManager>().InTransientScope();

            Bind<IKitapDal>().To<KitapDal>().InTransientScope();
            Bind<IKitapService>().To<KitapManager>().InTransientScope();

            Bind<IPersonelDal>().To<PersonelDal>().InTransientScope();
            Bind<IPersonelService>().To<PersonelManager>().InTransientScope();

            Bind<IUyeDal>().To<UyeDal>().InTransientScope();
            Bind<IUyeService>().To<UyeManager>().InTransientScope();

            Bind<IYazarDal>().To<YazarDal>().InTransientScope();
            Bind<IYazarService>().To<YazarManager>().InTransientScope();

            Bind<IDuyuruDal>().To<DuyuruDal>().InTransientScope();
            Bind<IDuyuruService>().To<DuyuruManager>().InTransientScope();
        }
    }
}
