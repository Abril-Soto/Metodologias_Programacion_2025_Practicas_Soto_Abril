/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 23/4/2025
 * Hora: 20:05
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of Aula.
	/// </summary>
	public class Aula
	{
		private Teacher teacher;
		
		public Aula()
		{
		}
	
		public void comenzar()
		{
			Console.WriteLine("Comenzando la clase.");
			
			this.teacher = new Teacher();
		}
	
		public void nuevoAlumno(IAlumno alumno)
		{
			this.teacher.goToClass(new AlumnoAdapter(alumno));
		}
	
		public void claseLista()
		{
			this.teacher.teachingAClass();
		}
	}
}
