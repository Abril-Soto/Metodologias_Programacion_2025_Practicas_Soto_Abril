/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 7/4/2025
 * Hora: 19:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica5
{
	/// <summary>
	/// 
	/// </summary>
	public class Conjunto: Coleccionable
	{
		private List<Comparable> elementos;
		
		public Conjunto()
		{
			this.elementos = new List<Comparable>();
		}
	
		public int cuantos()
		{
			return this.elementos.Count;
		}
		
		public List<Comparable> getElementos()
		{
			return this.elementos;
		}
		public Comparable minimo()
		{
			Comparable minActual = elementos[0];
			
			for (int i = 1; i < this.cuantos(); i++) 
			{
				if (this.elementos[i].sosMenor(minActual))
				{
					minActual = elementos[i];
				}
			}
			
			return minActual;
		}
		
		public Comparable maximo()
		{
			Comparable minActual = elementos[0];
			
			for (int i = 1; i < this.cuantos(); i++) 
			{
				if (this.elementos[i].sosMayor(minActual))
				{
					minActual = elementos[i];
				}
			}
			
			return minActual;
		}
		
		public void agregar(Comparable c)
		{
			if (!this.contiene(c))
			{
				elementos.Add(c);
			}
		}
		
		public bool contiene(Comparable c)
		{
			foreach (var element in this.elementos) 
			{
				if (element.sosIgual(c)) 
				{
					return true;
				}
			}
			
			return false;
				
		}
	
		public Iterador crearIterador()
		{
			return new IteradorDeConjunto(this);
		}
	}
}
