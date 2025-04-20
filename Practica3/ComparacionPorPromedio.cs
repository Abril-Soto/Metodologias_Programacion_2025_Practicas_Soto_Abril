/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 3/4/2025
 * Hora: 20:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica3
{
	/// <summary>
	/// Description of ComparacionPorPromedio.
	/// </summary>
	public class ComparacionPorPromedio: EstrategiaDeComparacion
	{
		public ComparacionPorPromedio()
		{
		}
	
		public bool sosIgual(Alumno a1, Alumno a2)
		{
			return a1.getPromedio() == a2.getPromedio();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2)
		{
			return a1.getPromedio() < a2.getPromedio();
		}
		
		public bool sosMayor(Alumno a1, Alumno a2)
		{
			return a1.getPromedio() > a2.getPromedio();
		}
	}
}
