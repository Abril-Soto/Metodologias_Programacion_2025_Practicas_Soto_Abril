/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 3/4/2025
 * Hora: 20:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica2
{
	/// <summary>
	/// Description of ComparacionPorNombre.
	/// </summary>
	public class ComparacionPorNombre: EstrategiaDeComparacion
	{
		public ComparacionPorNombre()
		{
		}
		
		public bool SosIgual(Alumno a1, Alumno a2)
		{
			return a1.getNombre() == a2.getNombre();
		}
		
		public bool SosMenor(Alumno a1, Alumno a2)
		{
			return a1.getNombre().CompareTo(a2.getNombre()) < 0; //cuando a1 es menor duvuelve -1
		}
		
		public bool SosMayor(Alumno a1, Alumno a2)
		{
			return a1.getNombre().CompareTo(a2.getNombre()) > 0; //cuando a1 es mayor devuelve 1
		}
	}
}
