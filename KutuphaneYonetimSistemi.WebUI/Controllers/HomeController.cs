using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Ninject;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IKitapService kitapServis;
        private IPersonelService personelServis;
        private IHareketService hareketServis;
        private IUyeService uyeServis;
        private IKasaService kasaServis;
        private IDuyuruService duyuruServis;

        public HomeController()
        {
            this.kitapServis = InstanceFactory.GetInstance<IKitapService>();
            this.personelServis = InstanceFactory.GetInstance<IPersonelService>();
            this.hareketServis = InstanceFactory.GetInstance<IHareketService>();
            this.uyeServis = InstanceFactory.GetInstance<IUyeService>();
            this.kasaServis = InstanceFactory.GetInstance<IKasaService>();
            this.duyuruServis = InstanceFactory.GetInstance<IDuyuruService>();
        }
        public ActionResult Index()
        {
            ViewBag.kitapSayisi = kitapServis.GetEntities(null).Count().ToString();
            ViewBag.personelSayisi = kitapServis.GetEntities(null).Count().ToString();
            ViewBag.hareketSayisi = kitapServis.GetEntities(null).Count().ToString();
            ViewBag.uyeSayisi = kitapServis.GetEntities(null).Count().ToString();
            ViewBag.kasaTutari = kasaServis.GetEntities(null).Sum(c => c.Tutar).ToString("0.00");

            int cezaSayisi = 0;
            foreach (var item in uyeServis.GetEntities(null))
            {
                if (item.Cezalar.Count()>0)
                {
                    cezaSayisi++;
                }   
            }

            ViewBag.cezaSayisi = cezaSayisi.ToString();
            ViewBag.duyurular = duyuruServis.GetEntities(null).OrderByDescending(c=>c.Tarih).ToList();

            return View();
        }

        [HttpGet]
        public ActionResult DuyuruEkle(string duyuruVal)
        {
            if (duyuruVal!=null)
            {
                duyuruServis.Add(new Duyuru
                {
                    Aciklama = duyuruVal,
                    Tarih = DateTime.Now
                });
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DuyuruSil(int id)
        {
            var entity = duyuruServis.GetEntity(c => c.Id == id);
            if (entity!=null)
            {
                duyuruServis.Delete(entity);
            }

            return RedirectToAction("Index");
        }

       
    }
}