/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 19/5/2025
 * Hora: 18:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of DecoradoConEstado.
	/// </summary>
	public class DecoradoConEstado: AlumnoDecorator
	{
		public DecoradoConEstado(IAlumno alumno): base(alumno)
		{
		}

    	public override string mostrarCalificacion() 
    	{	
    		string estado;
    		
    		if (base.getCalificacion()>=7) 
    		{	
    			 estado = "PROMOCION";
    		}
    		else if(base.getCalificacion()<4)
    		{
    			estado = "DESAPROBADO";
    		} else 
    		{
    			estado = "APROBADO";
    		}
    		
    		return base.mostrarCalificacion() + "(" + estado + ")";
    	}

	}
}
