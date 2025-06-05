/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 23/4/2025
 * Hora: 20:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of OrdenInicio.
	/// </summary>
	public class OrdenInicio: OrdenEnAula1
	{
		private Aula aula;
		
		public OrdenInicio(Aula aula)
		{
			this.aula = aula;
		}
	
		public void ejecutar()
		{
			this.aula.comenzar();
		}
	}
}
