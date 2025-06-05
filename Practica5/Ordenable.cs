/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 23/4/2025
 * Hora: 20:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of Ordenablr.
	/// </summary>
	public interface Ordenable
	{
		void setOrdenInicio(OrdenEnAula1 o); 
		
		void setOrdenLlegaAlumno(OrdenEnAula2 o);
		
		void setOrdenAulaLlena(OrdenEnAula1 o);
	}
}
