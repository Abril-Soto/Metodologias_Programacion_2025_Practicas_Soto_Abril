/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 14/4/2025
 * Hora: 20:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica4
{
	/// <summary>
	/// Description of IteradorDeColeccionMultiple.
	/// </summary>
	public class IteradorDeColeccionMultiple: Iterador
	{
		private List<Comparable> elementos;
		
		private int index;
		
		public IteradorDeColeccionMultiple(Pila p, Cola c)
		{
			this.elementos = new List<Comparable>();
			
			Iterador iteCola = c.crearIterador(); 
			
		    while (!iteCola.fin())
        	{
		    	elementos.Add(iteCola.actual());
            	iteCola.siguiente();
       		}
	
	        Iterador itePila = p.crearIterador();
	        
	        while (!itePila.fin())
	        {
	            elementos.Add(itePila.actual());
	            itePila.siguiente();
	        }
				
			this.primero();
		}
		
		public void primero()
		{
			index = 0;
		}
		
		public void siguiente()
		{
			index ++;
		}
		
		public bool fin()
		{
			return this.index >= elementos.Count;
		}
		
		public Comparable actual()
		{
			return elementos[index];
		}
	
	}
}
