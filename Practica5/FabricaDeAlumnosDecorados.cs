/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 25/5/2025
 * Hora: 19:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of FabricaDeAlumnosDecorados.
	/// </summary>
	public class FabricaDeAlumnosDecorados: StudentsFactory
	{
		public FabricaDeAlumnosDecorados()
		{
		}
	
		public override IAlumno crearAleatorio()
		{		
			IAlumno alumno =(IAlumno)FabricaDeComparables.crearAleatorio(2);
			
			alumno = new DecoradoConLetras(alumno);
			
			alumno = new DecoradoConLegajo(alumno);
			
			alumno = new DecoradoConEstado(alumno);
			
			alumno = new DecoradoConAsteriscos(alumno);
			
			return alumno;
		}
	
		public override IAlumno crearPorTeclado()
		{
			IAlumno alumno = (Alumno)FabricaDeComparables.crearPorTeclado(2);
			
			alumno = new DecoradoConLetras(alumno);
			
			alumno = new DecoradoConLegajo(alumno);
			
			alumno = new DecoradoConEstado(alumno);
			
			alumno = new DecoradoConAsteriscos(alumno);
			
			return alumno;
		}
	}
}
