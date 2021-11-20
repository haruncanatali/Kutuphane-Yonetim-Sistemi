using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Ninject;
using KutuphaneYonetimSistemi.Entities.Concrete;
using Newtonsoft.Json;

namespace KutuphaneYonetimSistemi.DesktopUI.JsonTools
{
    public class UyeJsonHelper
    {
        public List<Uye> uyeler = null;
        private IUyeService uyeServis;

        public UyeJsonHelper()
        {
            uyeServis = InstanceFactory.GetInstance<IUyeService>();
        }

        public void JsonUyeKaydedici(string dosyaPath)
        {
            try
            {
                uyeler = new List<Uye>();
                using (StreamReader reader = File.OpenText(dosyaPath))
                {
                    uyeler = (List<Uye>)(new JsonSerializer()).Deserialize(reader,typeof(List<Uye>));
                }

                foreach (var uye in uyeler)
                {
                    uyeServis.Add(uye);
                }
            }
            catch (Exception e)
            {
                throw new ValidationException(e.Message);
            }
        }
    }
}
