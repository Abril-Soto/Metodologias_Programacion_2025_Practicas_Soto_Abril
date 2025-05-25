/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 7/5/2025
 * Hora: 13:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of FabricaDeStudents. //ejercicio opcional
	/// </summary>
	/// 

	public abstract class StudentsFactory
	{
		public static Student crearAleatorio(int opcion)
		{
			StudentsFactory fabrica = null;
			
			switch (opcion) 
			{
					case 1: fabrica = new FabricadeAlumnoAdapter(); break;
					
					case 2: fabrica = new FabricaAlumnoMuyEstudiosoAdapter(); break;
					
					case 3: fabrica = new FabricaDeAlumnosDecorados(); break;
					
					case 4: fabrica = new FabricaAlumnoMuyEstudiosoDecorado(); break;
			}
		
			return fabrica.crearAleatorio();
		}
	
		public static Student crearPorTeclado(int opcion)
		{
			StudentsFactory fabrica = null;
			
			switch (opcion) 
			{
					case 1: fabrica = new FabricadeAlumnoAdapter(); break;
			}
		
			return fabrica.crearPorTeclado();
		}
	
		public abstract Student crearAleatorio();
		
		public abstract Student crearPorTeclado();
	
	}
}