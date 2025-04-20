/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 27/3/2025
 * Hora: 17:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica3
{
	/// <summary>
	/// ejercicio 12
	/// </summary>
	public class Alumno: Persona, Observador
	{
		private int legajo;
		private int promedio;
		private EstrategiaDeComparacion estrategia;
		
		public Alumno(string nom, int dni, int leg, int prom): base(nom, dni)
		{
			this.legajo = leg;
			this.promedio = prom;
			this.estrategia = new ComparacionPorLegajo(); //estrategia por defecto
		}
	
		public int getLegajo()
		{
			return this.legajo;
		}
	
		public int getPromedio()
		{
			return this.promedio;
		}
		
		public void setEstrategiaDeComparacion(EstrategiaDeComparacion estrategia)
		{
			this.estrategia = estrategia;
		}
		
		public override bool sosIgual(Comparable c)
		{
			return this.estrategia.sosIgual(this, (Alumno)c);
		}
	
		public override bool sosMenor(Comparable c)
		{
			return this.estrategia.sosMenor(this,(Alumno)c);
		}
		
		public override bool sosMayor(Comparable c)
		{
			return this.estrategia.sosMayor(this, (Alumno)c);
		}
	
		public override string ToString()
		{
			return string.Format("Nombre: {0}, Dni: {1}, Legajo: {2}, Promedio: {3}", nombre, dni, legajo, promedio);
		}
	
		public void prestarAtencion()
		{
			Console.WriteLine("Prestando atencion. ");
		}
	
		public void distraerse()
		{
			string[] distracciones = new string[]{"Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel"};
			
			Random rand = new Random();
			
			int index = rand.Next(3);
			
			Console.WriteLine(distracciones[index]);
		}
	
		public void actualizar(Observado o)
		{
			if(((Profesor)o).getHablando()) {
				
				this.prestarAtencion();
			} else this.distraerse();
		}
		
	
	}
}
