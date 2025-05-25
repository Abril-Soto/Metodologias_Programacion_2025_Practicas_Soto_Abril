/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 25/5/2025
 * Hora: 18:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of DecoradoConAsteriscos.
	/// </summary>
	public class DecoradoConAsteriscos: AlumnoDecorator
	{
		public DecoradoConAsteriscos(IAlumno a): base(a)
		{
		}
	
	
		public override string mostrarCalificacion()
		{
			string asteriscos = "*********************************";
			
			return asteriscos + "\n" + "* " + base.mostrarCalificacion() + " *" + "\n" + asteriscos;
		}
		
	}
}
