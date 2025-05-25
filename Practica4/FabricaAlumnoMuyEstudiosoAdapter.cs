/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 7/5/2025
 * Hora: 14:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of FabricaAlumnoMuyEstudiosoAdapter.
	/// </summary>
	public class FabricaAlumnoMuyEstudiosoAdapter: StudentsFactory
	{
		public FabricaAlumnoMuyEstudiosoAdapter()
		{
		}
		
		public override Student crearAleatorio()
		{		
			return new AlumnoAdapter((IAlumno)FabricaDeComparables.crearAleatorio(4));
		}
	
		public override Student crearPorTeclado()
		{
			return new AlumnoAdapter((IAlumno)FabricaDeComparables.crearPorTeclado(4));
		}
	}
}
