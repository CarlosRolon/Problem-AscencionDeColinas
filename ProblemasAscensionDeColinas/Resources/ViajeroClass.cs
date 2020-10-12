using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources
{
    public class ViajeroClass
    {
        public List<string> Ciudades { get; set; }

        public ViajeroClass()
        {
            Ciudades = new List<string>();
        }

        public void AgregarCiudad(string nuevaCiudad)
        {
            Ciudades.Add(nuevaCiudad);
        }

        public void EliminarCiudadEnPosicion(int posicion)
        {
            Ciudades.RemoveAt(posicion);
        }

        public void EliminarTodasCiudades()
        {
            Ciudades.Clear();
        }

    }
}
