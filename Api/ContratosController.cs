using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using ProyectoInmobiliaria.Models;

namespace ProyectoInmobiliaria.Api
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class ContratosController : Controller
    {
        private readonly DataContext contexto;

        public ContratosController(DataContext context)
        {
            contexto = context;
        }


        // GET: api/Contrato
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contrato>>> GetContrato()
        {
            return contexto.Contratos;
        }


        // GET: api/Contrato/5
        [HttpGet("Vigente/{id}")]
        public async Task<ActionResult<IEnumerable<Contrato>>> GetContratoVigente(int id)
        {
            try
            {

                //var contrato = await contexto.Contratos
                var usuario = User.Identity.Name;
                var contrato = contexto.Contratos
                .Include(cont => cont.Inmueble)
                .Include(cont => cont.Inquilino)
                .Include(cont => cont.Inmueble.Propietario)
                .Where(cont => cont.IdInm == id && cont.FechaInicio <= DateTime.Now && cont.FechaCierre >= DateTime.Now && cont.Inmueble.Propietario.Email == usuario);
                //.FirstOrDefaultAsync();
                if (contrato == null )
                {
                    return NotFound("No existen contratos vigentes");
                }

                return Ok(contrato);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("Vigente")]
        public async Task<ActionResult<IEnumerable<Contrato>>> GetContratosVigente()
        {
            try
            {
                var usuario = User.Identity.Name;
                var contrato = contexto.Contratos
                .Include(cont => cont.Inmueble)
                .Include(cont => cont.Inquilino)
                .Include(cont => cont.Inmueble.Propietario)
                .Where(cont => cont.FechaInicio <= DateTime.Now && cont.FechaCierre >= DateTime.Now && cont.Inmueble.Propietario.Email == usuario);
                //.FirstOrDefaultAsync();
                if (contrato == null)
                {
                    return NotFound("No existen contratos vigentes");
                }

                return Ok(contrato);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("inmueble/{id}")]
        public async Task<ActionResult<IEnumerable<Contrato>>> GetTodosPorInmueble(int id)
        {
            try
            {
                var contrato = await contexto.Contratos
                .Include(cont => cont.Inmueble)
                .Include(cont => cont.Inquilino)
                .Include(cont => cont.Inmueble.Propietario)
                .Where(cont => cont.IdInm == id  && cont.Inmueble.Propietario.Email == User.Identity.Name)
                .FirstOrDefaultAsync();
                if (contrato.FechaCierre < DateTime.Now)
                {
                    contrato.Vigente = false;
                }
                else if (contrato == null || contrato.Inmueble.Propietario.Email != User.Identity.Name)
                {
                    return NotFound("No existen contratos vigentes");
                }

                return Ok(contrato);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        // POST: api/Contrato
        [HttpGet("{id}")]
        public async Task<ActionResult<Contrato>> Get(int id)
        {
            var contrato = await contexto.Contratos.FindAsync(id);

            if (contrato == null)
            {
                return NotFound();
            }

            return contrato;
        }


        // PUT: api/Contrato/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Contrato contrato)
        {
            if (id != contrato.IdContr)
            {
                return BadRequest();
            }

            contexto.Entry(contrato).State = EntityState.Modified;

            try
            {
                await contexto.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (contexto.Contratos.FirstOrDefault(e => e.IdContr == id)==null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Contrato>> Post(Contrato contrato)
        {
            contexto.Contratos.Add(contrato);
            await contexto.SaveChangesAsync();

            return CreatedAtAction("GetContrato", new { id = contrato.IdContr }, contrato);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Contrato>> Delete(int id)
        {
            var contrato = await contexto.Contratos.FindAsync(id);
            if (contrato == null)
            {
                return NotFound();
            }

            contexto.Contratos.Remove(contrato);
            await contexto.SaveChangesAsync();

            return contrato;
        }

      
    }
}

