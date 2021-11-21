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
using KysMobile.Adapters;
using KysMobile.Model;
using Refit;

namespace KysMobile.Activities
{
    [Activity(Label = "Hareketler")]
    public class Hareketler : Activity
    {
        private ListView hareketListView;
        private Button anasayfaButton;
        private IApiHelper apiContext;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.hareketler);
            Tanimla();
        }

        private async void Tanimla()
        {
            hareketListView = FindViewById<ListView>(Resource.Id.hareketlerListV);
            anasayfaButton = FindViewById<Button>(Resource.Id.anasayfaButonHareket);

            apiContext = RestService.For<IApiHelper>(DbAnahtarTablosu.HostName);

            var hareketListesi = await apiContext.HareketlerimPost(LoginUser.uye.Id);
            if (hareketListesi!=null && hareketListesi.Count>0)
            {
                HareketlerAdapter adapter = new HareketlerAdapter(this, hareketListesi);
                hareketListView.Adapter = adapter;
            }
            else
            {
                Toast.MakeText(this,"Hesabınıza kayıtlı hareket bulunamadı.",ToastLength.Long).Show();
            }

            anasayfaButton.Click += async delegate
            {
                StartActivity(typeof(Anasayfa));
            };
        }
    }
}