using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.API.Entities;
using KutuphaneYonetimSistemi.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace KutuphaneYonetimSistemi.API.DbAccess
{
    public class UyeDbAccess
    {
        ~UyeDbAccess()
        {
            uye = null;
        }
        private Uye uye = null;

        public List<Uye> UyeleriDondur()
        {
            List<Uye> uyeler = new List<Uye>();
            SqlCommand komut = new SqlCommand("select * from Tbl_Uye", SqlBaglantisi.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                uyeler.Add(new Uye
                {
                    Id = int.Parse(okuyucu[0].ToString()),
                    Ad = okuyucu[1].ToString(),
                    Soyad = okuyucu[2].ToString(),
                    Mail = okuyucu[3].ToString(),
                    KullaniciAdi = okuyucu[4].ToString(),
                    Sifre = okuyucu[5].ToString(),
                    Fotograf = okuyucu[6].ToString(),
                    Telefon = okuyucu[7].ToString(),
                    Adres = okuyucu[8].ToString(),
                    Okul = okuyucu[9].ToString(),
                    Tckn = okuyucu[10].ToString()
                });
            }

            okuyucu.Close();
            SqlBaglantisi.BaglantiDondur().Close();

            return uyeler;
        }
        public Uye Login([FromBody] LoginDto model)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Uye where KullaniciAdi=@p1 and Sifre=@p2", SqlBaglantisi.BaglantiDondur());
            komut.Parameters.AddWithValue("@p1", model.Username);
            komut.Parameters.AddWithValue("@p2", model.Password);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                uye = new Uye();
                uye.Id = int.Parse(okuyucu[0].ToString());
                uye.Ad = okuyucu[1].ToString();
                uye.Soyad = okuyucu[2].ToString();
                uye.Mail = okuyucu[3].ToString();
                uye.KullaniciAdi = okuyucu[4].ToString();
                uye.Sifre = okuyucu[5].ToString();
                uye.Fotograf = okuyucu[6].ToString();
                uye.Telefon = okuyucu[7].ToString();
                uye.Adres = okuyucu[8].ToString();
                uye.Okul = okuyucu[9].ToString();
                uye.Tckn = okuyucu[10].ToString();
            }

            okuyucu.Close();
            SqlBaglantisi.BaglantiDondur().Close();

            if (uye != null)
            {
                SqlCommand komut1 = new SqlCommand("select Id,AlisTarihi,IadeTarihi,KitapId,UyeId from Tbl_Hareket where UyeId=@p1",
                    SqlBaglantisi.BaglantiDondur());
                komut1.Parameters.AddWithValue("@p1", uye.Id);
                SqlDataReader okuyucu1 = komut1.ExecuteReader();
                while (okuyucu1.Read())
                {
                    uye.Hareketler.Add(new Hareket
                    {
                        Id = int.Parse(okuyucu1[0].ToString()),
                        AlisTarihi = DateTime.Parse(okuyucu1[1].ToString()),
                        IadeTarihi = DateTime.Parse(okuyucu1[2].ToString()),
                        KitapId = int.Parse(okuyucu1[3].ToString()),
                        UyeId = int.Parse(okuyucu1[4].ToString())
                    });
                }

                okuyucu1.Close();
                SqlBaglantisi.BaglantiDondur().Close();

                SqlCommand komut2 =
                    new SqlCommand("select Id,BaslangicTarihi,BitisTarihi,Para,UyeId,HareketId from Tbl_Ceza where UyeId=@p1",
                        SqlBaglantisi.BaglantiDondur());
                komut2.Parameters.AddWithValue("@p1", uye.Id);
                SqlDataReader okuyucu2 = komut2.ExecuteReader();
                while (okuyucu2.Read())
                {
                    uye.Cezalar.Add(new Ceza
                    {
                        Id = int.Parse(okuyucu2[0].ToString()),
                        BaslangicTarihi = DateTime.Parse(okuyucu2[1].ToString()),
                        BitisTarihi = DateTime.Parse(okuyucu2[2].ToString()),
                        Para = decimal.Parse(okuyucu2[3].ToString()),
                        UyeId = int.Parse(okuyucu2[4].ToString()),
                        HareketId = int.Parse(okuyucu2[5].ToString())
                    });
                }

                okuyucu2.Close();
                SqlBaglantisi.BaglantiDondur().Close();
            }

            return uye;
        }

        public bool Update(Uye model)
        {
            try
            {
                var updateCommand =
                    "update Tbl_Uye set Ad=@p1,Soyad=@p2,Mail=@p3,KullaniciAdi=@p4,Sifre=@p5,Fotograf=@p6,Telefon=@p7,Adres=@p8,Okul=@p9,Tckn=@p10 where Id=@p11";
                SqlCommand komut = new SqlCommand(updateCommand, SqlBaglantisi.BaglantiDondur());

                komut.Parameters.AddWithValue("@p11", model.Id);
                komut.Parameters.AddWithValue("@p1", model.Ad);
                komut.Parameters.AddWithValue("@p2", model.Soyad);
                komut.Parameters.AddWithValue("@p3", model.Mail);
                komut.Parameters.AddWithValue("@p4", model.KullaniciAdi);
                komut.Parameters.AddWithValue("@p5", model.Sifre);
                komut.Parameters.AddWithValue("@p6", model.Fotograf);
                komut.Parameters.AddWithValue("@p7", model.Telefon);
                komut.Parameters.AddWithValue("@p8", model.Adres);
                komut.Parameters.AddWithValue("@p9", model.Okul);
                komut.Parameters.AddWithValue("@p10", model.Tckn);

                komut.ExecuteNonQuery();

                SqlBaglantisi.BaglantiDondur().Close();

                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                string deleteCommand = "delete from Tbl_Uye where Id=@p1";
                SqlCommand komut = new SqlCommand(deleteCommand, SqlBaglantisi.BaglantiDondur());
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();
                SqlBaglantisi.BaglantiDondur().Close();
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public Uye Register(RegisterDto model)
        {
            try
            {
                var insertCommand =
                    "insert into Tbl_Uye(Ad,Soyad,Mail,KullaniciAdi,Sifre,Fotograf,Telefon,Adres,Okul,Tckn) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
                SqlCommand komut = new SqlCommand(insertCommand, SqlBaglantisi.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", model.Ad);
                komut.Parameters.AddWithValue("@p2", model.Soyad);
                komut.Parameters.AddWithValue("@p3", model.Mail);
                komut.Parameters.AddWithValue("@p4", model.KullaniciAdi);
                komut.Parameters.AddWithValue("@p5", model.Sifre);
                komut.Parameters.AddWithValue("@p6", model.Fotograf);
                komut.Parameters.AddWithValue("@p7", model.Telefon);
                komut.Parameters.AddWithValue("@p8", model.Adres);
                komut.Parameters.AddWithValue("@p9", model.Okul);
                komut.Parameters.AddWithValue("@p10", model.Tckn);

                komut.ExecuteNonQuery();

                SqlBaglantisi.BaglantiDondur().Close();

                var findCommand = "select * from Tbl_Uye where Tckn=@p1";
                SqlCommand komut1 = new SqlCommand(findCommand, SqlBaglantisi.BaglantiDondur());
                komut1.Parameters.AddWithValue("@p1", model.Tckn);
                SqlDataReader okuyucu = komut1.ExecuteReader();

                var uye = new Uye();

                while (okuyucu.Read())
                {
                    uye.Id = int.Parse(okuyucu[0].ToString());
                    uye.Ad = okuyucu[1].ToString();
                    uye.Soyad = okuyucu[2].ToString();
                    uye.Mail = okuyucu[3].ToString();
                    uye.KullaniciAdi = okuyucu[4].ToString();
                    uye.Sifre = okuyucu[5].ToString();
                    uye.Fotograf = okuyucu[6].ToString();
                    uye.Telefon = okuyucu[7].ToString();
                    uye.Adres = okuyucu[8].ToString();
                    uye.Okul = okuyucu[9].ToString();
                    uye.Tckn = okuyucu[10].ToString();
                }

                SqlBaglantisi.BaglantiDondur().Close();

                return uye;

            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public Uye UyeDondur(int id)
        {
            uye = null;
            string getCommand = "select * from Tbl_Uye where Id=@p1";
            SqlCommand komut = new SqlCommand(getCommand, SqlBaglantisi.BaglantiDondur());
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader okuyucu = komut.ExecuteReader();

            while (okuyucu.Read())
            {
                uye = new Uye();
                uye.Id = int.Parse(okuyucu[0].ToString());
                uye.Ad = okuyucu[1].ToString();
                uye.Soyad = okuyucu[2].ToString();
                uye.Mail = okuyucu[3].ToString();
                uye.KullaniciAdi = okuyucu[4].ToString();
                uye.Sifre = okuyucu[5].ToString();
                uye.Fotograf = okuyucu[6].ToString();
                uye.Telefon = okuyucu[7].ToString();
                uye.Adres = okuyucu[8].ToString();
                uye.Okul = okuyucu[9].ToString();
                uye.Tckn = okuyucu[10].ToString();
            }

            okuyucu.Close();
            SqlBaglantisi.BaglantiDondur().Close();

            if (uye != null)
            {
                SqlCommand komut1 = new SqlCommand("select Id,AlisTarihi,IadeTarihi,KitapId,UyeId from Tbl_Hareket where UyeId=@p1",
                    SqlBaglantisi.BaglantiDondur());
                komut1.Parameters.AddWithValue("@p1", uye.Id);
                SqlDataReader okuyucu1 = komut1.ExecuteReader();
                while (okuyucu1.Read())
                {
                    uye.Hareketler.Add(new Hareket
                    {
                        Id = int.Parse(okuyucu1[0].ToString()),
                        AlisTarihi = DateTime.Parse(okuyucu1[1].ToString()),
                        IadeTarihi = DateTime.Parse(okuyucu1[2].ToString()),
                        KitapId = int.Parse(okuyucu1[3].ToString()),
                        UyeId = int.Parse(okuyucu1[4].ToString())
                    });
                }

                okuyucu1.Close();
                SqlBaglantisi.BaglantiDondur().Close();

                SqlCommand komut2 =
                    new SqlCommand("select Id,BaslangicTarihi,BitisTarihi,Para,UyeId,HareketId from Tbl_Ceza where UyeId=@p1",
                        SqlBaglantisi.BaglantiDondur());
                komut2.Parameters.AddWithValue("@p1", uye.Id);
                SqlDataReader okuyucu2 = komut2.ExecuteReader();
                while (okuyucu2.Read())
                {
                    uye.Cezalar.Add(new Ceza
                    {
                        Id = int.Parse(okuyucu2[0].ToString()),
                        BaslangicTarihi = DateTime.Parse(okuyucu2[1].ToString()),
                        BitisTarihi = DateTime.Parse(okuyucu2[2].ToString()),
                        Para = decimal.Parse(okuyucu2[3].ToString()),
                        UyeId = int.Parse(okuyucu2[4].ToString()),
                        HareketId = int.Parse(okuyucu2[5].ToString())
                    });
                }

                okuyucu2.Close();
                SqlBaglantisi.BaglantiDondur().Close();

            }
            return uye;
        }
    }
}
