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

namespace Practica5
{
	/// <summary>
	/// Description of Cola.
	/// </summary>

	public class Cola: Coleccionable, Ordenable
	{
		private List<Comparable> elementos;
		
		private OrdenEnAula1 ordenInicio, ordenAulaLlena;
		
		private OrdenEnAula2 ordenLlegaAlumno;
			
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
			
			if (this.cuantos() == 1 && this.ordenInicio != null)
			{
				this.ordenInicio.ejecutar();
			}
			
			if (this.ordenLlegaAlumno != null) 
			{
				this.ordenLlegaAlumno.ejecutar(c);
			}
		
			if (this.cuantos() == 40)
			{
				this.ordenAulaLlena.ejecutar();
			}
		
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
