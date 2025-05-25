/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 14/4/2025
 * Hora: 17:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();
	}
}
