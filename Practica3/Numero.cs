/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 25/3/2025
 * Hora: 15:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica3
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero: Comparable
	{
		private int valor;
		
		public Numero(int v)
		{
			this.valor = v;
		}
		
		public int GetValor()
		{
			return this.valor;
		}
		
		public bool sosIgual(Comparable c)
		{
			return this.valor == ((Numero)c).GetValor();
		}
		
		public bool sosMenor(Comparable c)
		{
			return this.valor < ((Numero)c).GetValor();
		}
		
		public bool sosMayor(Comparable c)
		{
			return this.valor > ((Numero)c).GetValor();
		}
		
		public override string ToString()
		{
			return this.valor.ToString();
		}

	
	}
}
