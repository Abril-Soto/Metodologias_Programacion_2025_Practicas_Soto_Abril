/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 19/4/2025
 * Hora: 16:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of FabricaDeNumeros.
	/// </summary>
	public class FabricaDeNumeros: FabricaDeComparables
	{
		public FabricaDeNumeros()
		{
		}
	
		public override Comparable crearAleatorio()
		{	
			return new Numero(genAleatorio.numeroAleatorio(1000));
		}
	
		public override Comparable crearPorTeclado()
		{
			return new Numero(lector.numeroPorTeclado());
		}
	}
}
