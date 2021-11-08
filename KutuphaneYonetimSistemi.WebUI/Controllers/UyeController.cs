using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Ninject;
using KutuphaneYonetimSistemi.Business.Validation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.WebUI.Controllers
{
    public class UyeController : Controller
    {
        private IUyeService uyeServis;

        public UyeController()
        {
            uyeServis = InstanceFactory.GetInstance<IUyeService>();
        }

        public ActionResult Index()
        {
            return View(uyeServis.GetEntities(null));
        }

        [HttpGet]
        public ActionResult Filtrele(string uyeVal)
        {
            return View("Index",uyeVal == "" ? uyeServis.GetEntities(null) : uyeServis.GetEntities(c => (c.Ad + " " + c.Soyad).ToLower().Contains(uyeVal.ToLower())));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(new Uye());
        }

        [HttpPost]
        public ActionResult Add(Uye model, HttpPostedFileBase uyeFoto)
        {
            try
            {
                if (uyeFoto == null || uyeFoto.ContentLength < 1 || uyeFoto.FileName == null)
                {
                    ModelState.AddModelError("Fotograf", "Fotoğraf girilmedi.");
                    return View(model);
                }

                model.Fotograf = uyeFoto.FileName;
                var validationResult = ValidationTool.Validate(new UyeValidator(), model);
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
                    uyeFoto.SaveAs(Server.MapPath("~/Content/Img/" + uyeFoto.FileName));
                    uyeServis.Add(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(uyeServis.GetEntity(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult Update(Uye model,HttpPostedFileBase uyeFoto)
        {
            bool state = false;
            string oldState = "";
            try
            {
                if (uyeFoto!=null && model.Fotograf!=null)
                {
                    if ((uyeFoto.FileName != model.Fotograf) && uyeFoto.FileName!=null)
                    {
                        if ((uyeFoto == null || uyeFoto.ContentLength < 1 || uyeFoto.FileName == null))
                        {
                            ModelState.AddModelError("Fotograf", "Fotoğraf girilmedi.");
                            return View(model);
                        }

                        state = true;
                        oldState = model.Fotograf;
                        model.Fotograf = uyeFoto.FileName;
                    }
                }
                
                var validationResult = ValidationTool.Validate(new UyeValidator(), model);
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
                    if (state)
                    {
                        uyeFoto.SaveAs(Server.MapPath("~/Content/Img/" + uyeFoto.FileName));
                        string path = Server.MapPath("~/Content/Img/") + oldState;
                        FileInfo file = new FileInfo(path);
                        file.Delete();
                    }
                    uyeServis.Update(model);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var entity = uyeServis.GetEntity(c => c.Id == id);
            string oldState = entity.Fotograf;
            uyeServis.Delete(entity);
            string path = Server.MapPath("~/Content/Img/") + oldState;
            FileInfo file = new FileInfo(path);
            file.Delete();
            return RedirectToAction("Index");
        }
    }
}