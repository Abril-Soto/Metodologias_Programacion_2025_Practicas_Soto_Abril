/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 26/3/2025
 * Hora: 13:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica4
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola: Coleccionable
	{
		private List<Comparable> elementos;
			
		public Cola()
		{
			this.elementos = new List<Comparable>();
		}
		
		public List<Comparable> getElementos()
		{
			return this.elementos;
		}
		
		public void encolar(Comparable c)
		{
			this.elementos.Add(c);
			
		}
		
		public Comparable desencolar()
		{
			Comparable aux = this.elementos[0];
			
			this.elementos.RemoveAt(0);
			
			return aux;
		}
		
		public int cuantos()
		{
			return this.elementos.Count;
		}
		
		public Comparable minimo()
		{
			Comparable minActual = this.elementos[0];
			
			for (int i = 1; i < this.cuantos(); i++) 
			{
				if (this.elementos[i].sosMenor(minActual))
				{
					minActual = this.elementos[i];
				}
			}
			
			return minActual;
		}
		
		public Comparable maximo()
		{
			Comparable maxActual = this.elementos[0];
			
			for (int i = 1; i < this.cuantos(); i++) 
			{
				if (this.elementos[i].sosMayor(maxActual))
				{
					maxActual = this.elementos[i];
				}
			}
			
			return maxActual;
		}
		
		public void agregar(Comparable c)
		{
			this.encolar(c);
		}
		
		public bool contiene(Comparable c)
		{
			foreach (var element in this.elementos) 
			{	
				if(element.sosIgual(c))
				{
					return true;
				}
			}
		
			return false;
		}
		
		public Iterador crearIterador()
		{
			return new IteradorDeCola(this);
		}
	}
}
