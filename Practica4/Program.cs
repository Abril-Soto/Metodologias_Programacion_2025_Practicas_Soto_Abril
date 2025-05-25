/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 23/4/2025
 * Hora: 18:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	class Program
	{
		public static void Main(string[] args)
		{
			//ejercicio 4
			
			/*Teacher teacher = new Teacher();
			
			for (int i = 0; i < 10; i++) 
			{
				Student student = StudentsFactory.crearAleatorio(1);
				
				teacher.goToClass(student);
			}
			
			for (int i = 0; i < 10; i++) 
			{
				Student student = StudentsFactory.crearAleatorio(2);
				
				teacher.goToClass(student);
			}
			
			teacher.teachingAClass(); */
			
			//ejercicio 8
			
			Teacher teacher = new Teacher();
			
			for (int i = 0; i < 10; i++) 
			{
				Student student = StudentsFactory.crearAleatorio(3);
				
				teacher.goToClass(student);
			}
			
			for (int i = 0; i < 10; i++) 
			{
				Student student = StudentsFactory.crearAleatorio(4);
				
				teacher.goToClass(student);
			}
			
			teacher.teachingAClass();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}