/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 7/5/2025
 * Hora: 13:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
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
					case 1: fabrica = new FabricaDeAlumnosDecorados(); break;
					
					case 2: fabrica = new FabricaAlumnoMuyEstudiosoDecorado(); break;
			}
		
			IAlumno alumno = fabrica.crearAleatorio();
			
			return new AlumnoAdapter(alumno);
		}
	
		public static Student crearPorTeclado(int opcion)
		{
			StudentsFactory fabrica = null;
			
			switch (opcion) 
			{
					case 1: fabrica = new FabricaDeAlumnosDecorados(); break;
					case 2: fabrica = new FabricaAlumnoMuyEstudiosoDecorado(); break;
			}
		
			return new AlumnoAdapter(fabrica.crearPorTeclado());
		}
	
		public abstract IAlumno crearAleatorio();
		
		public abstract IAlumno crearPorTeclado();
	
	}
}