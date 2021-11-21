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
    [Activity(Label = "Duyurular")]
    public class Duyurular : Activity
    {
        private Button anasayfaButton;
        private ListView duyuruListView;
        private IApiHelper apiContext;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.duyurular);
            Tanimla();
        }

        private async void Tanimla()
        {
            anasayfaButton = FindViewById<Button>(Resource.Id.anasayfaButonCeza);
            duyuruListView = FindViewById<ListView>(Resource.Id.duyurularListV);

            anasayfaButton.Click += async delegate
            {
                StartActivity(typeof(Anasayfa));
            };

            apiContext = RestService.For<IApiHelper>(DbAnahtarTablosu.HostName);

            var duyurular = await apiContext.DuyurularPost();

            if (duyurular!=null && duyurular.Count>0)
            {
                DuyurularAdapter adapter = new DuyurularAdapter(this, duyurular);
                duyuruListView.Adapter = adapter;
            }
            else
            {
                Toast.MakeText(this,"Duyuru bulunamadı.",ToastLength.Long).Show();
            }

        }
    }
}