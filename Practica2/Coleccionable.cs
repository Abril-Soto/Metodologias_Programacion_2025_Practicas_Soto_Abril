/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 25/3/2025
 * Hora: 15:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica2
{
	/// <summary>
	/// Description of Coleccionable.
	/// </summary>
	public interface Coleccionable: Iterable
	{
		int cuantos();
		
		Comparable minimo();
		
		Comparable maximo();
		
		void agregar(Comparable c);
		
		bool contiene(Comparable c);
	}
}
