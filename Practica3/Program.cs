/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 9/4/2025
 * Hora: 18:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//ejercicio 6
			
			Console.WriteLine("Seleccione la coleccion que desea:\n" +
			                  "1- Pila\n" +
			                  "2- Cola\n" +
			                  "3- Coleccion Multiple\n" +
			                  "4- Conjunto\n");
			
			Coleccionable coleccion = FabricaDeColeccionables.crearColeccionable(int.Parse(Console.ReadLine()));
			
			Console.WriteLine("Seleccione los elementos que desea en la coleccion: \n" +
			                  "1- Numeros\n" +
			                  "2- Alumnos\n");
			
			int opcion = int.Parse(Console.ReadLine());
			
			llenar(coleccion, opcion);
			
			informar(coleccion, opcion);
			
			//ejercicio 14
			
			Profesor profesor = (Profesor)FabricaDeComparables.crearAleatorio(3);
			
			Iterador ite = coleccion.crearIterador();
			
			while (!ite.fin()) 
			{
				profesor.agregarObservador((Observador)ite.actual());
				
				ite.siguiente();
			}
			
			dictadoDeClases(profesor);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	
		//ejercicio 6
		public static void llenar(Coleccionable coleccion, int opcion)
		{
			for (int i = 0; i < 20; i++)
			{	
				Comparable elemento = FabricaDeComparables.crearAleatorio(opcion);
				
				coleccion.agregar(elemento);
			}
		}
		
		//ejercicio 6
		public static void informar(Coleccionable coleccion, int opcion)
		{
			Console.WriteLine("cantidad elementos: " + coleccion.cuantos());
			
			Console.WriteLine("valor minimo: " + coleccion.minimo());
			
			Console.WriteLine("valor maximo: " + coleccion.maximo());
			
			Console.WriteLine("1- Ingrese un numero entero para saber si esta en la coleccion\n" +
			                  "2- Ingrese nombre, dni, legajo y promedio del alumno para saber si esta en la coleccion.");
			
			Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
			
			if (coleccion.contiene(comparable)) 
			{
				Console.WriteLine("El elemento leído está en la colección.");
				
			} else Console.WriteLine("El elemento leído NO está en la colección.");
		}
	
	
		public static void dictadoDeClases(Profesor profesor)
		{
			for (int i = 0; i < 5; i++) 
			{
				profesor.hablarALaClase();
				
				profesor.escribirEnElPizarron();
			}
		}
	}
}