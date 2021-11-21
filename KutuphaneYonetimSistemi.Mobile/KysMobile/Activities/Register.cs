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
using KysMobile.Entities;
using KysMobile.Model;
using Refit;

namespace KysMobile.Activities
{
    [Activity(Label = "Register")]
    public class Register : Activity
    {
        private EditText adEdx,
                         soyadEdx,
                         mailEdx,
                         telefonEdx,
                         tcEdx,
                         okulEdx,
                         usernameEdx,
                         passwordEdx,
                         fotoEdx,
                         adresEdx;

        private Button kayitOlBtn,geriDonButton;

        private IApiHelper apiContext;

        private Uye uye = null;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.register);

            Tanimla();
        }

        private void Tanimla()
        {
            adEdx = FindViewById<EditText>(Resource.Id.adTxt);
            soyadEdx = FindViewById<EditText>(Resource.Id.soyadTxt);
            mailEdx = FindViewById<EditText>(Resource.Id.mailTxt);
            telefonEdx = FindViewById<EditText>(Resource.Id.telefonTxt);
            tcEdx = FindViewById<EditText>(Resource.Id.tcTxt);
            okulEdx = FindViewById<EditText>(Resource.Id.okulTxt);
            usernameEdx = FindViewById<EditText>(Resource.Id.kullaniciAdiTxt);
            passwordEdx = FindViewById<EditText>(Resource.Id.sifreTxt);
            fotoEdx = FindViewById<EditText>(Resource.Id.fotoTxt);
            adresEdx = FindViewById<EditText>(Resource.Id.adresTxt);

            kayitOlBtn = FindViewById<Button>(Resource.Id.kayitOlBtn);
            geriDonButton = FindViewById<Button>(Resource.Id.geriDonBtn);
            apiContext = RestService.For<IApiHelper>(DbAnahtarTablosu.HostName);

            geriDonButton.Click += async delegate
            {
                StartActivity(typeof(MainActivity));
            };

            kayitOlBtn.Click += async delegate
            {
                Toast.MakeText(this,"Kayıt olunuyor lütfen bekleyin ... ",ToastLength.Long).Show();
                try
                {
                    RegisterModel model = new RegisterModel
                    {
                        Ad = adEdx.Text,
                        Soyad = soyadEdx.Text,
                        Mail = mailEdx.Text,
                        Telefon = telefonEdx.Text,
                        Tckn = tcEdx.Text,
                        Okul = okulEdx.Text,
                        KullaniciAdi = usernameEdx.Text,
                        Sifre = passwordEdx.Text,
                        Fotograf = fotoEdx.Text,
                        Adres = adresEdx.Text
                    };

                    uye = await apiContext.RegisterPost(model);

                    if (uye!=null)
                    {
                        LoginUser.uye = uye;
                    }
                    else
                    {
                        Toast.MakeText(this,"Kullanıcı eklenirken hata meydana geldi.",ToastLength.Long).Show();
                    }
                }
                catch (Exception exception)
                {
                    Toast.MakeText(this, "Hata :" + exception.Message, ToastLength.Long).Show();
                }

                if (uye!=null)
                {
                    Toast.MakeText(this,"Kayıt başarılı oldu.",ToastLength.Long).Show();
                    StartActivity(typeof(Anasayfa));
                }
                else
                {
                    Toast.MakeText(this,"Kayıt başarısız oldu.",ToastLength.Long).Show();
                }
            };
        }

    }
}