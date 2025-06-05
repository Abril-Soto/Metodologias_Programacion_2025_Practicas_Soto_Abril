/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 19/5/2025
 * Hora: 18:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of DecoradoConLetras.
	/// </summary>
	public class DecoradoConLetras: AlumnoDecorator
	{
		public DecoradoConLetras(IAlumno alumno): base(alumno)
		{
		}
	
		public override string mostrarCalificacion()
		{
			string [] letras = {"CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"};
			
			return base.mostrarCalificacion() + "(" + letras[base.getCalificacion()] + ")";
		}
	}
}
