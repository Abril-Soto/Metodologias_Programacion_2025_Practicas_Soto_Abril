/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 23/4/2025
 * Hora: 20:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of OrdenAulaLlena.
	/// </summary>
	public class OrdenAulaLlena: OrdenEnAula1
	{
		private Aula aula;
		
		public OrdenAulaLlena(Aula aula)
		{
			this.aula = aula;
		}
	
		public void ejecutar()
		{
			this.aula.claseLista();
		}
	}
}
