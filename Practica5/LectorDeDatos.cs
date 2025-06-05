/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 9/4/2025
 * Hora: 18:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
	
		public int numeroPorTeclado()
		{
			Console.WriteLine("Ingrese un numero entero: ");
			
			return int.Parse(Console.ReadLine());
		}
	
		public string stringPorTeclado()
		{
			Console.WriteLine("Ingrese un string: ");
			
			return Console.ReadLine();
		}
	
	}
}
