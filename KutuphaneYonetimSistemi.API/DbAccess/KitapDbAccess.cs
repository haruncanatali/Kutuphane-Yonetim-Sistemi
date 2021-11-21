using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.API.Entities;

namespace KutuphaneYonetimSistemi.API.DbAccess
{
    public class KitapDbAccess
    {
        private List<Kitap> kitapList = null;
        public List<Kitap> KitaplariDondur()
        {
            kitapList = new List<Kitap>();
            string listCommand =
                "select Id,Ad,BasimYili,YayinEvi,SayfaSayisi,Durum,KategoriId,YazarId,KitapFotoUrl from Tbl_Kitap";
            SqlCommand komut = new SqlCommand(listCommand, SqlBaglantisi.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            
            while (okuyucu.Read())
            {
                kitapList.Add(new Kitap
                {
                    Id = int.Parse(okuyucu[0].ToString()),
                    Ad = okuyucu[1].ToString(),
                    BasimYili = okuyucu[2].ToString(),
                    YayinEvi = okuyucu[3].ToString(),
                    SayfaSayisi = short.Parse(okuyucu[4].ToString()),
                    Durum = bool.Parse(okuyucu[5].ToString()),
                    KategoriId = int.Parse(okuyucu[6].ToString()),
                    YazarId = int.Parse(okuyucu[7].ToString()),
                    KitapFotoUrl = okuyucu[8].ToString()
                });
            }

            SqlBaglantisi.BaglantiDondur().Close();

            string kategoriCommand = "select Id,Ad from Tbl_Kategori where Id=@p1";

            foreach (var kitap in kitapList)
            {
                SqlCommand komut1 = new SqlCommand(kategoriCommand, SqlBaglantisi.BaglantiDondur());
                komut1.Parameters.AddWithValue("@p1", kitap.KategoriId);
                SqlDataReader okuyucu1 = komut1.ExecuteReader();
                while (okuyucu1.Read())
                {
                    kitap.Kategorisi = new Kategori
                    {
                        Id = int.Parse(okuyucu1[0].ToString()),
                        Ad = okuyucu1[1].ToString()
                    };
                }

                SqlBaglantisi.BaglantiDondur().Close();
            }

            string yazarCommand = "select Id,Ad,Soyad,Detay from Tbl_Yazar where Id=@p1";

            foreach (var kitap in kitapList)
            {
                SqlCommand komut2 = new SqlCommand(yazarCommand, SqlBaglantisi.BaglantiDondur());
                komut2.Parameters.AddWithValue("@p1", kitap.KategoriId);
                SqlDataReader okuyucu2 = komut2.ExecuteReader();
                while (okuyucu2.Read())
                {
                    kitap.Yazari = new Yazar
                    {
                        Id = int.Parse(okuyucu2[0].ToString()),
                        Ad = okuyucu2[1].ToString(),
                        Soyad = okuyucu2[2].ToString(),
                        Detay = okuyucu2[3].ToString()
                    };
                }

                SqlBaglantisi.BaglantiDondur().Close();
            }

            return kitapList;
        }
    }
}
