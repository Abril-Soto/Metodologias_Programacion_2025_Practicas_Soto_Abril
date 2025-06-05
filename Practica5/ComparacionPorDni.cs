/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 3/4/2025
 * Hora: 20:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of ComparacionPorDni.
	/// </summary>
	public class ComparacionPorDni: EstrategiaDeComparacion
	{
		public ComparacionPorDni()
		{
		}
		
		public bool sosIgual(IAlumno a1, IAlumno a2)
		{
			return a1.getDni() == a2.getDni();
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2)
		{
			return a1.getDni() < a2.getDni();
		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2)
		{
			return a1.getDni() > a2.getDni();
		}
	
	}
}
