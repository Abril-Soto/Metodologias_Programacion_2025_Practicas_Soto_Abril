/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 14/4/2025
 * Hora: 19:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of iteradorDeCola.
	/// </summary>
	public class IteradorDeCola: Iterador
	{
		private Cola cola;
		
		private int index;
		
		public IteradorDeCola(Cola c)
		{
			this.cola = c;
			
			this.primero();
		}
	
		public void primero()
		{
			this.index = 0;
		}
		
		public void siguiente()
		{
			this.index ++;
		}
		
		public bool fin()
		{
			return this.index >= cola.cuantos();
		}
		
		public Comparable actual()
		{
			return cola.getElementos()[index];
		}
	}
}
