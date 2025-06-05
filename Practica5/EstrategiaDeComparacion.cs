/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 3/4/2025
 * Hora: 19:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	public interface EstrategiaDeComparacion
	{
		bool sosIgual(IAlumno a1, IAlumno a2);
		
		bool sosMenor(IAlumno a1,IAlumno a2);
		
		bool sosMayor(IAlumno a1, IAlumno a2);
	}
}
