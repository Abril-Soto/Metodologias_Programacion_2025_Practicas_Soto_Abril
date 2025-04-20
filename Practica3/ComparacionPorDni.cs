/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 3/4/2025
 * Hora: 20:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica3
{
	/// <summary>
	/// Description of ComparacionPorDni.
	/// </summary>
	public class ComparacionPorDni: EstrategiaDeComparacion
	{
		public ComparacionPorDni()
		{
		}
		
		public bool sosIgual(Alumno a1, Alumno a2)
		{
			return a1.getDni() == a2.getDni();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2)
		{
			return a1.getDni() < a2.getDni();
		}
		
		public bool sosMayor(Alumno a1, Alumno a2)
		{
			return a1.getDni() > a2.getDni();
		}
	
	}
}
