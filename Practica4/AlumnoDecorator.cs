/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 12/5/2025
 * Hora: 18:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of AlumnoDecorator.
	/// </summary>
	public abstract class AlumnoDecorator: IAlumno
	{
		protected IAlumno adicional;
		
		public AlumnoDecorator(IAlumno a)
		{
			this.adicional = a;
		}
		
		public bool sosIgual(Comparable c)
		{
			return this.adicional.sosIgual(c);
		}
		
		public bool sosMenor(Comparable c)
		{
			return this.adicional.sosMenor(c);
		}
		
		public bool sosMayor(Comparable c)
		{
			return this.adicional.sosMayor(c);
		}
		
		public int getCalificacion()
		{
			return this.adicional.getCalificacion();
		}
		
		public void setCalificacion(int calificacion)
		{
			this.adicional.setCalificacion(calificacion);
		}
		
		public int getLegajo()
		{
			return this.adicional.getLegajo();		
		}
		
		public int getPromedio()
		{
			return this.adicional.getPromedio();
		}
		
		public int getDni()
		{
			return this.adicional.getDni();
		}
		
		public string getNombre()
		{
			return this.adicional.getNombre();
		}
		public virtual string mostrarCalificacion()
		{
			return this.adicional.mostrarCalificacion();
		}
		
		public void prestarAtencion()
		{
			this.adicional.prestarAtencion();
		}
		
		public void distraerse()
		{
			this.adicional.distraerse();
		}
	
		public void actualizar(Observado o)
		{
			this.adicional.actualizar(o);
		}
	
		public int reponderPregunta(int pregunta)
		{
			return this.adicional.reponderPregunta(pregunta);
		}
	}
}
