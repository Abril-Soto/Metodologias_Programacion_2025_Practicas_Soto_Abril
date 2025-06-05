/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 9/4/2025
 * Hora: 20:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{	
		protected GeneradorDeDatosAleatorios genAleatorio = new GeneradorDeDatosAleatorios();
		
		protected LectorDeDatos lector = new LectorDeDatos();
		
		public static Comparable crearAleatorio(int opcion)
		{
			FabricaDeComparables fabrica = null;
			
			switch (opcion) 
			{ 
				case 1: fabrica = new FabricaDeNumeros(); break;
					
				case 2: fabrica = new FabricaDeAlumnos(); break;
				
				case 3: fabrica = new FabricaDeProfesor(); break;
				
				case 4: fabrica = new FabricaDeAlumnoMuyEstudioso(); break;
				
			}
			
			return fabrica.crearAleatorio();
		}
	
		public abstract Comparable crearAleatorio();
			
		public static Comparable crearPorTeclado(int opcion)
		{
			FabricaDeComparables fabrica = null;
			
			switch (opcion) 
			{
				case 1: fabrica = new FabricaDeNumeros(); break;
					
				case 2: fabrica = new FabricaDeAlumnos(); break;
			}
			
			return fabrica.crearPorTeclado();
		}
	
		public abstract Comparable crearPorTeclado();
		
	}
}
