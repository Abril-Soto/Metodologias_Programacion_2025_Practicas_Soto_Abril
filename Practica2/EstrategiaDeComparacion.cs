/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 3/4/2025
 * Hora: 19:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica2
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	public interface EstrategiaDeComparacion
	{
		bool SosIgual(Alumno a1, Alumno a2);
		
		bool SosMenor(Alumno a1, Alumno a2);
		
		bool SosMayor(Alumno a1, Alumno a2);
	}
}
