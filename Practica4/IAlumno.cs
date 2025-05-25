/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 12/5/2025
 * Hora: 14:06
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno: Comparable
	{	
		int getCalificacion();
		
		void setCalificacion(int calificacion);
		
		int getLegajo();
		
		int getPromedio();
		
		int getDni();
		
		string getNombre();
		
		string mostrarCalificacion();
		
		void prestarAtencion();
		
		void distraerse();
		
		void actualizar(Observado o);
		
		int reponderPregunta(int pregunta);
	}
}
