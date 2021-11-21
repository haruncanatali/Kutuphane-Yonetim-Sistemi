using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.API.Entities;

namespace KutuphaneYonetimSistemi.API.DbAccess
{
    public class HareketDbAccess
    {
        private List<Hareket> hareketList;
        public List<Hareket> HareketleriDondur(int id)
        {
            hareketList = new List<Hareket>();
            string listCommand = "select Id,AlisTarihi,IadeTarihi,KitapId from Tbl_Hareket where UyeId=@p1";
            SqlCommand komut = new SqlCommand(listCommand, SqlBaglantisi.BaglantiDondur());
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                hareketList.Add(new Hareket
                {
                    Id = int.Parse(okuyucu[0].ToString()),
                    AlisTarihi = DateTime.Parse(okuyucu[1].ToString()),
                    IadeTarihi = DateTime.Parse(okuyucu[2].ToString()),
                    KitapId = int.Parse(okuyucu[3].ToString())
                });
            }

            SqlBaglantisi.BaglantiDondur().Close();

            foreach (var hareket in hareketList)
            {
                SqlCommand komut1 = new SqlCommand("select Id,Ad from Tbl_Kitap where Id=@p1",
                    SqlBaglantisi.BaglantiDondur());
                komut1.Parameters.AddWithValue("@p1", hareket.KitapId);
                SqlDataReader okuyucu1 = komut1.ExecuteReader();
                while (okuyucu1.Read())
                {
                    hareket.Kitabi = new Kitap
                    {
                        Id = int.Parse(okuyucu1[0].ToString()),
                        Ad = okuyucu1[1].ToString()
                    };
                }

                SqlBaglantisi.BaglantiDondur().Close();
            }

            return hareketList;
        }
    }
}
