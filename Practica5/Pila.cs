/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 25/3/2025
 * Hora: 15:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica5
{
	/// <summary>
	/// </summary>
	public class Pila: Coleccionable, Ordenable
	{
		private List<Comparable> elementos;
		
		private OrdenEnAula1 ordenInicio, ordenAulaLlena;
		
		private OrdenEnAula2 ordenLlegaAlumno;
			
		public Pila()
		{
			this.elementos = new List<Comparable>();
		}
		
		public List<Comparable> getElementos()
		{
			return this.elementos;
		}
		
		public void apilar(Comparable c)
		{
			this.elementos.Add(c);
			
			if (elementos.Count == 1 && ordenInicio != null) 
			{
				this.ordenInicio.ejecutar();
			}
			
			if (ordenLlegaAlumno != null)
			{
				this.ordenLlegaAlumno.ejecutar(c);
			}
			
			if (elementos.Count == 40) {
				
				this.ordenAulaLlena.ejecutar();
			}
		}
		
		public Comparable desapilar()
		{
			Comparable aux = this.elementos[elementos.Count-1];
			
			this.elementos.RemoveAt(elementos.Count-1);
			
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
			this.apilar(c);
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
			return new iteradorDePila(this);
		}
	
		//interfase Ordenable
		
		public void setOrdenInicio(OrdenEnAula1 o)
		{
			this.ordenInicio = o;
		}
		
		public void setOrdenLlegaAlumno(OrdenEnAula2 o)
		{
			this.ordenLlegaAlumno = o;
		}
		
		public void setOrdenAulaLlena(OrdenEnAula1 o)
		{
			this.ordenAulaLlena = o;
		}
	
		
	}
}
