/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 20/4/2025
 * Hora: 15:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of FabricaDeConjunto.
	/// </summary>
	public class FabricaDeConjunto: FabricaDeColeccionables
	{
		public FabricaDeConjunto()
		{
		}
	
		public override Coleccionable crearColeccionable()
		{
			return new Conjunto();
		}
	
	}
}
