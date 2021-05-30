using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProyectoInmobiliaria.Models;

namespace ProyectoInmobiliaria.Api
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class InquilinosController : Controller
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;

        public InquilinosController(DataContext contexto, IConfiguration config)
        {
            this.contexto = contexto;
            this.config = config;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inquilino>>> Get()
        {

            try
            {
                var inquilinos = await contexto.Contratos
                    .Include(contrato => contrato.Inmueble)
                    .ThenInclude(inmueble => inmueble.Propietario)
                    .Include(contrato => contrato.Inquilino)
                    .Where(contrato => contrato.Inmueble.Propietario.Email == User.Identity.Name)
                    .Select(contrato => contrato.Inquilino)
                    .ToListAsync();

                if (inquilinos == null)
                {
                    return NotFound("No existen inquilinos");
                }

                return Ok(inquilinos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        // GET: api/Inquilino
     
        // GET: api/Inquilino/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inquilino>> Get(int id)
        {
            var inquilino = await contexto.Inquilinos.FindAsync(id);

            if (inquilino == null)
            {
                return NotFound();
            }

            return inquilino;
        }

       
        [HttpPost]
        public async Task<ActionResult<Inquilino>> Post(Inquilino inquilino)
        {
            contexto.Inquilinos.Add(inquilino);
            await contexto.SaveChangesAsync();

            return CreatedAtAction("GetInquilino", new { id = inquilino.IdInq }, inquilino);
        }

        // DELETE: api/Inquilino/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Inquilino>> Delete(int id)
        {
            var inquilino = await contexto.Inquilinos.FindAsync(id);
            if (inquilino == null)
            {
                return NotFound();
            }

            contexto.Inquilinos.Remove(inquilino);
            await contexto.SaveChangesAsync();

            return inquilino;
        }

        private bool InquilinoExists(int id)
        {
            return contexto.Inquilinos.Any(e => e.IdInq == id);
        }
    }
}
   

