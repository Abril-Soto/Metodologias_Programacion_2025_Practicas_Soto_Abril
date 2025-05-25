/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 12/5/2025
 * Hora: 13:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of ComparacionPorCalificacion.
	/// </summary>
	public class ComparacionPorCalificacion: EstrategiaDeComparacion
	{
		public ComparacionPorCalificacion()
		{
		}
	
		public bool sosIgual(IAlumno a1, IAlumno a2)
		{
			return a1.getCalificacion() == a2.getCalificacion();
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2)
		{
			return a1.getCalificacion() < a2.getCalificacion();
		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2)
		{
			return a1.getCalificacion() > a2.getCalificacion();
		}
	
	}
}
