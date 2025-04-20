/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 20/4/2025
 * Hora: 15:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica3
{
	/// <summary>
	/// Description of FabricaDeCola.
	/// </summary>
	public class FabricaDeCola: FabricaDeColeccionables
	{
		public FabricaDeCola()
		{
		}
	
		public override Coleccionable crearColeccionable()
		{
			return new Cola();
		}
	
	}
}
