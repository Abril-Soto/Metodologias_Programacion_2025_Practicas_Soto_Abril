/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 20/4/2025
 * Hora: 17:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica3
{
	/// <summary>
	/// ejercicio 9 of FabricaDeProfesor.
	/// </summary>
	public class FabricaDeProfesor: FabricaDeComparables
	{
		public FabricaDeProfesor()
		{
		}
	
		public override Comparable crearAleatorio()
		{
			return new Profesor(genAleatorio.stringAleatorio(6), genAleatorio.numeroAleatorio(45000000), genAleatorio.numeroAleatorio(25));
		}
	
		public override Comparable crearPorTeclado()
		{
			return new Profesor(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
		}
	}
}
