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
    //[ApiController]
    public class PropietariosController : Controller
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;

        public PropietariosController(DataContext contexto, IConfiguration config)
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
                var res = contexto.Propietarios.FirstOrDefault(x => x.Email == usuario);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }




        // GET api/<controller>/5
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginView loginView)
        {
            Propietario p = contexto.Propietarios.FirstOrDefault(x => x.Email == loginView.Email);
            if(p != null) { 
            try
            {
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: loginView.Clave,
                    salt: System.Text.Encoding.ASCII.GetBytes("Salt"),
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 1000,
                    numBytesRequested: 256 / 8));
                var us = contexto.Usuarios.FirstOrDefault(x => x.Email == loginView.Email);
                if (us == null || us.Clave != hashed)
                {
                    return BadRequest("Nombre de usuario o clave incorrecta");
                }
                else
                {
                    var key = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(config["TokenAuthentication:SecretKey"]));
                    var credenciales = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, us.Email),
                        new Claim("FullName", us.Nombre + " " + us.Apellido),
                        new Claim(ClaimTypes.Role, "Propietario"),
                    };

                    var token = new JwtSecurityToken(
                        issuer: config["TokenAuthentication:Issuer"],
                        audience: config["TokenAuthentication:Audience"],
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(60),
                        signingCredentials: credenciales
                    );
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            }
            else
            {
                return BadRequest("Este Usuario no es un propietario");

            }
        }

        
        [HttpPost]
        public async Task<IActionResult> Post(Propietario entidad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Propietarios.Add(entidad);
                    contexto.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { id = entidad.IdProp }, entidad);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put( [FromForm] Propietario entidad)
        {
           
            var usuario = User.Identity.Name;
            var res = contexto.Propietarios.AsNoTracking().FirstOrDefault(x => x.Email == usuario);
          
            try
            {
                if (ModelState.IsValid && res != null)
                {
                    entidad.IdProp = res.IdProp;
                    entidad.Email = res.Email;
                    contexto.Entry(entidad).State = EntityState.Modified;
                   // contexto.Propietarios.Update(entidad);
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


        [HttpDelete]
        public void Delete(int id)
        {

        }

    

    }
}
