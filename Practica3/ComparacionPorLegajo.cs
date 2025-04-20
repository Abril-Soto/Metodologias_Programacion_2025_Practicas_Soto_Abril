/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 3/4/2025
 * Hora: 20:05
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica3
{
	/// <summary>
	/// Description of ComparacionPorLegajo.
	/// </summary>
	public class ComparacionPorLegajo: EstrategiaDeComparacion
	{
		public ComparacionPorLegajo()
		{
		}
		
		public bool sosIgual(Alumno a1, Alumno a2)
		{
			return a1.getLegajo() == a2.getLegajo();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2)
		{
			return a1.getLegajo() < a2.getLegajo();
		}
		
		public bool sosMayor(Alumno a1, Alumno a2)
		{
			return a1.getLegajo() > a2.getLegajo();
		}
	}
}
