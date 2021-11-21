using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KutuphaneYonetimSistemi.API.DbAccess;
using KutuphaneYonetimSistemi.API.Entities;
using KutuphaneYonetimSistemi.API.Model;

namespace KutuphaneYonetimSistemi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UyeDbAccess uyeContext = null;

        public AccountController()
        {
            uyeContext = new UyeDbAccess();
        }

        [HttpPost]
        [Route("uye")]
        public IActionResult GetUser(int id)
        {
            var entity = uyeContext.UyeDondur(id);
            if (entity!=null)
            {
                return Ok(entity);
            }
            return BadRequest(new string[] { "basarisiz" });
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginDto model)
        {
            var entity = uyeContext.Login(model);
            if (entity != null)
            {
                return Ok(entity);
            }
            return BadRequest(new string[] { });
        }

        [HttpGet]
        [Route("uyeler")]
        public IActionResult UyeleriDondur()
        {
            return Ok(uyeContext.UyeleriDondur());
        }

        [HttpPost]
        [Route("delete")]
        public IActionResult UyeSil(int id)
        {
            if (uyeContext.Delete(id))
            {
                return Ok(new string[] { "basarili" });
            }
            return BadRequest(new string[] { });
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update([FromBody] Uye model)
        {
            if (uyeContext.Update(model))
            {
                return Ok(new string[] { "basarili" });
            }
            return BadRequest(new string[] { });
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] RegisterDto model)
        {
            return Ok(uyeContext.Register(model));
        }
    }
}
