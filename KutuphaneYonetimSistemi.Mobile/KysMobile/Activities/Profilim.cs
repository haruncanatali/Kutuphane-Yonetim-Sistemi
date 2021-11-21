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
    [Activity(Label = "Profilim")]
    public class Profilim : Activity
    {
        private Button guncelleBtn, anasayfaBtn;

        private EditText 
            adEdx,
            soyadEdx,
            kullaniciAdiEdx,
            sifreEdx,
            mailEdx,
            fotografEdx,
            telefonEdx,
            adresEdx,
            okulEdx,
            tcEdx;

        private ImageView profilResmiImg;

        private int id;

        private IApiHelper apiContext;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.profilim);

            Tanimla();
            Doldur();
        }

        private void Doldur()
        {
            if (LoginUser.uye!=null)
            {
                profilResmiImg.SetImageBitmap(ImgHelper.LogoTanimla(LoginUser.uye.Fotograf));
                adEdx.Text = LoginUser.uye.Ad;
                soyadEdx.Text = LoginUser.uye.Soyad;
                kullaniciAdiEdx.Text = LoginUser.uye.KullaniciAdi;
                sifreEdx.Text = LoginUser.uye.Sifre;
                mailEdx.Text = LoginUser.uye.Mail;
                fotografEdx.Text = LoginUser.uye.Fotograf;
                telefonEdx.Text = LoginUser.uye.Telefon;
                adresEdx.Text = LoginUser.uye.Adres;
                okulEdx.Text = LoginUser.uye.Okul;
                tcEdx.Text = LoginUser.uye.Tckn;
            }
            else
            {
                Toast.MakeText(this,"Giriş yapın",ToastLength.Short).Show();
                //StartActivity(typeof(MainActivity));
            }
        }

        private void Tanimla()
        {
            guncelleBtn = FindViewById<Button>(Resource.Id.guncelleBtn);
            anasayfaBtn = FindViewById<Button>(Resource.Id.anasayfaBtn);

            adEdx = FindViewById<EditText>(Resource.Id.adTxt);
            soyadEdx = FindViewById<EditText>(Resource.Id.soyadTxt);
            kullaniciAdiEdx = FindViewById<EditText>(Resource.Id.kullaniciAdiTxt);
            sifreEdx = FindViewById<EditText>(Resource.Id.sifreTxt);
            mailEdx = FindViewById<EditText>(Resource.Id.mailTxt);
            fotografEdx = FindViewById<EditText>(Resource.Id.fotoTxt);
            telefonEdx = FindViewById<EditText>(Resource.Id.telefonTxt);
            adresEdx = FindViewById<EditText>(Resource.Id.adresTxt);
            okulEdx = FindViewById<EditText>(Resource.Id.okulTxt);
            tcEdx = FindViewById<EditText>(Resource.Id.tcknTxt);

            id = LoginUser.uye != null ? LoginUser.uye.Id : -1;

            guncelleBtn.Click += GuncelleBtn_Click;
            anasayfaBtn.Click += AnasayfaBtn_Click;

            profilResmiImg = FindViewById<ImageView>(Resource.Id.profilFotoImg);
        }

        private void AnasayfaBtn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Anasayfa));
        }

        private async void GuncelleBtn_Click(object sender, EventArgs e)
        {
            apiContext = RestService.For<IApiHelper>(DbAnahtarTablosu.HostName);
            try
            {
                var uye = new Uye
                {
                    Id = id,
                    Ad = adEdx.Text,
                    Soyad = soyadEdx.Text,
                    KullaniciAdi = kullaniciAdiEdx.Text,
                    Sifre = sifreEdx.Text,
                    Mail = mailEdx.Text,
                    Fotograf = fotografEdx.Text,
                    Telefon = telefonEdx.Text,
                    Adres = adresEdx.Text,
                    Okul = okulEdx.Text,
                    Tckn = tcEdx.Text
                };

                var result = await apiContext.UpdatePost(uye);

                if (result!=null)
                {
                    LoginUser.uye = uye;
                    Toast.MakeText(this,"Güncelleme başarılı oldu.",ToastLength.Short).Show();
                    StartActivity(typeof(Anasayfa));
                }
                else
                {
                    Toast.MakeText(this, "Güncelleme başarısız oldu.", ToastLength.Short).Show();
                }
            }
            catch (Exception exception)
            {
                Toast.MakeText(this,exception.Message,ToastLength.Long).Show();
            }
        }
    }
}