using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Ninject;
using KutuphaneYonetimSistemi.DesktopUI.XmlTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneYonetimSistemi.DesktopUI.ExcelTools;
using KutuphaneYonetimSistemi.DesktopUI.JsonTools;
using KutuphaneYonetimSistemi.Entities.Concrete;
using Exception = System.Exception;

namespace KutuphaneYonetimSistemi.DesktopUI
{
    public partial class Form1 : Form
    {
        private IKasaService kasaServis;
        private IKategoriService kategoriServis;
        private IYazarService yazarServis;
        private IKitapService kitapServis;
        private IHareketService hareketServis;
        private IUyeService uyeServis;
        private IPersonelService personelServis;
        private ICezaService cezaServis;
        private IDuyuruService duyuruServis;

        int id = -1;

        public Form1()
        {
            InitializeComponent();

            kasaServis = InstanceFactory.GetInstance<IKasaService>();
            kategoriServis = InstanceFactory.GetInstance<IKategoriService>();
            yazarServis = InstanceFactory.GetInstance<IYazarService>();
            kitapServis = InstanceFactory.GetInstance<IKitapService>();
            hareketServis = InstanceFactory.GetInstance<IHareketService>();
            uyeServis = InstanceFactory.GetInstance<IUyeService>();
            personelServis = InstanceFactory.GetInstance<IPersonelService>();
            cezaServis = InstanceFactory.GetInstance<ICezaService>();
            duyuruServis = InstanceFactory.GetInstance<IDuyuruService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayfalamaControl.SelectedTabPage = anasayfaTabPage;
            AnasayfaTabPageLoad();
        }

        private void sayfalamaControl_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            XtraTabControl tabPage = (XtraTabControl)sender;
            if (sayfalamaControl.SelectedTabPage != null)
            {
                switch (tabPage.SelectedTabPage.Name)
                {
                    case "anasayfaTabPage":
                        AnasayfaTabPageLoad();
                        break;
                    case "kategoriTabPage":
                        KategoriTabPageLoad();
                        break;
                    case "yazarTabPage":
                        YazarTabPageLoad();
                        break;
                    case "kitapTabPage":
                        KitapTabPageLoad();
                        break;
                    case "hareketTabPage":
                        HareketTabPageLoad();
                        break;
                    case "cezaTabPage":
                        CezaTabPageLoad();
                        break;
                    case "uyeTabPage":
                        UyeTabPageLoad();
                        break;
                    case "personelTabPage":
                        PersonelPageLoad();
                        break;
                    case "duyuruTabPage":
                        DuyuruTabPageLoad();
                        break;
                    case "kasaTabPage":
                        KasaTabPageLoad();
                        break;
                }
            }
        }

        private void KasaTabPageLoad()
        {
            kasaGridControl.DataSource = kasaServis.GetEntities(null);

            id = -1;
            ayCbxKasa.Text = "";
            tutarTxtKasa.Text = "";
        }

        private void DuyuruTabPageLoad()
        {
            duyuruGridControl.DataSource = duyuruServis.GetEntities(null);

            id = -1;
            aciklamaTxtDuyuru.Text = "";
        }

        private void UyeTabPageLoad()
        {
            uyeGridControl.DataSource = from x in uyeServis.GetEntities(null)
                                        select new
                                        {
                                            Id = x.Id,
                                            Ad = x.Ad,
                                            Soyad = x.Soyad,
                                            Mail = x.Mail,
                                            KullaniciAdi = x.KullaniciAdi,
                                            Sifre = x.Sifre,
                                            Fotograf = x.Fotograf,
                                            Telefon = x.Telefon,
                                            Adres = x.Adres,
                                            Okul = x.Okul,
                                            Tckn = x.Tckn
                                        };

            id = 1;
            adTxtUye.Text = "";
            soyadTxtUye.Text = "";
            mailTxtUye.Text = "";
            kullaniciAdiTxtUye.Text = "";
            sifreTxtUye.Text = "";
            fotografTxtUye.Text = "";
            telefonTxtUye.Text = "";
            adresTxtUye.Text = "";
            okulTxtUye.Text = "";
            tcknTxtUye.Text = "";
        }

        private void CezaTabPageLoad()
        {
            cezaGridControl.DataSource = from x in cezaServis.GetEntities(null)
                                         select new
                                         {
                                             Id = x.Id,
                                             BaslangicTarihi = x.BaslangicTarihi,
                                             BitisTarihi = x.BitisTarihi,
                                             Para = x.Para,
                                             Uye = x.Uyesi.Ad + " " + x.Uyesi.Soyad + " " + x.Uyesi.Tckn,
                                             Hareket = x.HareketId
                                         };
            uyeLookUpCeza.Properties.DataSource = from x in uyeServis.GetEntities(null)
                                                  select new
                                                  {
                                                      Id = x.Id,
                                                      Ad = x.Ad + " " + x.Soyad + " " + x.Tckn
                                                  };
            hareketLookUpCeza.Properties.DataSource = from x in hareketServis.GetEntities(null)
                                                      select new
                                                      {
                                                          Id = x.Id,
                                                          Ad = x.Id + " " + x.Uyesi.Ad + " " + x.Uyesi.Soyad + " " + x.Uyesi.Tckn
                                                      };

            id = -1;
            baslangicTarihiDtCeza.Text = "";
            bitisTarihiDtCeza.Text = "";
            paraTxtCeza.Text = "";
            uyeLookUpCeza.Text = "";
            hareketLookUpCeza.Text = "";
        }

        private void HareketTabPageLoad()
        {
            hareketGridControl.DataSource = from x in hareketServis.GetEntities(null)
                                            select new
                                            {
                                                Id = x.Id,
                                                AlisTarihi = x.AlisTarihi,
                                                IadeTarihi = x.IadeTarihi,
                                                Kitap = x.Kitabi.Ad,
                                                Uye = x.Uyesi.Ad + " " + x.Uyesi.Soyad + " " + x.Uyesi.Tckn,
                                                Personel = x.Personeli.Ad + " " + x.Personeli.Soyad
                                            };

            kitapLookUpHareket.Properties.DataSource = from x in kitapServis.GetEntities(null)
                                                       where x.Durum == false
                                                       select new
                                                       {
                                                           Id = x.Id,
                                                           Ad = x.Ad
                                                       };
            uyeLookUpHareket.Properties.DataSource = from x in uyeServis.GetEntities(null)
                                                     select new
                                                     {
                                                         Id = x.Id,
                                                         Ad = x.Ad + " " + x.Soyad + " " + x.Tckn
                                                     };
            personelLookUpHareket.Properties.DataSource = from x in personelServis.GetEntities(null)
                                                          select new
                                                          {
                                                              Id = x.Id,
                                                              Ad = x.Ad + " " + x.Soyad
                                                          };
            id = -1;

            kitapLookUpHareket.Text = "";
            uyeLookUpHareket.Text = "";
            personelLookUpHareket.Text = "";

            alisTarihiDtHareket.Text = "";
            iadeTarihiDtHareket.Text = "";

            cezaDurumuLblHareket.Text = "";
            gunFarkiLblHareket.Text = "";
        }

        private void KitapTabPageLoad()
        {
            kitapGridControl.DataSource = from x in kitapServis.GetEntities(null)
                                          select new
                                          {
                                              Id = x.Id,
                                              Ad = x.Ad,
                                              BasimYili = x.BasimYili,
                                              YayinEvi = x.YayinEvi,
                                              SayfaSayisi = x.SayfaSayisi,
                                              Durum = x.Durum == false ? "Rafta" : "Okurda",
                                              Kategori = x.Kategorisi.Ad,
                                              Yazar = x.Yazari.Ad + " " + x.Yazari.Soyad,
                                              KitapFotoUrl = x.KitapFotoUrl
                                          };
            yazarLookUpKitap.Properties.DataSource = from x in yazarServis.GetEntities(null)
                                                     select new
                                                     {
                                                         Id = x.Id,
                                                         Ad = x.Ad + " " + x.Soyad,
                                                     };
            kategoriLookUpKitap.Properties.DataSource = from x in kategoriServis.GetEntities(null)
                                                        select new
                                                        {
                                                            Id = x.Id,
                                                            Ad = x.Ad
                                                        };

            id = -1;
            kitapAdiTxtKitap.Text = "";
            basimYiliTxtKitap.Text = "";
            yayinEviTxtKitap.Text = "";
            sayfaSayisiTxtKitap.Text = "";
            kategoriLookUpKitap.Text = "";
            yazarLookUpKitap.Text = "";
            fotografLinkiTxtKitap.Text = "";
        }

        private void YazarTabPageLoad()
        {
            sayfalamaControl.SelectedTabPage = yazarTabPage;
            yazarGridControl.DataSource = from x in yazarServis.GetEntities(null)
                                          select new
                                          {
                                              Id = x.Id,
                                              Ad = x.Ad,
                                              Soyad = x.Soyad,
                                              Detay = x.Detay
                                          };
            id = -1;
            yazarAdTxt.Text = "";
            yazarSoyadTxt.Text = "";
            yazarDetayTxt.Text = "";
        }

        private void KategoriTabPageLoad()
        {
            sayfalamaControl.SelectedTabPage = kategoriTabPage;
            kategoriGridControl.DataSource = from x in kategoriServis.GetEntities(null)
                                             select new
                                             {
                                                 Id = x.Id,
                                                 Ad = x.Ad
                                             };
            id = -1;
            KategoriAdiTxt.Text = "";
        }

        private void AnasayfaTabPageLoad()
        {
            sayfalamaControl.SelectedTabPage = anasayfaTabPage;

            foreach (var item in kategoriServis.GetEntities())
            {
                chartControl1.Series["Adet"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(item.Ad, item.Kitaplari.Count));
            }

            foreach (var item in kasaServis.GetEntities())
            {
                chartControl2.Series["TL"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(item.Ay, item.Tutar));
            }
        }

        private void Transfer_Buttons_Click(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            switch (button.Text)
            {
                case "XML Kitap Transfer":
                    XmlKitapTransfer();
                    break;
                case "Excel Kitap Transfer":
                    ExcelKitapTransfer();
                    break;
                case "JSON Kitap Transfer":
                    JsonKitapTransfer();
                    break;
                case "XML Üye Transfer":
                    XmlUyeTransfer();
                    break;
                case "Excel Üye Transfer":
                    ExcelUyeTransfer();
                    break;
                case "JSON Üye Transfer":
                    JsonUyeTransfer();
                    break;
            }

            AnasayfaTabPageLoad();
        }

        private void JsonUyeTransfer()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Transfer yapılacak JSON dosyasını seçiniz";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null && fileDialog.FileName.Length > 4)
            {
                try
                {
                    UyeJsonHelper jsonHelper = new UyeJsonHelper();
                    jsonHelper.JsonUyeKaydedici(fileDialog.FileName);
                    MessageBox.Show("Transfer tamamlandı.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Transferde hata var ! :" + exception.Message);
                }
            }
        }

        private void ExcelUyeTransfer()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Transfer yapılacak Excel dosyasını seçiniz";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null && fileDialog.FileName.Length > 4)
            {
                try
                {
                    UyeExcelHelper excelHelper = new UyeExcelHelper();
                    excelHelper.ExcelUyeKaydedici(fileDialog.FileName);
                    MessageBox.Show("Transfer tamamlandı.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Transferde hata var ! :" + exception.Message);
                }
            }
        }

        private void XmlUyeTransfer()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "*.xml";
            fileDialog.Title = "Transfer yapılacak XML dosyasını seçiniz";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null && fileDialog.FileName.Length > 4)
            {
                try
                {
                    UyeXmlHelper xmlHelper = new UyeXmlHelper();
                    xmlHelper.XmlUyeKaydedici(fileDialog.FileName);
                    MessageBox.Show("Transfer tamamlandı.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Transferde hata var ! :" + exception.Message);
                }
            }
        }

        private void JsonKitapTransfer()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Transfer yapılacak JSON dosyasını seçiniz";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null && fileDialog.FileName.Length > 4)
            {
                try
                {
                    KitapJsonHelper jsonHelper = new KitapJsonHelper();
                    jsonHelper.JsonKitapKaydedici(fileDialog.FileName);
                    MessageBox.Show("Transfer tamamlandı.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Transferde hata var ! :" + exception.Message);
                }
            }
        }

        private void ExcelKitapTransfer()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Transfer yapılacak Excel dosyasını seçiniz";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null && fileDialog.FileName.Length > 4)
            {
                try
                {
                    KitapExcelHelper excelHelper = new KitapExcelHelper();
                    excelHelper.ExcelKitapKaydedici(fileDialog.FileName);
                    MessageBox.Show("Transfer tamamlandı.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Transferde hata var ! :" + exception.Message);
                }
            }
        }

        private void XmlKitapTransfer()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Transfer yapılacak XML dosyasını seçiniz";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != null && fileDialog.FileName.Length > 4)
            {
                try
                {
                    KitapXmlHelper xmlHelper = new KitapXmlHelper();
                    xmlHelper.XmlKitapKaydedici(fileDialog.FileName);
                    MessageBox.Show("Transfer tamamlandı.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Transferde hata var ! :" + exception.Message);
                }
            }
        }

        private void Kategori_Vt_Bttns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            switch (btn.Text)
            {
                case "Ekle":
                    KategoriAdd();
                    break;
                case "Güncelle":
                    KategoriUpdate();
                    break;
                case "Sil":
                    KategoriDelete();
                    break;
            }
            KategoriTabPageLoad();
        }

        private void KategoriDelete()
        {
            try
            {
                kategoriServis.Delete(new Kategori
                {
                    Id = id
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            id = -1;
        }

        private void KategoriUpdate()
        {
            try
            {
                kategoriServis.Update(new Kategori
                {
                    Id = id,
                    Ad = KategoriAdiTxt.Text.ToString()
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            id = -1;
        }

        private void KategoriAdd()
        {
            try
            {
                kategoriServis.Add(new Kategori
                {
                    Ad = KategoriAdiTxt.Text.ToString()
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void kategoriGrid_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            KategoriAdiTxt.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void Yazar_Vt_Bttns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            switch (btn.Text)
            {
                case "Ekle":
                    YazarAdd();
                    break;
                case "Güncelle":
                    YazarUpdate();
                    break;
                case "Sil":
                    YazarDelete();
                    break;
            }
            YazarTabPageLoad();
        }

        private void YazarDelete()
        {
            try
            {
                yazarServis.Delete(new Yazar
                {
                    Id = id
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
            }
        }

        private void YazarUpdate()
        {
            try
            {
                yazarServis.Update(new Yazar
                {
                    Id = id,
                    Ad = yazarAdTxt.Text.ToString(),
                    Soyad = yazarSoyadTxt.Text.ToString(),
                    Detay = yazarDetayTxt.Text.ToString()
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
            }
        }

        private void YazarAdd()
        {
            try
            {
                yazarServis.Add(new Yazar
                {
                    Ad = yazarAdTxt.Text.ToString(),
                    Soyad = yazarSoyadTxt.Text.ToString(),
                    Detay = yazarDetayTxt.Text.ToString()
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
            }
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView2.GetFocusedRowCellValue("Id").ToString());
            yazarAdTxt.Text = gridView2.GetFocusedRowCellValue("Ad").ToString();
            yazarSoyadTxt.Text = gridView2.GetFocusedRowCellValue("Soyad").ToString();
            yazarDetayTxt.Text = gridView2.GetFocusedRowCellValue("Detay").ToString();
        }

        private void Kitap_Vt_Bttns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            switch (btn.Text)
            {
                case "Ekle":
                    KitapAdd();
                    break;
                case "Güncelle":
                    KitapUpdate();
                    break;
                case "Sil":
                    KitapDelete();
                    break;
            }
            KitapTabPageLoad();
        }

        private void KitapDelete()
        {
            try
            {
                kitapServis.Delete(new Kitap
                {
                    Id = id
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void KitapUpdate()
        {
            try
            {
                kitapServis.Update(new Kitap
                {
                    Id = id,
                    Ad = kitapAdiTxtKitap.Text,
                    BasimYili = basimYiliTxtKitap.Text,
                    YayinEvi = yayinEviTxtKitap.Text,
                    SayfaSayisi = short.Parse(sayfaSayisiTxtKitap.Text.ToString()),
                    Durum = false,
                    KategoriId = int.Parse(kategoriLookUpKitap.EditValue.ToString()),
                    YazarId = int.Parse(yazarLookUpKitap.EditValue.ToString()),
                    KitapFotoUrl = fotografLinkiTxtKitap.Text
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void KitapAdd()
        {
            try
            {
                kitapServis.Add(new Kitap
                {
                    Ad = kitapAdiTxtKitap.Text,
                    BasimYili = basimYiliTxtKitap.Text,
                    YayinEvi = yayinEviTxtKitap.Text,
                    SayfaSayisi = short.Parse(sayfaSayisiTxtKitap.Text.ToString()),
                    Durum = gridView3.GetFocusedRowCellValue("Durum").ToString() == "Rafta" ? false : true,
                    KategoriId = int.Parse(kategoriLookUpKitap.EditValue.ToString()),
                    YazarId = int.Parse(yazarLookUpKitap.EditValue.ToString()),
                    KitapFotoUrl = fotografLinkiTxtKitap.Text
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void gridView3_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView3.GetFocusedRowCellValue("Id").ToString());
            kitapAdiTxtKitap.Text = gridView3.GetFocusedRowCellValue("Ad").ToString();
            basimYiliTxtKitap.Text = gridView3.GetFocusedRowCellValue("BasimYili").ToString();
            yayinEviTxtKitap.Text = gridView3.GetFocusedRowCellValue("YayinEvi").ToString();
            sayfaSayisiTxtKitap.Text = gridView3.GetFocusedRowCellValue("SayfaSayisi").ToString();
            kategoriLookUpKitap.Text = gridView3.GetFocusedRowCellValue("Kategori").ToString();
            yazarLookUpKitap.Text = gridView3.GetFocusedRowCellValue("Yazar").ToString();
            fotografLinkiTxtKitap.Text = gridView3.GetFocusedRowCellValue("KitapFotoUrl").ToString();
        }

        private void Hareket_Vt_Bttns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            switch (btn.Text)
            {
                case "Ekle":
                    HareketAdd();
                    break;
                case "Güncelle":
                    HareketUpdate();
                    break;
                case "Sil":
                    HareketDelete();
                    break;
            }
            HareketTabPageLoad();
        }

        private void HareketDelete()
        {
            if (cezaDurumuLblHareket.Text != "Var")
            {
                int id_ = int.Parse(kitapLookUpHareket.EditValue.ToString());

                try
                {
                    hareketServis.Delete(new Hareket
                    {
                        Id = id
                    });
                    var entity = kitapServis.GetEntity(c => c.Id == id_);
                    entity.Durum = false;
                    kitapServis.Update(entity);
                    MessageBox.Show("Başarılı");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Hata :" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Önce harekete ait cezaları tahsil ediniz.");
            }
        }

        private void HareketUpdate()
        {
            try
            {
                hareketServis.Update(new Hareket
                {
                    Id = id,
                    AlisTarihi = DateTime.Parse(alisTarihiDtHareket.Text.ToString()),
                    IadeTarihi = DateTime.Parse(iadeTarihiDtHareket.Text.ToString()),
                    PersonelId = int.Parse(personelLookUpHareket.EditValue.ToString()),
                    UyeId = int.Parse(uyeLookUpHareket.EditValue.ToString()),
                    KitapId = int.Parse(kitapLookUpHareket.EditValue.ToString())
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void HareketAdd()
        {
            try
            {
                hareketServis.Add(new Hareket
                {
                    AlisTarihi = DateTime.Parse(alisTarihiDtHareket.Text.ToString()),
                    IadeTarihi = DateTime.Parse(iadeTarihiDtHareket.Text.ToString()),
                    PersonelId = int.Parse(personelLookUpHareket.EditValue.ToString()),
                    UyeId = int.Parse(uyeLookUpHareket.EditValue.ToString()),
                    KitapId = int.Parse(kitapLookUpHareket.EditValue.ToString())
                });

                var id_ = int.Parse(kitapLookUpHareket.EditValue.ToString());
                var entity = kitapServis.GetEntity(c => c.Id == id_);
                entity.Durum = true;

                kitapServis.Update(entity);
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void gridView4_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView4.GetFocusedRowCellValue("Id").ToString());
            alisTarihiDtHareket.Text = gridView4.GetFocusedRowCellValue("AlisTarihi").ToString();
            iadeTarihiDtHareket.Text = gridView4.GetFocusedRowCellValue("IadeTarihi").ToString();

            gunFarkiLblHareket.Text = DateTime.Now.Subtract(DateTime.Parse(gridView4.GetFocusedRowCellValue("AlisTarihi").ToString())).Days.ToString();

            cezaDurumuLblHareket.Text = hareketServis.GetEntity(c => c.Id == id).Cezalar.Count > 0 ? "Var" : "Yok";

            kitapLookUpHareket.Properties.DataSource = from x in kitapServis.GetEntities(null)
                                                       where x.Durum == false || x.Id == hareketServis.GetEntity(c => c.Id == id).KitapId
                                                       select new
                                                       {
                                                           Id = x.Id,
                                                           Ad = x.Ad
                                                       };

            kitapLookUpHareket.Text = gridView4.GetFocusedRowCellValue("Kitap").ToString();
            uyeLookUpHareket.Text = gridView4.GetFocusedRowCellValue("Uye").ToString();
            personelLookUpHareket.Text = gridView4.GetFocusedRowCellValue("Personel").ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            iadeTarihiDtHareket.Text = DateTime.Parse(alisTarihiDtHareket.Text.ToString()).AddDays(15).ToString();
        }

        private void ceza_Vt_Bttns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            switch (btn.Text)
            {
                case "Ekle":
                    CezaAdd();
                    break;
                case "Güncelle":
                    CezaUpdate();
                    break;
                case "Sil":
                    CezaDelete();
                    break;
            }
            CezaTabPageLoad();
        }

        private void CezaDelete()
        {
            try
            {
                var entity = cezaServis.GetEntity(c => c.Id == id);
                cezaServis.Delete(entity);
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void CezaUpdate()
        {
            try
            {
                var entity = cezaServis.GetEntity(c => c.Id == id);
                cezaServis.Update(new Ceza
                {
                    Id = id,
                    BaslangicTarihi = DateTime.Parse(baslangicTarihiDtCeza.Text.ToString()),
                    BitisTarihi = DateTime.Parse(bitisTarihiDtCeza.Text.ToString()),
                    HareketId = int.Parse(hareketLookUpCeza.EditValue.ToString()),
                    UyeId = int.Parse(uyeLookUpCeza.EditValue.ToString()),
                    Para = decimal.Parse(paraTxtCeza.Text.ToString())
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void CezaAdd()
        {
            try
            {
                cezaServis.Add(new Ceza
                {
                    BaslangicTarihi = DateTime.Parse(baslangicTarihiDtCeza.Text.ToString()),
                    BitisTarihi = DateTime.Parse(bitisTarihiDtCeza.Text.ToString()),
                    HareketId = int.Parse(hareketLookUpCeza.EditValue.ToString()),
                    UyeId = int.Parse(uyeLookUpCeza.EditValue.ToString()),
                    Para = decimal.Parse(paraTxtCeza.Text.ToString())
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void gridView5_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView5.GetFocusedRowCellValue("Id").ToString());
            baslangicTarihiDtCeza.Text = gridView5.GetFocusedRowCellValue("BaslangicTarihi").ToString();
            bitisTarihiDtCeza.Text = gridView5.GetFocusedRowCellValue("BitisTarihi").ToString();
            hareketLookUpCeza.Text = gridView5.GetFocusedRowCellValue("Hareket").ToString();
            uyeLookUpCeza.Text = gridView5.GetFocusedRowCellValue("Uye").ToString();
            paraTxtCeza.Text = gridView5.GetFocusedRowCellValue("Para").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bitisTarihiDtCeza.Text = DateTime.Parse(baslangicTarihiDtCeza.Text.ToString()).AddDays(15).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (paraTxtCeza.Text.Length > 0)
            {
                paraTxtCeza.Text = (decimal.Parse(paraTxtCeza.Text.ToString()) + 15).ToString();
            }
        }

        private void Uye_Vt_Bttns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            switch (btn.Text)
            {
                case "Ekle":
                    UyeAdd();
                    break;
                case "Güncelle":
                    UyeUpdate();
                    break;
                case "Sil":
                    UyeDelete();
                    break;
            }
            UyeTabPageLoad();
        }

        private void UyeDelete()
        {
            try
            {
                var entity = uyeServis.GetEntity(c => c.Id == id);
                uyeServis.Delete(entity);
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void UyeUpdate()
        {
            try
            {
                uyeServis.Update(new Uye
                {
                    Id = id,
                    Ad = adTxtUye.Text,
                    Soyad = soyadTxtUye.Text,
                    Mail = mailTxtUye.Text,
                    KullaniciAdi = kullaniciAdiTxtUye.Text,
                    Sifre = sifreTxtUye.Text,
                    Fotograf = fotografTxtUye.Text,
                    Telefon = telefonTxtUye.Text,
                    Adres = adresTxtUye.Text,
                    Okul = okulTxtUye.Text,
                    Tckn = tcknTxtUye.Text
                });
                MessageBox.Show("Başarılı");
            }
            catch (ValidationException e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void UyeAdd()
        {
            try
            {
                uyeServis.Add(new Uye
                {
                    Ad = adTxtUye.Text,
                    Soyad = soyadTxtUye.Text,
                    Mail = mailTxtUye.Text,
                    KullaniciAdi = kullaniciAdiTxtUye.Text,
                    Sifre = sifreTxtUye.Text,
                    Fotograf = fotografTxtUye.Text,
                    Telefon = telefonTxtUye.Text,
                    Adres = adresTxtUye.Text,
                    Okul = okulTxtUye.Text,
                    Tckn = tcknTxtUye.Text
                });
                MessageBox.Show("Başarılı");
            }
            catch (ValidationException e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void gridView6_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView6.GetFocusedRowCellValue("Id").ToString());
            adTxtUye.Text = gridView6.GetFocusedRowCellValue("Ad").ToString();
            soyadTxtUye.Text = gridView6.GetFocusedRowCellValue("Soyad").ToString();
            mailTxtUye.Text = gridView6.GetFocusedRowCellValue("Mail").ToString();
            kullaniciAdiTxtUye.Text = gridView6.GetFocusedRowCellValue("KullaniciAdi").ToString();
            sifreTxtUye.Text = gridView6.GetFocusedRowCellValue("Sifre").ToString();
            fotografTxtUye.Text = gridView6.GetFocusedRowCellValue("Fotograf").ToString();
            telefonTxtUye.Text = gridView6.GetFocusedRowCellValue("Telefon").ToString();
            adresTxtUye.Text = gridView6.GetFocusedRowCellValue("Adres").ToString();
            okulTxtUye.Text = gridView6.GetFocusedRowCellValue("Okul").ToString();
            tcknTxtUye.Text = gridView6.GetFocusedRowCellValue("Tckn").ToString();
        }

        private void Personel_Vt_Bttns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            switch (btn.Text)
            {
                case "Ekle":
                    PersonelAdd();
                    break;
                case "Güncelle":
                    PersonelUpdate();
                    break;
                case "Sil":
                    PersonelDelete();
                    break;
            }

            PersonelPageLoad();
        }

        private void PersonelPageLoad()
        {
            personelGridControl.DataSource = from x in personelServis.GetEntities(null)
                                             select new
                                             {
                                                 Id = x.Id,
                                                 Ad = x.Ad,
                                                 Soyad = x.Soyad,
                                                 Tckn = x.Tckn,
                                                 Telefon = x.Telefon,
                                                 Adres = x.Adres,
                                                 KullaniciAdi = x.KullaniciAdi,
                                                 Sifre = x.Sifre
                                             };
            id = -1;
            adTxtPersonel.Text = "";
            soyadTxtPersonel.Text = "";
            tcknTxtPersonel.Text = "";
            telefonTxtPersonel.Text = "";
            adresTxtPersonel.Text = "";
            kullaniciAdiTxtPersonel.Text = "";
            sifreTxtPersonel.Text = "";

        }

        private void PersonelDelete()
        {
            try
            {
                var entity = personelServis.GetEntity(c => c.Id == id);
                personelServis.Delete(entity);
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void PersonelUpdate()
        {
            try
            {
                personelServis.Update(new Personel
                {
                    Id = id,
                    Ad = adTxtPersonel.Text,
                    Soyad = soyadTxtPersonel.Text,
                    Tckn = tcknTxtPersonel.Text,
                    Telefon = telefonTxtPersonel.Text,
                    Adres = adTxtPersonel.Text,
                    KullaniciAdi = kullaniciAdiTxtPersonel.Text,
                    Sifre = sifreTxtPersonel.Text
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void PersonelAdd()
        {
            try
            {
                personelServis.Add(new Personel
                {
                    Ad = adTxtPersonel.Text,
                    Soyad = soyadTxtPersonel.Text,
                    Tckn = tcknTxtPersonel.Text,
                    Telefon = telefonTxtPersonel.Text,
                    Adres = adTxtPersonel.Text,
                    KullaniciAdi = kullaniciAdiTxtPersonel.Text,
                    Sifre = sifreTxtPersonel.Text
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void gridView7_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView7.GetFocusedRowCellValue("Id").ToString());
            adTxtPersonel.Text = gridView7.GetFocusedRowCellValue("Ad").ToString();
            soyadTxtPersonel.Text = gridView7.GetFocusedRowCellValue("Soyad").ToString();
            tcknTxtPersonel.Text = gridView7.GetFocusedRowCellValue("Tckn").ToString();
            telefonTxtPersonel.Text = gridView7.GetFocusedRowCellValue("Telefon").ToString();
            adresTxtPersonel.Text = gridView7.GetFocusedRowCellValue("Adres").ToString();
            kullaniciAdiTxtPersonel.Text = gridView7.GetFocusedRowCellValue("KullaniciAdi").ToString();
            sifreTxtPersonel.Text = gridView7.GetFocusedRowCellValue("Sifre").ToString();

        }

        private void Duyuru_Vt_Bttns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            switch (btn.Text)
            {
                case "Ekle":
                    DuyuruAdd();
                    break;
                case "Güncelle":
                    DuyuruUpdate();
                    break;
                case "Sil":
                    DuyuruDelete();
                    break;
            }
            DuyuruTabPageLoad();
        }

        private void DuyuruDelete()
        {
            try
            {
                var entity = duyuruServis.GetEntity(c => c.Id == id);
                duyuruServis.Delete(entity);
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void DuyuruUpdate()
        {
            try
            {
                var entity = duyuruServis.GetEntity(c => c.Id == id);
                entity.Aciklama = aciklamaTxtDuyuru.Text;
                duyuruServis.Update(entity);
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void DuyuruAdd()
        {
            try
            {
                duyuruServis.Add(new Duyuru
                {
                    Tarih = DateTime.Now,
                    Aciklama = aciklamaTxtDuyuru.Text
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void gridView8_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView8.GetFocusedRowCellValue("Id").ToString());
            aciklamaTxtDuyuru.Text = gridView8.GetFocusedRowCellValue("Aciklama").ToString();
        }

        private void gridView9_Click(object sender, EventArgs e)
        {
            id = int.Parse(gridView9.GetFocusedRowCellValue("Id").ToString());
            ayCbxKasa.Text = gridView9.GetFocusedRowCellValue("Ay").ToString();
            tutarTxtKasa.Text = gridView9.GetFocusedRowCellValue("Tutar").ToString();
        }

        private void Kasa_Vt_Bttns_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            switch (btn.Text)
            {
                case "Ekle":
                    KasaAdd();
                    break;
                case "Güncelle":
                    KasaUpdate();
                    break;
                case "Sil":
                    KasaDelete();
                    break;
            }
            KasaTabPageLoad();
        }

        private void KasaDelete()
        {
            try
            {
                var entity = kasaServis.GetEntity(c => c.Id == id);
                kasaServis.Delete(entity);
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void KasaUpdate()
        {
            try
            {
                var entity = kasaServis.GetEntity(c => c.Id == id);
                entity.Ay = ayCbxKasa.Text;
                entity.Tutar = decimal.Parse(tutarTxtKasa.Text.ToString());
                kasaServis.Update(entity);
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

        private void KasaAdd()
        {
            try
            {
                kasaServis.Add(new Kasa
                {
                    Ay = ayCbxKasa.Text,
                    Yil = yilTxtKasa.Text,
                    Tutar = decimal.Parse(tutarTxtKasa.Text)
                });
                MessageBox.Show("Başarılı");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }
    }
}
