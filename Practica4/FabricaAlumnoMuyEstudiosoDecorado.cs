/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 25/5/2025
 * Hora: 20:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of FabricaAlumnoMuyEstudiosoDecorado.
	/// </summary>
	public class FabricaAlumnoMuyEstudiosoDecorado: StudentsFactory
	{
		public FabricaAlumnoMuyEstudiosoDecorado()
		{
		}
	
		public override Student crearAleatorio()
		{		
			IAlumno alumno =(IAlumno)FabricaDeComparables.crearAleatorio(4);
			
			alumno = new DecoradoConLetras(alumno);
			
			alumno = new DecoradoConLegajo(alumno);
			
			alumno = new DecoradoConEstado(alumno);
			
			alumno = new DecoradoConAsteriscos(alumno);
			
			return new AlumnoAdapter(alumno);
		}
	
		public override Student crearPorTeclado()
		{
			IAlumno alumno = (Alumno)FabricaDeComparables.crearPorTeclado(4);
			
			alumno = new DecoradoConLetras(alumno);
			
			alumno = new DecoradoConLegajo(alumno);
			
			alumno = new DecoradoConEstado(alumno);
			
			alumno = new DecoradoConAsteriscos(alumno);
			
			return new AlumnoAdapter(alumno);
		}
	}
}
