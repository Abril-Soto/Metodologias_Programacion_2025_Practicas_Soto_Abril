/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 26/3/2025
 * Hora: 14:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// ejercicio 8.
	/// </summary>
	public class ColeccionMultiple: Coleccionable
	{
		private Pila pila;
		
		private Cola cola;
		
		public ColeccionMultiple()
		{
			this.pila = new Pila();
			this.cola = new Cola();
		}
		
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pila = p;
			this.cola = c;
		}
	
		public int cuantos()
		{
			return this.pila.cuantos() + this.cola.cuantos();
		}
		
		public Comparable minimo()
		{
			Comparable minCola = this.cola.minimo();
			
			Comparable minPila = this.pila.minimo();
			
			if(minCola.sosMenor(minPila))
			{
				return minCola;
			} 
			
			return minPila;
		}
		
		public Comparable maximo()
		{
			Comparable maxCola = this.cola.maximo();
			
			Comparable maxPila = this.pila.maximo();
			
			if(maxCola.sosMayor(maxPila))
			{
				return maxCola;
		} 
			
			return maxPila;
		}
		
		public void agregar(Comparable c)
		{
			
		}
		
		public bool contiene(Comparable c)
		{
			return this.pila.contiene(c) || this.cola.contiene(c);
		}
		
		public Iterador crearIterador()
		{
			return new IteradorDeColeccionMultiple(this.pila, this.cola);
		}
	
	}
}
