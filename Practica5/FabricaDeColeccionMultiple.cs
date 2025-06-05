/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 20/4/2025
 * Hora: 15:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of FabricaDeColeccionMultiple.
	/// </summary>
	public class FabricaDeColeccionMultiple: FabricaDeColeccionables
	{
		public FabricaDeColeccionMultiple()
		{
		}
	
		public override Coleccionable crearColeccionable()
		{
			return new ColeccionMultiple();
		}
	}
}
