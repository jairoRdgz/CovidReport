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
        private List<string> departamentos;
        private List<int> departamentValues;

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
        
        public List<string> getDepartamentos()
        {
            return departamentos;
        }

        public List<int> getDepartamentValues()
        {
            return departamentValues;
        }
       
        public void setDepartments()
        {
            
            departamentos = new List<string>();
            departamentValues = new List<int>();
            
            foreach (var item in datos)
            {

                if (!departamentos.Contains(item.getDepartamento()))
                {
                    departamentos.Add(item.getDepartamento());
                    departamentValues.Add(0);
                    
                }

                for (int i = 0; i < departamentos.Count(); i++)
                {
                    if(item.getDepartamento() == departamentos[i])
                    {
                        departamentValues[i] = departamentValues.ElementAt<int>(i) + 1;
                    }
                }
            }
        }

    }
}
