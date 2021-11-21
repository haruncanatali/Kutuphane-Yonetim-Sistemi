using System;
using System.Net;
using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using KysMobile.Model;
using Refit;
using Android.Support;
using KysMobile.Activities;
using KysMobile.Entities;

namespace KysMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ImageView mainImg;
        private Button girisBtn;
        private EditText kullaniciAdiEdx, sifreEdx;
        private LinearLayout mainLayout;
        private TextView kayitBtn;

        private IApiHelper apiContext;
        private Uye uye;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Tanimla();
        }

        private void Tanimla()
        {
            mainImg = FindViewById<ImageView>(Resource.Id.anaLogo);
            girisBtn = FindViewById<Button>(Resource.Id.girisButton);
            kullaniciAdiEdx = FindViewById<EditText>(Resource.Id.kullaniciAdiTxt);
            sifreEdx = FindViewById<EditText>(Resource.Id.sifreTxt);
            mainLayout = FindViewById<LinearLayout>(Resource.Id.mainLayout);
            kayitBtn = FindViewById<TextView>(Resource.Id.kayitOl);

            //https://kutuphaneyonetimsistemi-api.conveyor.cloud/api/account/uyeler

            apiContext = RestService.For<IApiHelper>(DbAnahtarTablosu.HostName);

            mainImg.SetImageBitmap(ImgHelper.LogoTanimla(DbAnahtarTablosu.GirisLogoPath));

            girisBtn.Click += async delegate
            {
                Toast.MakeText(this, "Giriş yapılıyor lütfen bekleyin ... ", ToastLength.Short).Show();
                if (kullaniciAdiEdx.Text.Length > 0 && sifreEdx.Text.Length > 0)
                {
                    LoginModel loginModel = new LoginModel
                    {
                        Username = kullaniciAdiEdx.Text.ToString(),
                        Password = sifreEdx.Text.ToString()
                    };

                    //try
                    //{
                    //    var result = await apiContext.LoginPost(loginModel);
                    //    if (result == null)
                    //    {
                    //        Toast.MakeText(this,"Kullanıcı bulunamadı.",ToastLength.Long).Show();
                    //    }
                    //    else
                    //    {
                    //        LoginUser.uye = uye;
                    //        StartActivity(typeof(Anasayfa));
                    //    }
                    //}
                    //catch (Exception exception)
                    //{
                    //    Toast.MakeText(this, exception.Message, ToastLength.Long).Show();
                    //}
                    LoginUser.uye = new Uye
                    {
                        Id = 12,
                        Ad = "Zeynel",
                        Soyad = "Çelik",
                        Mail = "zeynel@gmail.com",
                        KullaniciAdi = "zynl",
                        Sifre = "zynl67",
                        Fotograf = "https://www.collezione.com/Uploads/UrunResimleri/erkek-taba-----gomlek-vima-0d56.jpg",
                        Telefon = "05489316767",
                        Adres = "Zonguldak/Merkez",
                        Okul = "ITU",
                        Tckn = "68758678869"
                    };
                    StartActivity(typeof(Anasayfa));
                }
                else
                {
                    Toast.MakeText(this, "Kullanıcı adı veya şifre yanlış", ToastLength.Long).Show();
                }
            };
            kayitBtn.Click += async delegate
            {
                StartActivity(typeof(Register));
            };
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}