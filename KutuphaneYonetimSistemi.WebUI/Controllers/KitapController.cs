using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Ninject;
using KutuphaneYonetimSistemi.Business.Validation;
using KutuphaneYonetimSistemi.Entities.Concrete;
using Microsoft.Ajax.Utilities;

namespace KutuphaneYonetimSistemi.WebUI.Controllers
{
    public class KitapController : Controller
    {
        private IKategoriService kategoriServis;
        private IYazarService yazarServis;
        private IKitapService kitapServis;

        public KitapController()
        {
            kategoriServis = InstanceFactory.GetInstance<IKategoriService>();
            yazarServis = InstanceFactory.GetInstance<IYazarService>();
            kitapServis = InstanceFactory.GetInstance<IKitapService>();
        }

        public List<SelectListItem> KategorileriDondur()
        {
            return (from x in kategoriServis.GetEntities(null)
                select new SelectListItem
                {
                    Text = x.Ad,
                    Value = x.Id.ToString()
                }).ToList();
        }

        public List<SelectListItem> YazarlariDondur()
        {
            return (from x in yazarServis.GetEntities(null) select new SelectListItem
            {
                Text = x.Ad+" "+x.Soyad,
                Value = x.Id.ToString()
            }).ToList();
        }

        public ActionResult Index()
        {
            return View(kitapServis.GetEntities(null));
        }

        [HttpGet]
        public ActionResult Filtrele(string kitapAdi)
        {
            var kitaplar = kitapServis.GetEntities(c => c.Ad.ToLower().Contains(kitapAdi.ToLower()));
            return View("Index", kitaplar);
        }

        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.kategoriler = KategorileriDondur();
            ViewBag.yazarlar = YazarlariDondur();
            return View(new Kitap());
        }

        [HttpPost]
        public ActionResult Add(Kitap model)
        {
            try
            {
                var validationResult = ValidationTool.Validate(new KitapValidator(), model);
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
                    kitapServis.Add(new Kitap
                    {
                        Ad = model.Ad,
                        BasimYili = model.BasimYili,
                        Durum = false,
                        SayfaSayisi = model.SayfaSayisi,
                        KategoriId = model.KategoriId,
                        YazarId = model.YazarId,
                        YayinEvi = model.YayinEvi,
                    });
                    return RedirectToAction("Index");
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            ViewBag.kategoriler = KategorileriDondur();
            ViewBag.yazarlar = YazarlariDondur();
            return View(kitapServis.GetEntity(c=>c.Id == id));
        }

        [HttpPost]
        public ActionResult Update(Kitap model)
        {
            try
            {
                var validationResult = ValidationTool.Validate(new KitapValidator(), model);
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
                    kitapServis.Update(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var entity = kitapServis.GetEntity(c => c.Id == id);
            kitapServis.Delete(entity);
            return RedirectToAction("Index");
        }

    }
}