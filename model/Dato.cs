using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2.model
{
    class Dato
    {
        //Atributos

        private string ciudad;
        private string edad;
        private string sexo;
        private string departamento;
        private string atencion;

        public Dato(string city, string department, string atention, string age, string sex)
        {
            this.ciudad = city;
            this.edad = age;
            this.sexo = sex;
            this.departamento = department;
            this.atencion = atention;
        }

        public string getCiudad()
        {
            return ciudad;
        }

        public void setCiudad(string city)
        {
            this.ciudad = city;
        }

        public string getEdad()
        {
            return edad;
        }

        public void setEdad(string age)
        {
            this.edad = age;
        }

        public string getSexo()
        {
            return sexo;
        }

        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public string getDepartamento()
        {
            return departamento;
        }

        public void setDepartamento(string depa)
        {
            this.departamento = depa;
        }

        public string getAtencion()
        {
            return atencion;
        }

        public void setAtencion(string atencion)
        {
            this.atencion = atencion;
        }

    }
}
