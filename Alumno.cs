/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 27/3/2025
 * Hora: 17:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica1
{
	/// <summary>
	/// ejercicio 12
	/// </summary>
	public class Alumno: Persona
	{
		private int legajo;
		private int promedio;
		
		public Alumno(string nom, int dni, int leg, int prom): base(nom, dni)
		{
			this.legajo = leg;
			this.promedio = prom;
		}
	
		public int getLegajo()
		{
			return this.legajo;
		}
	
		public int getPromedio()
		{
			return this.promedio;
		}
		
		public override bool sosIgual(Comparable c)
		{
			return this.legajo == ((Alumno)c).legajo;
		}
	
		public override bool sosMenor(Comparable c)
		{
			return this.legajo < ((Alumno)c).legajo;
		}
		
		public override bool sosMayor(Comparable c)
		{
			return this.legajo > ((Alumno)c).legajo;
		}
	
		public override string ToString()
		{
			return this.legajo.ToString();
		}
	}
}
