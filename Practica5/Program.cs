/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 23/4/2025
 * Hora: 18:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			//ejercicio 10
			
			Pila pila = (Pila)FabricaDeColeccionables.crearColeccionable(1);
			
			Aula aula = new Aula();
			
			pila.setOrdenInicio(new OrdenInicio(aula));
			
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			
			llenar(pila, 1);
			
			llenar(pila, 2);
			
			/*
			//prueba para saber si AlumnoProxy funciona sin errores.
			
			Teacher teacher = new Teacher();
			
			IAlumno alumno;
			
			Student student;
			
			for (int i = 0; i < 10; i++) 
			{
				//student = StudentsFactory.crearAleatorio(1);
				
				alumno = new AlumnoProxy("pepe", 1232112, 4523232, 7, 2);
				
				alumno = new DecoradoConLetras(alumno);
				
				alumno = new DecoradoConLegajo(alumno);
				
				alumno = new DecoradoConEstado(alumno);
				
				alumno = new DecoradoConAsteriscos(alumno);
				
				student = new AlumnoAdapter(alumno);
				
				teacher.goToClass(student);
			}
			
			for (int i = 0; i < 10; i++) 
			{
				alumno = new AlumnoProxy("pedro", 1232112, 4523232, 6, 4);
			
				alumno = new DecoradoConLetras(alumno);
				
				alumno = new DecoradoConLegajo(alumno);
				
				alumno = new DecoradoConEstado(alumno);
				
				alumno = new DecoradoConAsteriscos(alumno);
				
				student = new AlumnoAdapter(alumno);
				
				//student = StudentsFactory.crearAleatorio(2);
				
				teacher.goToClass(student);
			}
			
			teacher.teachingAClass();
				*/
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	
		public static void llenar(Coleccionable coleccion, int opcion)
		{
			for (int i = 0; i < 20; i++)
			{
				Comparable elemento = (Comparable)((AlumnoAdapter)StudentsFactory.crearAleatorio(opcion)).getAlumno();
				
				coleccion.agregar(elemento);
			}
		}
	}
}