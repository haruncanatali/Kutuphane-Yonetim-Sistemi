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
    [Activity(Label = "KitaplarPost")]
    public class Kitaplar : Activity
    {
        private ListView kitaplarListView;
        private Button anasayfaBtn;
        private IApiHelper apiContext;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.kitaplar);
            Tanimla();
        }

        private async void Tanimla()
        {
            kitaplarListView = FindViewById<ListView>(Resource.Id.kitaplarListV);
            anasayfaBtn = FindViewById<Button>(Resource.Id.anasayfaButon);

            //apiContext = RestService.For<IApiHelper>(DbAnahtarTablosu.HostName);

            //var kitapListesi = await apiContext.KitaplarPost();

            //if (kitapListesi!=null && kitapListesi.Count>0)
            //{
            //    KitaplarAdapter adapter = new KitaplarAdapter(this, kitapListesi);
            //    kitaplarListView.Adapter = adapter;
            //}
            //else
            //{
            //    Toast.MakeText(this,"KitaplarPost veritabanından çekilemedi.",ToastLength.Long).Show();
            //}

            KitaplarAdapter adapter = new KitaplarAdapter(this, ReplicaBookDb.ReplicaKitaplar());
            kitaplarListView.Adapter = adapter;

            anasayfaBtn.Click += async delegate
            {
                StartActivity(typeof(Anasayfa));
            };
        }
    }
}