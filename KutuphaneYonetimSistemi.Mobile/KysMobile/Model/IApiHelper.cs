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
using System.Threading.Tasks;
using KysMobile.Entities;
using Refit;

namespace KysMobile.Model
{
    public interface IApiHelper
    {
        [Post(DbAnahtarTablosu.LoginPath)]
        Task<Uye> LoginPost([Body] LoginModel loginModel);

        [Post(DbAnahtarTablosu.RegisterPath)]
        Task<Uye> RegisterPost([Body] RegisterModel registerModel);

        [Post(DbAnahtarTablosu.UpdatePath)]
        Task<Uye> UpdatePost([Body] Uye uye);

        [Post(DbAnahtarTablosu.KitaplarPath)]
        Task<List<Kitap>> KitaplarPost();

        [Post(DbAnahtarTablosu.CezalarimPath)]
        Task<List<Ceza>> CezalarimPost(int id);

        [Post(DbAnahtarTablosu.HareketlerimPath)]
        Task<List<Hareket>> HareketlerimPost(int id);

        [Post(DbAnahtarTablosu.DuyurularPath)]
        Task<List<Duyuru>> DuyurularPost();

        [Post(DbAnahtarTablosu.PersonellerPath)]
        Task<List<Personel>> PersonellerPost();
    }
}