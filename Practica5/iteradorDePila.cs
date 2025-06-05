/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 14/4/2025
 * Hora: 17:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of iteradorDePila.
	/// </summary>
	public class iteradorDePila: Iterador
	{
		private Pila p;
		
		private int index;
		
		public iteradorDePila(Pila p)
		{
			this.p = p;
			
			this.primero();
		}
	
		public void primero()
		{
			this.index = 0;
		}
		
		public void siguiente()
		{
			index ++;
		}
		
		public bool fin()
		{
			return this.index >= p.cuantos();
		}
		
		public Comparable actual()
		{
			return p.getElementos()[index];
		}
	}
}
