/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 7/5/2025
 * Hora: 13:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica4
{
	/// <summary>
	/// Description of FabricadeAlumnoAdapter.
	/// </summary>
	public class FabricadeAlumnoAdapter: StudentsFactory
	{
		public FabricadeAlumnoAdapter()
		{
		}
	
		public override Student crearAleatorio()
		{		
			return new AlumnoAdapter((IAlumno)FabricaDeComparables.crearAleatorio(2));
		}
	
		public override Student crearPorTeclado()
		{
			return new AlumnoAdapter((IAlumno)FabricaDeComparables.crearPorTeclado(2));
		}
	}
}
