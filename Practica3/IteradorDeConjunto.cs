/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 14/4/2025
 * Hora: 17:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica3
{
	/// <summary>
	/// Description of IteradorDeConjunto.
	/// </summary>
	public class IteradorDeConjunto: Iterador
	{
		private Conjunto conjunto;
		
		private int index;
		
		public IteradorDeConjunto(Conjunto conjunto)
		{
			this.conjunto = conjunto;
			
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
			return this.index >= conjunto.cuantos();
		}
		
		public Comparable actual()
		{
			return conjunto.getElementos()[index];
		}
	
	}
}
