using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
	interface IRepositorioPago : IRepositorio<Pago>
	{
		
		IList<Pago> ObtenerPorContr(int id);
	}
}
