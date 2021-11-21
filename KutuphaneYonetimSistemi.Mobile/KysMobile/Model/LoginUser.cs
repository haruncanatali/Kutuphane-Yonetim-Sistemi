using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using KysMobile.Entities;

namespace KysMobile.Model
{
    public static class LoginUser
    {
        public static Uye uye = null;

        public static void Login(Uye uye_)
        {
            uye = uye_;
        }

        public static void LogOut()
        {
            uye = null;
        }
    }
}