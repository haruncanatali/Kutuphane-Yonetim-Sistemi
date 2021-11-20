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
    public class KitapJsonHelper
    {
        private List<Kitap> kitaplar=null;
        private IKitapService kitapServis;

        public KitapJsonHelper()
        {
            kitapServis = InstanceFactory.GetInstance<IKitapService>();
        }

        public void JsonKitapKaydedici(string dosyaPath)
        {
            try
            {
                kitaplar = new List<Kitap>();
                using (StreamReader reader = File.OpenText(dosyaPath))
                {
                    kitaplar = (List<Kitap>)(new JsonSerializer()).Deserialize(reader, typeof(List<Kitap>));
                }

                foreach (var kitap in kitaplar)
                {
                    kitap.Durum = false;
                    kitapServis.Add(kitap);
                }
            }
            catch (Exception e)
            {
                throw new ValidationException(e.Message);
            }
        }
    }
}
