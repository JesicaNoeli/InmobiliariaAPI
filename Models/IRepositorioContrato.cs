using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoInmobiliaria.Models
{
	interface IRepositorioContrato : IRepositorio<Contrato>
	{

		IList<Contrato> VigentesPorFecha(DateTime f);
		IList<Contrato> ObtenerTodosPorInm(int id);
		Contrato ObtenerPorInm(int id);
	}
    
}
