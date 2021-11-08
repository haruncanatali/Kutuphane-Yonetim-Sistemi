using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Ninject;
using KutuphaneYonetimSistemi.Business.Validation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.WebUI.Controllers
{
    public class KitapHareketleriController : Controller
    {
        private IHareketService hareketServis;
        private IUyeService uyeServis;
        private IPersonelService personelServis;
        private IKitapService kitapServis;

        public KitapHareketleriController()
        {
            this.hareketServis = InstanceFactory.GetInstance<IHareketService>();
            this.uyeServis = InstanceFactory.GetInstance<IUyeService>();
            this.personelServis = InstanceFactory.GetInstance<IPersonelService>();
            this.kitapServis = InstanceFactory.GetInstance<IKitapService>();
        }

        public List<SelectListItem> UyeDondur()
        {
            return (from x in uyeServis.GetEntities(null)
                select new SelectListItem
                {
                    Text = x.Ad+" "+x.Soyad+" "+x.Tckn,
                    Value = x.Id.ToString()
                }).OrderBy(c=>c.Text).ToList();
        }

        public List<SelectListItem> PersonelDondur()
        {
            return (from x in personelServis.GetEntities(null) select new SelectListItem
            {
                Text = x.Ad+" "+x.Soyad+" "+x.Tckn,
                Value = x.Id.ToString()
            }).ToList();
        }

        public List<SelectListItem> MusaitKitapDondur()
        {
            return (from x in kitapServis.GetEntities(c=>c.Durum == false) select new SelectListItem
            {
                Text = x.Ad,
                Value = x.Id.ToString()
            }).ToList();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(hareketServis.GetEntities(null));
        }

        [HttpGet]
        public ActionResult Filtrele(string uyeVal)
        {
            return View("Index",
                uyeVal == ""
                    ? hareketServis.GetEntities(null)
                    : hareketServis.GetEntities(c =>
                        (c.Uyesi.Ad + " " + c.Uyesi.Soyad).ToLower().Contains(uyeVal.ToLower())));
        }

        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.kitaplar = MusaitKitapDondur();
            ViewBag.personeller = PersonelDondur();
            ViewBag.uyeler = UyeDondur();
            return View(new Hareket());
        }

        [HttpPost]
        public ActionResult Add(Hareket model)
        {
            try
            {
                model.AlisTarihi = DateTime.Now;
                model.IadeTarihi = DateTime.Now.AddDays(15);

                var validationResult = ValidationTool.Validate(new HareketValidator(), model);

                if (!validationResult.IsValid)
                {
                    foreach (var item in validationResult.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                    }

                    return View(model);
                }
                else
                {
                    var entity = kitapServis.GetEntity(c => c.Id == model.KitapId);
                    entity.Durum = true;
                    kitapServis.Update(entity);
                    hareketServis.Add(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var entity = hareketServis.GetEntity(c => c.Id == id);
            var kitapId = entity.KitapId;
            hareketServis.Delete(entity);
            var entity_ = kitapServis.GetEntity(c => c.Id == kitapId);
            entity_.Durum = false;
            kitapServis.Update(entity_);
            return RedirectToAction("Index");
        }
    }
}