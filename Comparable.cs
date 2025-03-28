/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 25/3/2025
 * Hora: 14:54
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica1
{
	/// <summary>
	/// ejercicio 1.
	/// </summary>
	public interface Comparable
	{
		bool sosIgual(Comparable c);
		
		bool sosMenor(Comparable c);
		
		bool sosMayor(Comparable c);
	}
}
