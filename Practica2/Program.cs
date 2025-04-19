/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 3/4/2025
 * Hora: 19:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica2
{
	class Program
	{
		public static void Main(string[] args)
		{			
			//ejercicio 9. Practica 2
			
			Pila pila = new Pila();
			
			llenarAlumnos(pila);
			
			informar(pila);
			
			Console.WriteLine("\nComparacion por nombre: ");
			
			cambiarEstrategia(pila, new ComparacionPorNombre());
			
			informar(pila);
			
			Console.WriteLine("\nComparacion por legajo: ");
			
			cambiarEstrategia(pila, new ComparacionPorLegajo());
			
			informar(pila);
			
			Console.WriteLine("\nComparacion por dni: ");
			
			cambiarEstrategia(pila, new ComparacionPorDni());
			
			informar(pila);

			
			// TODO: Implement Functionality Here
			
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
			
			Comparable tipo = elementos.minimo();

    		Comparable aux;

	  		if (tipo is Alumno)
	   		 {
	        	Console.Write("Ingrese el nombre del alumno: ");
	        	
	        	string nombre = Console.ReadLine();
	        	
		        Console.Write("Ingrese el dni del alumno: ");
		        
		        int dni = int.Parse(Console.ReadLine());
		        
		        Console.Write("Ingrese el legajo del alumno: ");
		        
		        int legajo = int.Parse(Console.ReadLine());
		        
		        Console.Write("Ingrese el promedio del alumno: ");
		        
		        int promedio = int.Parse(Console.ReadLine());
		
		        aux = new Alumno(nombre, dni, legajo, promedio);
		     }
	  		
		    else
		    {
		        Console.Write("Ingrese valor entero: ");
		        
		        aux = new Numero(int.Parse(Console.ReadLine()));
		    }
			
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
				
				int promedio = rand.Next(11);
			
				int indicenom = rand.Next(nomAlumnos.Length);
				
				Alumno alum = new Alumno(nomAlumnos[indicenom], dni, legajo, promedio);
				
				alum.setEstrategiaDeComparacion(new ComparacionPorPromedio());
				
				elementos.agregar(alum);
				
			}
		
		}
	
		//PRACTICA 2. Ejercicio 6
		
		public static void imprimirElementos(Coleccionable coleccion)
		{
			Iterador ite = coleccion.crearIterador();
			
			while(!ite.fin())
			{
				Console.WriteLine(ite.actual());
				ite.siguiente();
			}
		}
	
		//PRACTICA 2. Ejercicio 8.

		public static void cambiarEstrategia(Coleccionable coleccion, EstrategiaDeComparacion nuevaestrategia)
		{
			Iterador ite = coleccion.crearIterador();
			
			for (ite.primero(); !ite.fin(); ite.siguiente())
			{
				((Alumno)ite.actual()).setEstrategiaDeComparacion(nuevaestrategia);
			}
			
			/*
			while (!ite.fin()) 
			{
				((Alumno)ite.actual()).setEstrategiaDeComparacion(nuevaestrategia);
					
				ite.siguiente();
			}*/
		}
	}
}