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
    public class YazarController : Controller
    {
        private IYazarService yazarServis;

        public YazarController()
        {
            yazarServis = InstanceFactory.GetInstance<IYazarService>();
        }
        
        public ActionResult Index()
        {
            return View(yazarServis.GetEntities(null));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(new Yazar());
        }

        [HttpPost]
        public ActionResult Add(Yazar model)
        {
            try
            {
                var validationException = ValidationTool.Validate(new YazarValidator(), model);
                if (!validationException.IsValid)
                {
                    foreach (var item in validationException.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName,item.ErrorMessage);   
                    }

                    return View(model);
                }
                else
                {
                    yazarServis.Add(new Yazar
                    {
                        Ad = model.Ad,
                        Soyad = model.Soyad,
                        Detay = model.Detay
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
            return View(yazarServis.GetEntity(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult Update(Yazar model)
        {
            try
            {
                var validationException = ValidationTool.Validate(new YazarValidator(), model);
                if (!validationException.IsValid)
                {
                    foreach (var item in validationException.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                    }

                    return View(model);
                }
                else
                {
                    yazarServis.Update(model);
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
            var entity = yazarServis.GetEntity(c => c.Id == id);
            yazarServis.Delete(entity);
            return RedirectToAction("Index");
        }


    }
}