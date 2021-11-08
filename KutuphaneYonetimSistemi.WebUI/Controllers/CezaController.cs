using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Antlr.Runtime;
using KutuphaneYonetimSistemi.Business.Abstract;
using KutuphaneYonetimSistemi.Business.Ninject;
using KutuphaneYonetimSistemi.Business.Validation;
using KutuphaneYonetimSistemi.Entities.Concrete;

namespace KutuphaneYonetimSistemi.WebUI.Controllers
{
    public class CezaController : Controller
    {
        private ICezaService cezaServis;
        private IHareketService hareketServis;
        private IKasaService kasaServis;

        public CezaController()
        {
            cezaServis = InstanceFactory.GetInstance<ICezaService>();
            hareketServis = InstanceFactory.GetInstance<IHareketService>();
            kasaServis = InstanceFactory.GetInstance<IKasaService>();
        }

        private void MsgBox(string sMessage)
        {
            Response.Write("<script>alert('" + sMessage + "')</script>");
        }

        public ActionResult Index()
        {
            return View(cezaServis.GetEntities(null));
        }

        [HttpGet]
        public ActionResult Filtrele(string hareketId)
        {
            return View("Index",
                hareketId == "" ? cezaServis.GetEntities(null) : cezaServis.GetEntities(c => c.HareketId == int.Parse(hareketId)));
        }

        [HttpGet]
        public ActionResult Add(string hareketId)
        {
            try
            {
                int id = int.Parse(hareketId);
                var result = hareketServis.GetEntity(c => c.Id == id);
                if (result == null)
                {
                    MsgBox("Hareket ID Bulunamadı!");
                    return RedirectToAction("Index");
                }
                else
                {
                    cezaServis.Add(new Ceza
                    {
                        BaslangicTarihi = DateTime.Now,
                        BitisTarihi = DateTime.Now.AddDays(15),
                        HareketId = result.Id,
                        UyeId = result.UyeId,
                        Para = 25.00m,
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
        public ActionResult Arttır(string id)
        {
            int id_ = int.Parse(id);
            var entity = cezaServis.GetEntity(c => c.Id == id_);
            entity.Para += 25.00m;
            cezaServis.Update(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            int id_ = int.Parse(id);
            var entity = cezaServis.GetEntity(c => c.Id == id_);

            string ay = Indexleme(DateTime.Now.Month.ToString());
            string yil = DateTime.Now.Year.ToString();

            var kasaEntity = kasaServis.GetEntity(c => c.Ay == ay && c.Yil == yil);
            decimal tutar = entity.Para;
            kasaEntity.Tutar += tutar;
            kasaServis.Update(kasaEntity);

            cezaServis.Delete(entity);

            return RedirectToAction("Index");
        }

        public string Indexleme(string ay)
        {
            string message = String.Empty;
            switch (ay)
            {
                case "1":
                    message += "Ocak";
                    break;
                case "2":
                    message += "Şubat";
                    break;
                case "3":
                    message += "Mart";
                    break;
                case "4":
                    message += "Nisan";
                    break;
                case "5":
                    message += "Mayıs";
                    break;
                case "6":
                    message += "Haziran";
                    break;
                case "7":
                    message += "Temmuz";
                    break;
                case "8":
                    message += "Ağustos";
                    break;
                case "9":
                    message += "Eylül";
                    break;
                case "10":
                    message += "Ekim";
                    break;
                case "11":
                    message += "Kasım";
                    break;
                case "12":
                    message += "Aralık";
                    break;
            }

            return message;
        }
    }
}