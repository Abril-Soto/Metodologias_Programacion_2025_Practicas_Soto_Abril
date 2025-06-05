/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 23/4/2025
 * Hora: 20:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of OrdenLlegaAlumno.
	/// </summary>
	public class OrdenLlegaAlumno: OrdenEnAula2
	{
		private Aula aula;
		
		public OrdenLlegaAlumno(Aula aula)
		{
			this.aula = aula;
		}
	
		public void ejecutar(Comparable c)
		{
			this.aula.nuevoAlumno((IAlumno)c);
		}
	}
}
