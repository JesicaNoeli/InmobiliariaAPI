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
    public class PagosController : Controller
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;

        public PagosController(DataContext contexto, IConfiguration config)
        {
            this.contexto = contexto;
            this.config = config;
        }

        // GET: api/Pagos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pago>>> GetPago()
        {
            try
            {
                var pago = await contexto.Pagos
                .Include(pagos => pagos.Contrato)
                .Include(pagos => pagos.Contrato.Inmueble)
                .Where(pagos =>  pagos.Contrato.Inmueble.Propietario.Email == User.Identity.Name && pagos.Contrato.FechaInicio <= DateTime.Now && pagos.Contrato.FechaCierre >= DateTime.Now)
                .ToListAsync();
                if (pago == null)
                {
                    return NotFound("No se registraron pagos");
                }

                return Ok(pago);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET: api/Pagoes
        [HttpGet("Inmueble/{id}")]
        public async Task<ActionResult<IEnumerable<Contrato>>> GetPagosPorInmueble(int id)
        {
            try
            {
                var pago = await contexto.Pagos
                .Include(pagos => pagos.Contrato)
                .Include(pagos => pagos.Contrato.Inmueble)
                .Include(pagos => pagos.Contrato.Inmueble.Propietario)
                .Include(pagos => pagos.Contrato.Inquilino)
                .Where(pagos => pagos.Contrato.IdInm == id && pagos.Contrato.Inmueble.Propietario.Email == User.Identity.Name && pagos.Contrato.FechaInicio <= DateTime.Now && pagos.Contrato.FechaCierre >= DateTime.Now)
                .ToListAsync();
                if (pago == null)
                {
                    return NotFound("No se registrarono pagos");
                }

                return Ok(pago);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT: api/Pagoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPago(int id, Pago pago)
        {
            if (id != pago.IdPago)
            {
                return BadRequest();
            }

            contexto.Entry(pago).State = EntityState.Modified;

            try
            {
                await contexto.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PagoExists(id))
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

        // POST: api/Pagoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pago>> PostPago(Pago pago)
        {
            contexto.Pagos.Add(pago);
            await contexto.SaveChangesAsync();

            return CreatedAtAction("GetPago", new { id = pago.IdPago }, pago);
        }

        // DELETE: api/Pagoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pago>> DeletePago(int id)
        {
            var pago = await contexto.Pagos.FindAsync(id);
            if (pago == null)
            {
                return NotFound();
            }

            contexto.Pagos.Remove(pago);
            await contexto.SaveChangesAsync();

            return pago;
        }

        private bool PagoExists(int id)
        {
            return contexto.Pagos.Any(e => e.IdPago == id);
        }
    }
}
