/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 26/3/2025
 * Hora: 15:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica2
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	abstract public class Persona: Comparable
	{
		protected string nombre;
		protected int dni; 
		
		public Persona(string nom, int dni)
		{
			this.nombre = nom;
			this.dni = dni;
		}
	
		public string getNombre()
		{
			return this.nombre;
		}
	
		public int getDni()
		{
			return this.dni;
		}
	
		public virtual bool sosIgual(Comparable c)
		{
			return this.dni == ((Persona)c).dni;
		}
		
		public virtual bool sosMenor(Comparable c)
		{
			return this.dni < ((Persona)c).dni;
		}
		
		public virtual bool sosMayor(Comparable c)
		{
			return this.dni > ((Persona)c).dni;
		}
	
		public override string ToString()
		{
			return string.Format("Nombre: {0}, DNI: {1}",nombre, dni);
		}
	}
}
	