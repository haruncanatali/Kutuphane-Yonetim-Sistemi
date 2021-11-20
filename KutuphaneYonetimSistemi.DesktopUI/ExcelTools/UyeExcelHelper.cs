using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Ninject;
using KutuphaneYonetimSistemi.Entities.Concrete;
using NPOI;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace KutuphaneYonetimSistemi.DesktopUI.ExcelTools
{
    public class UyeExcelHelper
    {
        public List<Uye> uyeler = null;
        public Uye uye = null;
        IUyeService uyeServis;

        public UyeExcelHelper()
        {
            uyeServis = InstanceFactory.GetInstance<IUyeService>();
        }

        public void ExcelUyeKaydedici(string dosyaPath)
        {
            uyeler = new List<Uye>();
            try
            {
                using (FileStream stream = new FileStream(dosyaPath,FileMode.Open,FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(stream);
                    ISheet sheet = workbook.GetSheetAt(0);
                    int satir = sheet.LastRowNum;

                    for (int i = 1; i <= satir; i++)
                    {
                        IRow mevcutSatir = sheet.GetRow(i);
                        uye = new Uye
                        {
                            Ad = mevcutSatir.GetCell(0).ToString().Trim(),
                            Soyad = mevcutSatir.GetCell(1).ToString().Trim(),
                            Mail = mevcutSatir.GetCell(2).ToString().Trim(),
                            KullaniciAdi = mevcutSatir.GetCell(3).ToString().Trim(),
                            Sifre = mevcutSatir.GetCell(4).ToString().Trim(),
                            Fotograf = mevcutSatir.GetCell(5).ToString().Trim(),
                            Telefon = mevcutSatir.GetCell(6).ToString().Trim(),
                            Adres = mevcutSatir.GetCell(7).ToString().Trim(),
                            Okul = mevcutSatir.GetCell(8).ToString().Trim(),
                            Tckn = mevcutSatir.GetCell(9).ToString().Trim(),
                        };
                        uyeler.Add(uye);
                    }

                    stream.Close();
                }

                foreach (var uye in uyeler)
                {
                    uyeServis.Add(uye);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
