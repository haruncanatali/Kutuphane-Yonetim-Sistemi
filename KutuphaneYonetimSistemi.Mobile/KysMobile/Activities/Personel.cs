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
    [Activity(Label = "Personel")]
    public class Personel : Activity
    {
        private Button anasayfaButton;
        private ListView personellerListView;
        private IApiHelper apiContext;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.personeller);
            Tanimla();
        }

        private async void Tanimla()
        {
            anasayfaButton = FindViewById<Button>(Resource.Id.anasayfaButonPersonel);
            anasayfaButton.Click += async delegate
            {
                StartActivity(typeof(Anasayfa));
            };

            apiContext = RestService.For<IApiHelper>(DbAnahtarTablosu.HostName);

            personellerListView = FindViewById<ListView>(Resource.Id.personellerListV);

            List<Entities.Personel> personeller = await apiContext.PersonellerPost();
            
            if (personeller!=null && personeller.Count>0)
            {
                PersonellerAdapter adapter = new PersonellerAdapter(this, personeller);
                personellerListView.Adapter = adapter;
            }
            else
            {
                Toast.MakeText(this,"Personel bulunamadı.",ToastLength.Long).Show();
            }
        }
    }
}