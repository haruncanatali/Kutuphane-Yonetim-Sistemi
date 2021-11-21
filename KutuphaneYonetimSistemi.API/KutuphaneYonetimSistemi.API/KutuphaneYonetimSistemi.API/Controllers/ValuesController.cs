using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.API.DbAccess;
using KutuphaneYonetimSistemi.API.Entities;
using Microsoft.AspNetCore.Routing;

namespace KutuphaneYonetimSistemi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private KitapDbAccess kitapContext;
        private HareketDbAccess hareketContext;
        private CezaDbAccess cezaContext;
        private DuyuruDbAccess duyuruContext;
        private PersonelDbAccess personelContext;

        public ValuesController()
        {
            kitapContext = new KitapDbAccess();
            hareketContext = new HareketDbAccess();
            cezaContext = new CezaDbAccess();
            duyuruContext = new DuyuruDbAccess();
            personelContext = new PersonelDbAccess();
        }

        [HttpPost]
        [Route("kitaplar")]
        public IActionResult Kitaplar()
        {
            return Ok(kitapContext.KitaplariDondur());
        }

        [HttpPost]
        [Route("hareketlerim")]
        public IActionResult Hareketlerim(int id)
        {
            return Ok(hareketContext.HareketleriDondur(id));
        }

        [HttpPost]
        [Route("cezalarim")]
        public IActionResult Cezalarim(int id)
        {
            return Ok(cezaContext.CezalariDondur(id));
        }

        [HttpPost]
        [Route("duyurular")]
        public IActionResult Duyurular()
        {
            return Ok(duyuruContext.DuyurulariDondur());
        }

        [HttpPost]
        [Route("personeller")]
        public IActionResult Personeller()
        {
            return Ok(personelContext.PersonelleriDondur());
        }



    }
}
