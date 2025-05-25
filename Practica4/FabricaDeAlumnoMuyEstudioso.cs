/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 7/5/2025
 * Hora: 12:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of FabricaDeAlumnoMuyEstudioso.
	/// </summary>
	public class FabricaDeAlumnoMuyEstudioso: FabricaDeComparables
	{
		public FabricaDeAlumnoMuyEstudioso()
		{
		}
	
		public override Comparable crearAleatorio()
		{	
			return new AlumnoMuyEstudioso(genAleatorio.stringAleatorio(6) ,genAleatorio.numeroAleatorio(40000000), genAleatorio.numeroAleatorio(50000), genAleatorio.numeroAleatorio(10));
		}
	
		public override Comparable crearPorTeclado()
		{
			return new AlumnoMuyEstudioso(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
		}
	}
}
