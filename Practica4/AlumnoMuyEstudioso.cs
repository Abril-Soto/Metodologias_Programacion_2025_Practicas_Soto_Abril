/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 6/5/2025
 * Hora: 19:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso: Alumno
	{
		public AlumnoMuyEstudioso(string nom, int dni, int leg, int prom): base(nom, dni, leg, prom)
		{
		}
	
		public override int reponderPregunta(int pregunta)
		{
			return (pregunta % 3);
		}
	}
}
