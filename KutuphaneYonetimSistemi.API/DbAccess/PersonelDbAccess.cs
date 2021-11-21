using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.API.Entities;

namespace KutuphaneYonetimSistemi.API.DbAccess
{
    public class PersonelDbAccess
    {
        private List<Personel> personelList = null;

        public List<Personel> PersonelleriDondur()
        {
            personelList = new List<Personel>();
            string listCommand = "select Id,Ad,Soyad,Telefon from Tbl_Personel";
            SqlCommand komut = new SqlCommand(listCommand, SqlBaglantisi.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                personelList.Add(new Personel
                {
                    Id = int.Parse(okuyucu[0].ToString()),
                    Ad = okuyucu[1].ToString(),
                    Soyad = okuyucu[2].ToString(),
                    Telefon = okuyucu[3].ToString()
                });   
            }
            SqlBaglantisi.BaglantiDondur().Close();
            return personelList;
        }
    }
}
