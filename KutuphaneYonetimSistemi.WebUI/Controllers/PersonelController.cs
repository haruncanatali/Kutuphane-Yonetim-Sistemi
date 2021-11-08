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
    public class PersonelController : Controller
    {
        private IPersonelService personelServis;

        public PersonelController()
        {
            personelServis = InstanceFactory.GetInstance<IPersonelService>();
        }

        public ActionResult Index()
        {
            return View(personelServis.GetEntities(null));
        }

        [HttpGet]
        public ActionResult Filtrele(string per)
        {
            return View("Index",per=="" ? personelServis.GetEntities(null) : personelServis.GetEntities(c => (c.Ad + " " + c.Soyad).ToLower().Contains(per.ToLower())));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(new Personel());
        }

        [HttpPost]
        public ActionResult Add(Personel model)
        {
            try
            {
                var validationResult = ValidationTool.Validate(new PersonelValidator(), model);
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
                    personelServis.Add(model);
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
            return View(personelServis.GetEntity(c=>c.Id == id));
        }

        [HttpPost]
        public ActionResult Update(Personel model)
        {
            try
            {
                var validationResult = ValidationTool.Validate(new PersonelValidator(), model);
                if (!validationResult.IsValid)
                {
                    foreach (var item in validationResult.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }

                    return View(model);
                }
                else
                {
                    personelServis.Update(model);
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
            var entity = personelServis.GetEntity(c => c.Id == id);
            personelServis.Delete(entity);
            return RedirectToAction("Index");
        }
    }
}