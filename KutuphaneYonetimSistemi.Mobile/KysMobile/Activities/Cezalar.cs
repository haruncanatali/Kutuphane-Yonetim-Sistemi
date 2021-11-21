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
    [Activity(Label = "Cezalar")]
    public class Cezalar : Activity
    {
        private Button anasayfaButton;
        private ListView cezaListView;
        private IApiHelper apiContext;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.cezalar);
            Tanimla();
        }

        private async void Tanimla()
        {
            anasayfaButton = FindViewById<Button>(Resource.Id.anasayfaButonCeza);
            cezaListView = FindViewById<ListView>(Resource.Id.cezalarListV);

            apiContext = RestService.For<IApiHelper>(DbAnahtarTablosu.HostName);

            var cezalar = await apiContext.CezalarimPost(LoginUser.uye.Id);

            if (cezalar!=null && cezalar.Count>0)
            {
                CezalarAdapter adapter = new CezalarAdapter(this, cezalar);
                cezaListView.Adapter = adapter;
            }

            anasayfaButton.Click += async delegate
            {
                StartActivity(typeof(Anasayfa));
            };
        }
    }
}