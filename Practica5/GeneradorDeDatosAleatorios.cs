/*
 * Creado por SharpDevelop.
 * Usuario: Abril Soto
 * Fecha: 9/4/2025
 * Hora: 18:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica5
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary>
	public class GeneradorDeDatosAleatorios
	{
		public GeneradorDeDatosAleatorios()
		{
		}
	
		public int numeroAleatorio(int max)
		{
			Random rand = new Random();
			
			return rand.Next(max);
		}
	
		public string stringAleatorio(int cant)
		{
			const string letras = "abcdefghijklmnopqrstuvwxyz";
			
			char[] caracteres = new char[cant];
			
     		Random rand = new Random();

     		for (int i = 0; i < cant; i++) 
     		{
     			
       		 caracteres[i] = letras[rand.Next(letras.Length)];
       		 
     		}

      		string cadenaRandom = new string(caracteres);
      		
      		return cadenaRandom;
		}
	}
}
