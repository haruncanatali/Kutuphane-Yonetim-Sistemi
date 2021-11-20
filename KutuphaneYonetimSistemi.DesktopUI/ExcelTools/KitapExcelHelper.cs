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
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace KutuphaneYonetimSistemi.DesktopUI.ExcelTools
{
    public class KitapExcelHelper
    {
        private List<Kitap> kitaplar = null;
        private Kitap kitap = null;
        private IKitapService kitapServis;

        public KitapExcelHelper()
        {
            kitapServis = InstanceFactory.GetInstance<IKitapService>();
        }

        public void ExcelKitapKaydedici(string dosyaPath)
        {
            try
            {
                kitaplar = new List<Kitap>();
                using (FileStream stream = new FileStream(dosyaPath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(stream);
                    ISheet sheet = workbook.GetSheetAt(0);
                    int satir = sheet.LastRowNum;

                    for (int i = 1; i <= satir; i++)
                    {
                        IRow mevcutSatir = sheet.GetRow(i);
                        kitap = new Kitap
                        {
                            Ad = mevcutSatir.GetCell(0).ToString().Trim(),
                            BasimYili = mevcutSatir.GetCell(1).ToString().Trim(),
                            YayinEvi = mevcutSatir.GetCell(2).ToString().Trim(),
                            SayfaSayisi = short.Parse(mevcutSatir.GetCell(3).ToString().Trim()),
                            KategoriId = int.Parse(mevcutSatir.GetCell(4).ToString().Trim()),
                            YazarId = int.Parse(mevcutSatir.GetCell(5).ToString().Trim()),
                            KitapFotoUrl = mevcutSatir.GetCell(6).ToString().Trim()
                        };
                        kitaplar.Add(kitap);
                    }

                    stream.Close();
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
