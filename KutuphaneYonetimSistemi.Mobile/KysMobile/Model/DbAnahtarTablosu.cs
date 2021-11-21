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

namespace KysMobile.Model
{
    public static class DbAnahtarTablosu
    {
        public const string HostName = "https://kutuphaneyonetimsistemi-api.conveyor.cloud";
        public const string LoginPath = "/api/account/login";
        public const string UyelerListesiPath = "/api/account/uyeler";
        public const string RegisterPath = "/api/account/register";
        public const string UpdatePath = "/api/account/update";
        public const string DeletePath = "/api/account/delete";
        public const string KitaplarPath = "/api/values/kitaplar";
        public const string CezalarimPath = "/api/values/cezalarim";
        public const string HareketlerimPath = "/api/values/hareketlerim";
        public const string DuyurularPath = "/api/values/duyurular";
        public const string PersonellerPath = "/api/values/personeller";

        public const string GirisLogoPath = "https://cdn-icons-png.flaticon.com/512/225/225932.png";
        public const string KitapLogoPath = "https://e7.pngegg.com/pngimages/738/247/png-clipart-book-book.png";

        public const string HareketLogoPath =
            "https://banner2.cleanpng.com/20180702/fzu/kisspng-computer-icons-download-file-transfer-transfer-icon-5b3a50258a5ed6.2639919015305482615668.jpg";
        public const string CezaLogoPath = "https://w7.pngwing.com/pngs/549/179/png-transparent-money-bag-money-bag.png";
        public const string DuyuruLogoPath = "https://i.pinimg.com/564x/f4/30/4b/f4304bea0a5dfd2b59e7290a08273c68.jpg";
        public const string PersonelLogoPath = "https://cdn4.iconfinder.com/data/icons/people-avatar-1-1/128/29-512.png";
    }
}