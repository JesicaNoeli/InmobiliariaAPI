using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ProyectoInmobiliaria.Models;

namespace ProyectoInmobiliaria.Api
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
   // [ApiController]
    public class UsuariosController : Controller
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;

        public UsuariosController(DataContext contexto, IConfiguration config)
        {
            this.contexto = contexto;
            this.config = config;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {

                var usuario = User.Identity.Name;
                var res = contexto.Usuarios.FirstOrDefault(x => x.Email == usuario);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
       

        [HttpPut/*("{id}")*/]
        public async Task<IActionResult> Put(/*int id,*/ [FromForm] Usuario entidad)
        {
            //var us = contexto.Usuarios.AsNoTracking().FirstOrDefault(e => e.IdUs == id);

            var usuario = User.Identity.Name;
            var res = contexto.Usuarios.AsNoTracking().FirstOrDefault(x => x.Email == usuario);

            try
            {
                if (ModelState.IsValid && res != null)
                {
                    entidad.IdUs = res.IdUs;
                    entidad.Rol = res.Rol;
                    if (entidad.Clave == null)
                    {
                        entidad.Clave = res.Clave;
                    }
                   else if (entidad.Clave != res.Clave) { 
                   entidad.Clave = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                   password: entidad.Clave,
                   salt: System.Text.Encoding.ASCII.GetBytes("Salt"),
                   prf: KeyDerivationPrf.HMACSHA1,
                   iterationCount: 1000,
                   numBytesRequested: 256 / 8));
                    }
                   
                    contexto.Entry(entidad).State = EntityState.Modified;
                   //contexto.Usuarios.Update(entidad);
                    await contexto.SaveChangesAsync();
                    return Ok(entidad);
                }
               
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


    }
}
