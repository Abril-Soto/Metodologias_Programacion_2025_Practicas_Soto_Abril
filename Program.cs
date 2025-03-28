/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 25/3/2025
 * Hora: 14:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//ejercicio 7.
			
			/*Coleccionable pila = new Pila();
			
			Coleccionable cola = new Cola();
			
			llenar(pila);
			
			llenar(cola);
			
			informar(pila);
			
			informar(cola);
			*/
			
			//ejercicio 9
			/*
			Pila p = new Pila();
			
			Cola c = new Cola();
			
			llenar(p);
			
			llenar(c);
			
			informar(p);
			
			informar(c);
			
			ColeccionMultiple colecMulti = new ColeccionMultiple(p, c);
			
			informar(colecMulti);
			*/
			
			//ejercicio 14
			
			Pila pila = new Pila();
			
			Cola cola = new Cola();
			
			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
			
			llenarAlumnos(pila);
			
			llenarAlumnos(cola);
			
			informar(multiple);
				
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	
		//ejercicio 5
		public static void llenar(Coleccionable elementos)
		{
			Random elemRandom = new Random();
			
			for (int i = 0; i < 20; i++) 
			{
				Comparable nuevoElem = new Numero(elemRandom.Next(100));
				
				elementos.agregar(nuevoElem);
			}
		}
		
		//ejercicio 6
		
		public static void informar(Coleccionable elementos)
		{
			Console.WriteLine("cantidad elementos: " + elementos.cuantos());
			
			Console.WriteLine("valor minimo: " + elementos.minimo());
			
			Console.WriteLine("valor maximo: " + elementos.maximo());
			
			Console.WriteLine("Ingrese un valor entero: ");
			
			Comparable aux = new Numero(int.Parse(Console.ReadLine())); //aca tira error porque cuando el comparable es una persona no se puede comparar con un objeto numero
			
			if (elementos.contiene(aux))
			{
				Console.WriteLine("El elemento leído está en la colección.");
			} else Console.WriteLine("El elemento leído NO está en la colección.");
			
		}
	
		//ejercicio 13
		
		public static void llenarAlumnos(Coleccionable elementos)
		{
			Random rand = new Random();
			
			string[] nomAlumnos = new string[20]{"Maria", "Julian", "Enzo", "Lautaro", "Lionel", "Emilino", "Gabriel", "Cristian", "Lissandro", "Nicolas", "Leandro", "Rodrigo", "Alexis", "Thiago", "Emilia", "Lucia", "Harry", "Liam", "Louis", "Niall"};
			
			for (int i = 0; i < 20; i++) 
			{
				int dni = rand.Next(20000000, 50000000);
				
				int legajo = rand.Next(150000);
				
				int promedio = rand.Next(10);
			
				int indicenom = rand.Next(nomAlumnos.Length);
				
				elementos.agregar(new Alumno(nomAlumnos[indicenom], dni, legajo, promedio));
			}
		
		}
	}
}