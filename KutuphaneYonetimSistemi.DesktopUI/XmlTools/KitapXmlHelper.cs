using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Ninject;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.DesktopUI.XmlTools
{
    public class KitapXmlHelper
    {
        private List<Kitap> kitaplar = null;
        private Kitap kitap = null;
        private IKitapService kitapServis;

        public KitapXmlHelper()
        {
            kitapServis = InstanceFactory.GetInstance<IKitapService>();
        }

        public void XmlKitapKaydedici(string dosyaPath)
        {
            try
            {
                kitaplar = new List<Kitap>();

                foreach (XElement element in XElement.Load(dosyaPath).Elements("Kitap"))
                {
                    kitap = new Kitap
                    {
                        Ad = element.Element("Ad").Value.ToString(),
                        BasimYili = element.Element("BasimYili").Value.ToString(),
                        YayinEvi = element.Element("Yayinevi").Value.ToString(),
                        SayfaSayisi = short.Parse(element.Element("SayfaSayisi").Value.ToString()),
                        KategoriId = int.Parse(element.Element("KategoriId").Value.ToString()),
                        YazarId = int.Parse(element.Element("YazarId").Value.ToString()),
                        KitapFotoUrl = element.Element("Foto").Value.ToString()
                    };
                    kitaplar.Add(kitap);
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
