/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 20/4/2025
 * Hora: 15:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of FabricaDePila.
	/// </summary>
	public class FabricaDePila: FabricaDeColeccionables
	{
		public FabricaDePila()
		{
		}
	
		public override Coleccionable crearColeccionable()
		{
			return new Pila();
		}
	
	}
}
