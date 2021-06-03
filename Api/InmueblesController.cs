using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProyectoInmobiliaria.Models;

namespace ProyectoInmobiliaria.Api
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class InmueblesController : Controller
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;

        public InmueblesController(DataContext contexto, IConfiguration config)
        {
            this.contexto = contexto;
            this.config = config;
        }

        // GET: api/Inmuebles
        [HttpGet("todos")]
        public IEnumerable<Inmueble> GetTodos()
        {
          
            return contexto.Inmuebles.Include(e => e.Propietario);
           
        }

         [HttpGet]
        public async Task<ActionResult<IEnumerable<Inmueble>>> Get()
        {
              try
              {
                  var usuario = User.Identity.Name;
                  var inmueble = contexto.Inmuebles.Include(e => e.Propietario).Where(e => e.Propietario.Email == usuario);

                  return Ok(inmueble);
              }
              catch (Exception ex)
              {
                  return BadRequest(ex);
              }
          }
        // GET: api/Inmuebles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var usuario = User.Identity.Name;
               Inmueble inm = contexto.Inmuebles.Find(id);

                return Ok(inm);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public async Task<IActionResult> Post(Inmueble inm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    inm.IdProp = contexto.Propietarios.Single(e => e.Email == User.Identity.Name).IdProp;
                    contexto.Inmuebles.Add(inm);
                    contexto.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { id = inm.IdInm }, inm);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }



        // PUT: api/Inmuebles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Inmueble inmueble)
        {
            var inm = contexto.Inmuebles.AsNoTracking().Include(e => e.Propietario).FirstOrDefault(e => e.IdInm == id && e.Propietario.Email == User.Identity.Name);

            try
            {
                if (ModelState.IsValid && inm != null)
                {
                    inmueble.IdInm = inm.IdInm;
                    inmueble.IdProp = inm.IdProp;
                    inmueble.Disponible = inm.Disponible;
                    contexto.Entry(inmueble).State = EntityState.Modified;
                    await contexto.SaveChangesAsync();
                    return Ok(inmueble);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("disponible/{id}")]
        public async Task<IActionResult> Disponibilidad(int id,[FromForm]Inmueble inmueble)
        {

            var inm = contexto.Inmuebles.AsNoTracking().Include(e => e.Propietario).FirstOrDefault(e => e.IdInm == id && e.Propietario.Email == User.Identity.Name);

            try
            {
                if (ModelState.IsValid && inm != null)
                {
                    inmueble.IdInm = inm.IdInm;
                    inmueble.IdProp = inm.IdProp;
                    inmueble.Direccion = inm.Direccion;
                    inmueble.Tipo = inm.Tipo;
                    inmueble.Uso = inm.Uso;
                    inmueble.CantAmbientes = inm.CantAmbientes;
                    inmueble.Costo = inm.Costo;
                    if (inm.Disponible)
                    {
                        inmueble.Disponible = false;
                    }
                    else
                    {
                        inmueble.Disponible = true;
                    }
                    contexto.Entry(inmueble).State = EntityState.Modified;
                    await contexto.SaveChangesAsync();
                    return Ok(inmueble);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        
    }
        // POST: api/Inmuebles
        [HttpPost("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var entidad = contexto.Inmuebles.Include(e => e.Propietario).FirstOrDefault(e => e.IdInm == id && e.Propietario.Email == User.Identity.Name);
                if (entidad != null)
                {
                    contexto.Inmuebles.Remove(entidad);
                    contexto.SaveChanges();
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        // DELETE: api/Inmuebles/5
        [HttpDelete("BajaLogica/{id}")]
        public async Task<IActionResult> BajaLogica(int id)
        {
            try
            {
                var entidad = contexto.Inmuebles.Include(e => e.Propietario).FirstOrDefault(e => e.IdInm == id && e.Propietario.Email == User.Identity.Name);
                if (entidad != null)
                {
                    entidad.Disponible = false;//cambiar por estado = 0
                    contexto.Inmuebles.Update(entidad);
                    contexto.SaveChanges();
                    return Ok();
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