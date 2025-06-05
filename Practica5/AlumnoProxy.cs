/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 23/4/2025
 * Hora: 18:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of AlumnoProxy.
	/// </summary>
	public class AlumnoProxy: IAlumno
	{
		private Alumno alumnoReal = null;
		
		private string nombre;
		
		private int legajo;
		
		private int dni;
		
		private int promedio;
		
		private int calificacion;
		
		private EstrategiaDeComparacion estrategiaDeComparacion;
		
		private int opcion;
		
		public AlumnoProxy(string nombre, int legajo, int dni, int promedio, int opcion)
		{
			this.nombre = nombre;
			
			this.opcion = opcion;
			
			this.legajo = legajo;
			
			this.dni = dni;
			
			this.promedio = promedio;
			
			this.estrategiaDeComparacion = new ComparacionPorPromedio();
		}
	
		//metodo que el proxy sabe resolver.
		public string getNombre()
		{	
			return "Soy un AlumnoProxy: " + this.nombre;
		}
		
		public void setNombre(string nom)
		{
			this.nombre = nom;
		}
		
		public int getCalificacion()
		{	
			return this.calificacion;
		}
	
		public void setCalificacion(int calificacion)
		{
			this.calificacion = calificacion;
		}
	
		public int getLegajo()
		{			
			return this.legajo;
		}
		
		public void setLegajo(int legajo)
		{
			this.legajo = legajo;
		}
	
		public int getPromedio()
		{
			return this.promedio;
		}
		
		public void setPromedio(int prom)
		{
			this.promedio = prom;
		}
		
		public int getDni()
		{
			return this.dni;
		}
		
		public void setDni(int dni)
		{
			this.dni = dni;
		}
		
		public void setEstrategiaDeComparacion(EstrategiaDeComparacion nuevaEstrategia)
		{
			this.estrategiaDeComparacion = nuevaEstrategia;
		}
		
		public string mostrarCalificacion()
		{
			return this.nombre + "\t" + this.calificacion;
		}

		
		//metodos que el Proxy no sabe hacer.
		
		public int responderPregunta(int pregunta)
		{	
			if (this.alumnoReal == null) {
				
				this.alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
			
				//le seteo al alumno todos los demas atributos
				
				this.alumnoReal.setNombre(this.nombre);
				
				this.alumnoReal.setLegajo(this.legajo);
				
				this.alumnoReal.setDni(this.dni);
			
				this.alumnoReal.setPromedio(this.promedio);
				
				this.alumnoReal.setCalificacion(this.calificacion);
				
				this.alumnoReal.setEstrategiaDeComparacion(this.estrategiaDeComparacion);
			}
			
			//delego la responsabilidad al real
			return this.alumnoReal.responderPregunta(pregunta);
		}
			
		public void prestarAtencion()
		{
			if (this.alumnoReal == null) {
				
				this.alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				
				this.alumnoReal.setNombre(this.nombre);
				
				this.alumnoReal.setLegajo(this.legajo);
				
				this.alumnoReal.setDni(this.dni);
				
				this.alumnoReal.setPromedio(this.promedio);
				
				this.alumnoReal.setCalificacion(this.calificacion);
				
				this.alumnoReal.setEstrategiaDeComparacion(this.estrategiaDeComparacion);
			}
			
			this.alumnoReal.prestarAtencion();
		}
		
		public void distraerse()
		{
			if (this.alumnoReal == null) {
				
				this.alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				
				this.alumnoReal.setNombre(this.nombre);	
			}
			
			this.alumnoReal.distraerse();
		}
		
		public void actualizar(Observado o)
		{
			if (this.alumnoReal == null) {
				
				this.alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				
				this.alumnoReal.setNombre(this.nombre);
				
				this.alumnoReal.setLegajo(this.legajo);
				
				this.alumnoReal.setDni(this.dni);
				
				this.alumnoReal.setPromedio(this.promedio);
				
				this.alumnoReal.setCalificacion(this.calificacion);
				
				this.alumnoReal.setEstrategiaDeComparacion(this.estrategiaDeComparacion);	
			}
			
			this.alumnoReal.actualizar(o);
		}
		
		public bool sosIgual(Comparable c)
		{
			if (this.alumnoReal == null) {
				
				this.alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				
				this.alumnoReal.setNombre(this.nombre);
				this.alumnoReal.setLegajo(this.legajo);
				this.alumnoReal.setDni(this.dni);
				this.alumnoReal.setPromedio(this.promedio);
				this.alumnoReal.setCalificacion(this.calificacion);
				this.alumnoReal.setEstrategiaDeComparacion(this.estrategiaDeComparacion);	
			}
			
			return this.alumnoReal.sosIgual(c);
		}
		
		public bool sosMenor(Comparable c)
		{
			if (this.alumnoReal == null) {
				
				this.alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				
				this.alumnoReal.setNombre(this.nombre);
				
				this.alumnoReal.setLegajo(this.legajo);
				
				this.alumnoReal.setDni(this.dni);
				
				this.alumnoReal.setPromedio(this.promedio);
				
				this.alumnoReal.setCalificacion(this.calificacion);
				
				this.alumnoReal.setEstrategiaDeComparacion(this.estrategiaDeComparacion);	
			}
			
			return this.alumnoReal.sosMenor(c);
		}
	
		public bool sosMayor(Comparable c)
		{
			if (this.alumnoReal == null) {
				
				this.alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(opcion);
				
				this.alumnoReal.setNombre(this.nombre);
				
				this.alumnoReal.setLegajo(this.legajo);
				
				this.alumnoReal.setDni(this.dni);
				
				this.alumnoReal.setPromedio(this.promedio);
				
				this.alumnoReal.setCalificacion(this.calificacion);
				
				this.alumnoReal.setEstrategiaDeComparacion(this.estrategiaDeComparacion);
			}
			
			return this.alumnoReal.sosMayor(c);
		}
	}
}
