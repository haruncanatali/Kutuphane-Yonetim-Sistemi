using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.API.Entities;

namespace KutuphaneYonetimSistemi.API.DbAccess
{
    public class DuyuruDbAccess
    {
        private List<Duyuru> duyuruList;
        public List<Duyuru> DuyurulariDondur()
        {
            duyuruList = new List<Duyuru>();
            string listCommad = "select Id,Tarih,Aciklama from Tbl_Duyuru";
            SqlCommand komut = new SqlCommand(listCommad, SqlBaglantisi.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                duyuruList.Add(new Duyuru
                {
                    Id = int.Parse(okuyucu[0].ToString()),
                    Aciklama = okuyucu[1].ToString(),
                    Tarih = DateTime.Parse(okuyucu[2].ToString())
                });
            }

            SqlBaglantisi.BaglantiDondur().Close();

            return duyuruList;
        }
    }
}
