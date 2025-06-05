/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 12/5/2025
 * Hora: 18:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of DecoradoConLegajo.
	/// </summary>
	public class DecoradoConLegajo: AlumnoDecorator
	{
		public DecoradoConLegajo(IAlumno a): base(a)
		{
		}
	
		public override string mostrarCalificacion()
		{
			string res = base.mostrarCalificacion();
			
			res = res.Insert(res.IndexOf('\t'), "(" + base.getLegajo() + ")");
			
			return res;
		}
	
	}
}
