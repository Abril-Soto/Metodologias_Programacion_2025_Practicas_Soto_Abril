/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 12/5/2025
 * Hora: 14:06
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno: Comparable
	{	
		int getCalificacion();
		
		void setCalificacion(int calificacion);
		
		int getLegajo();
		
		void setLegajo(int legajo);
		
		int getPromedio();
		
		void setPromedio(int prom);
		
		int getDni();
		
		void setDni(int dni);
		
		string getNombre();
		
		void setNombre(string nombre);
		
		void setEstrategiaDeComparacion(EstrategiaDeComparacion estrategia);
		
		string mostrarCalificacion();
		
		void prestarAtencion();
		
		void distraerse();
		
		void actualizar(Observado o);
		
		int responderPregunta(int pregunta);
	}
}
