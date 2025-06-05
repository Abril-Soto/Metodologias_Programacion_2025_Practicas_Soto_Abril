/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 19/4/2025
 * Hora: 19:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of FabricaDeColeccionables.
	/// </summary>
	public abstract class FabricaDeColeccionables
	{
		public static Coleccionable crearColeccionable(int opcion)
		{
			FabricaDeColeccionables fabrica = null;
			
			switch (opcion) 
			{
					case 1: fabrica = new FabricaDePila(); break;
					
					case 2: fabrica = new FabricaDeCola(); break;
					
					case 3: fabrica = new FabricaDeColeccionMultiple(); break;
					
					case 4: fabrica = new FabricaDeConjunto(); break;
			}
		
			return fabrica.crearColeccionable();
		}
	
		public abstract Coleccionable crearColeccionable();
	}
}
