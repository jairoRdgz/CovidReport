using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2.model
{
    class DatoList
    {
        private List<Dato> datos;

        private List<string> ciudades;

        public DatoList()
        {
            datos = new List<Dato>();
        }

        public void addDato(Dato a)
        {
            datos.Add(a);
        }

        public List<Dato> getDatos()
        {
            return datos;
        }

        public void setDatos(List<Dato> a)
        {
            this.datos = a;
        }

        public List<string> getCiudades()
        {
            return ciudades;
        }

        public void setCiudades()
        {
            ciudades = new List<string>();
            foreach (var item in datos)
            {
                if (!ciudades.Contains(item.getCiudad()))
                {
                    ciudades.Add(item.getCiudad()+", Colombia");
                }
            }
            ciudades.Sort();

        }

    }
}
