using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Ninject;
using KutuphaneYonetimSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace KutuphaneYonetimSistemi.DesktopUI.XmlTools
{
    public class UyeXmlHelper
    {
        public List<Uye> uyeler = null;
        public Uye uye = null;
        IUyeService uyeServis;

        public UyeXmlHelper()
        {
            uyeServis = InstanceFactory.GetInstance<IUyeService>();
        }

        public void XmlUyeKaydedici(string dosyaPath)
        {
            uyeler = new List<Uye>();

            foreach (XElement element in XElement.Load(dosyaPath).Elements("Uye"))
            {
                uye = new Uye
                {
                    Ad = element.Element("Ad").Value.ToString(),
                    Soyad = element.Element("Soyad").Value.ToString(),
                    Mail = element.Element("Mail").Value.ToString(),
                    KullaniciAdi = element.Element("KullaniciAdi").Value.ToString(),
                    Sifre = element.Element("Sifre").Value.ToString(),
                    Fotograf = element.Element("Fotograf").Value.ToString(),
                    Telefon = element.Element("Telefon").Value.ToString(),
                    Adres = element.Element("Adres").Value.ToString(),
                    Okul = element.Element("Okul").Value.ToString(),
                    Tckn = element.Element("Tckn").Value.ToString()
                };
                uyeler.Add(uye);
            }
                    
            

            foreach (var uye in uyeler)
            {
                try
                {
                    uyeServis.Add(uye);      
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }
    }
}
