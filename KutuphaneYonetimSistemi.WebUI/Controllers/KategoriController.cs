using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Ninject;
using KutuphaneYonetimSistemi.Business.Validation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.WebUI.Controllers
{
    public class KategoriController : Controller
    {
        private IKategoriService kategoriServis;

        public KategoriController()
        {
            kategoriServis = InstanceFactory.GetInstance<IKategoriService>();
        }

        public ActionResult Index()
        {
            return View(kategoriServis.GetEntities(null));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(new Kategori());
        }

        [HttpPost]
        public ActionResult Add(Kategori model)
        {
            try
            {
                var validationResult = ValidationTool.Validate(new KategoriValidator(), model);
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
                    kategoriServis.Add(new Kategori
                    {
                        Ad = model.Ad
                    });
                    return Redirect("Index");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(kategoriServis.GetEntity(c=>c.Id == id));
        }

        [HttpPost]
        public ActionResult Update(Kategori model)
        {
            try
            {
                var validationResult = ValidationTool.Validate(new KategoriValidator(), model);
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
                    kategoriServis.Update(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return Redirect("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var entity = kategoriServis.GetEntity(c => c.Id == id);
            kategoriServis.Delete(entity);
            return RedirectToAction("Index");
        }
    }
}