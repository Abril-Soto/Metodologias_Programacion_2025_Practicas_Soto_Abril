/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 6/5/2025
 * Hora: 20:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of AlumnoAdapter.
	/// </summary>
	public class AlumnoAdapter: Student
	{
		private IAlumno alumno;
		
		public AlumnoAdapter(IAlumno alumno)
		{
			this.alumno = alumno;
		}
	
		public string getName()
		{
			return this.alumno.getNombre();
		}
		public int yourAnswerIs(int question)
		{
			return this.alumno.reponderPregunta(question);
		}
		
		public void setScore(int score)
		{
			this.alumno.setCalificacion(score);
		}
		
		public string showResult()
		{
			return this.alumno.mostrarCalificacion();
		}
		
		public bool equals(Student student)
		{
			return this.alumno.sosIgual((Comparable)((AlumnoAdapter)student).alumno);
		}
		
		public bool lessThan(Student student)
		{
			return this.alumno.sosMenor((Comparable)((AlumnoAdapter)student).alumno);
		}
		
		public bool greaterThan(Student student)
		{
			return this.alumno.sosMayor((Comparable)((AlumnoAdapter)student).alumno);
		}
	
	}
}
