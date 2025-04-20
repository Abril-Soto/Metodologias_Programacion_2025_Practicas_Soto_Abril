/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 9/4/2025
 * Hora: 20:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica3
{
	/// <summary>
	/// Ejercicio 8 of Profesor.
	/// </summary>
	public class Profesor: Persona, Observado
	{
		private int antiguedad;
		private bool hablando;
		
		private List<Observador> observadores;
		
		public Profesor(string nom, int dni, int antiguedad): base(nom, dni)
		{
			this.antiguedad = antiguedad;
			
			this.observadores = new List<Observador>();
		}
		
		public int getAntiguedad()
		{
			return this.antiguedad;
		}
		
		//ejercicio 9: comparar a los profesores por antiguedad.
		
		public override bool sosIgual(Comparable c)
		{
			return this.antiguedad == ((Profesor)c).antiguedad;
		}
		
		public override bool sosMenor(Comparable c)
		{
			return this.antiguedad < ((Profesor)c).antiguedad;
		}
		
		public override bool sosMayor(Comparable c)
		{
			return this.antiguedad > ((Profesor)c).antiguedad;
		}
		
		public bool getHablando()
		{
			return this.hablando;
		}
		
		public void hablarALaClase()
		{
			Console.WriteLine("Hablando de algun tema. ");
			
			hablando = true;
			
			this.notificar();
		}
		
		public void escribirEnElPizarron()
		{
			Console.WriteLine("Escribiendo en el pizarron. ");
			
			hablando = false;
			
			this.notificar();
		}
	
		//ejercicio 12: parte del patron observer
		
		public void agregarObservador(Observador o)
		{
			this.observadores.Add(o);
		}
		public void quitarObservador(Observador o)
		{
			this.observadores.Remove(o);
		}
		
		public void notificar()
		{
			foreach (Observador observador in observadores) 
			{
				observador.actualizar(this);
			}
		}
	
		public override string ToString()
		{
			return string.Format("Nombre: {0}, dni: {1}, antiguedad: {2}", nombre, dni, antiguedad);
		}
	}
}
