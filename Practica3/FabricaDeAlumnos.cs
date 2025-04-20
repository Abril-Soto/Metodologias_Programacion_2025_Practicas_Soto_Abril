/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 19/4/2025
 * Hora: 17:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica3
{
	/// <summary>
	/// Ejercicio 5 of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos: FabricaDeComparables
	{
		public FabricaDeAlumnos()
		{
		}
		
		public override Comparable crearAleatorio()
		{	
			return new Alumno(genAleatorio.stringAleatorio(6) ,genAleatorio.numeroAleatorio(40000000), genAleatorio.numeroAleatorio(50000), genAleatorio.numeroAleatorio(10));
		}
	
		public override Comparable crearPorTeclado()
		{
			return new Alumno(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
		}
	
	}
}
