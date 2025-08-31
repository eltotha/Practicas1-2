using Microsoft.AspNetCore.Mvc;

namespace Tarea1.Controllers
{
	public class Ejercicio2 : Controller
	{
		private List<string> nombres = new List<string>
		{
            "Valeria", "Andrés", "Camila", "Sebastian", "Mariana", "Gabriel", "Daniela", "Fernando", "Natalia", "Pancho"
		};

		public IActionResult Index()
		{
			return View();
		}

		public string BuscarPosicion(int posicion)
		{
			if (posicion < 0 || posicion >= nombres.Count)
			{
				return "Posición inválida";
			}

			return $"El nombre de la posicion '{posicion}' es: '{nombres[posicion]}' ";
            
        }

		public int BuscarCadena(string nombre)
		{
            return nombres.FindIndex(n => n.Equals(nombre));
        }
	}
}
