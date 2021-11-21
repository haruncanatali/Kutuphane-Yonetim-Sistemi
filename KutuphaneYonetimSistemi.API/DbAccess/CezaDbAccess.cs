using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.API.Entities;

namespace KutuphaneYonetimSistemi.API.DbAccess
{
    public class CezaDbAccess
    {
        private List<Ceza> cezaList = null;

        public List<Ceza> CezalariDondur(int id)
        {
            cezaList = new List<Ceza>();
            string listCommand = "select Id,BaslangicTarihi,BitisTarihi,Para,HareketId from Tbl_Ceza where UyeId=@p1";
            SqlCommand komut = new SqlCommand(listCommand, SqlBaglantisi.BaglantiDondur());
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                cezaList.Add(new Ceza
                {
                    Id = int.Parse(okuyucu[0].ToString()),
                    BaslangicTarihi = DateTime.Parse(okuyucu[1].ToString()),
                    BitisTarihi = DateTime.Parse(okuyucu[2].ToString()),
                    Para = decimal.Parse(okuyucu[3].ToString()),
                    HareketId = int.Parse(okuyucu[4].ToString())
                });
            }
            SqlBaglantisi.BaglantiDondur().Close();

            return cezaList;
        }
    }
}
