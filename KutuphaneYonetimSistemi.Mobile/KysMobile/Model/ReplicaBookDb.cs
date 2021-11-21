using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KysMobile.Entities;

namespace KysMobile.Model
{
    public class ReplicaBookDb
    {
        public static List<Kitap> kitapList = null;

        public static List<Kitap> ReplicaKitaplar()
        {
            kitapList = new List<Kitap>();

            kitapList.Add(new Kitap
            {
                Id = 1,
                Ad = "Metal Fırtına",
                BasimYili = "2006",
                YayinEvi = "Orhun Yayınevi",
                KategoriId = 1,
                SayfaSayisi = 350,
                YazarId = 1,
                KitapFotoUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0000000168465-1.jpg",
                Durum = true,
                Yazari = new Yazar
                {
                    Id = 1,
                    Ad = "Orkun",
                    Soyad = "Uçar",
                    Detay = "Yok"
                },
                Kategorisi = new Kategori
                {
                    Ad = "Aksiyon",
                    Id = 1
                }
            });

            kitapList.Add(new Kitap
            {
                Id = 2,
                Ad = "Metal Fırtına-Uyanış",
                BasimYili = "2007",
                YayinEvi = "Orhun Yayınevi",
                KategoriId = 1,
                SayfaSayisi = 351,
                YazarId = 1,
                KitapFotoUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0000000630668-1.jpg",
                Durum = true,
                Yazari = new Yazar
                {
                    Id = 1,
                    Ad = "Orkun",
                    Soyad = "Uçar",
                    Detay = "Yok"
                },
                Kategorisi = new Kategori
                {
                    Ad = "Aksiyon",
                    Id = 1
                }
            });

            kitapList.Add(new Kitap
            {
                Id = 3,
                Ad = "Metal Fırtına-Hakikat Muhafızları",
                BasimYili = "2008",
                YayinEvi = "Orhun Yayınevi",
                KategoriId = 1,
                SayfaSayisi = 352,
                YazarId = 1,
                KitapFotoUrl = "https://i.dr.com.tr/cache/500x400-0/originals/0001798589001-1.jpg",
                Durum = false,
                Yazari = new Yazar
                {
                    Id = 1,
                    Ad = "Orkun",
                    Soyad = "Uçar",
                    Detay = "Yok"
                },
                Kategorisi = new Kategori
                {
                    Ad = "Aksiyon",
                    Id = 1
                }
            });

            kitapList.Add(new Kitap
            {
                Id = 4,
                Ad = "Metal Fırtına-Kurtuluş",
                BasimYili = "2009",
                YayinEvi = "Orhun Yayınevi",
                KategoriId = 1,
                SayfaSayisi = 353,
                YazarId = 1,
                KitapFotoUrl = "https://productimages.hepsiburada.net/s/8/375/8802157133874.jpg",
                Durum = false,
                Yazari = new Yazar
                {
                    Id = 1,
                    Ad = "Orkun",
                    Soyad = "Uçar",
                    Detay = "Yok"
                },
                Kategorisi = new Kategori
                {
                    Ad = "Aksiyon",
                    Id = 1
                }
            });

            kitapList.Add(new Kitap
            {
                Id = 5,
                Ad = "Metal Fırtına-Karşı Saldırı",
                BasimYili = "2010",
                YayinEvi = "Orhun Yayınevi",
                KategoriId = 1,
                SayfaSayisi = 354,
                YazarId = 1,
                KitapFotoUrl = "https://static.destekdukkan.com/files/urun_urunler/img/ac/600x900x2/metal-firtina-3-karsi-saldiri.jpg",
                Durum = false,
                Yazari = new Yazar
                {
                    Id = 1,
                    Ad = "Orkun",
                    Soyad = "Uçar",
                    Detay = "Yok"
                },
                Kategorisi = new Kategori
                {
                    Ad = "Aksiyon",
                    Id = 1
                }
            });

            kitapList.Add(new Kitap
            {
                Id = 6,
                Ad = "Metal Fırtına-Turan",
                BasimYili = "2011",
                YayinEvi = "Orhun Yayınevi",
                KategoriId = 1,
                SayfaSayisi = 355,
                YazarId = 1,
                KitapFotoUrl = "https://images.kitapsepeti.com/Content/global/images/products/4/409269/metal-firtina-4-turan.jpg",
                Durum = false,
                Yazari = new Yazar
                {
                    Id = 1,
                    Ad = "Orkun",
                    Soyad = "Uçar",
                    Detay = "Yok"
                },
                Kategorisi = new Kategori
                {
                    Ad = "Aksiyon",
                    Id = 1
                }
            });


            return kitapList;
        }
    }
}