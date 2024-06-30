using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Registro

    {

        string nombre { get; set; }
        string primerApellido {  get; set; }
        string segundoApellido { get; set; }
        string correo {  get; set; }
        string nacionalidad {  get; set; }
        string estadoCivil {  get; set; }


        public Registro(string nombre, string primerApellido, string segundoApellido, string correo, string nacionalidad , string estadoCivil)
        {
            {
               
                this.nombre = nombre;
                this.primerApellido = primerApellido;
                this.segundoApellido= segundoApellido;
                this.correo = correo;
                this.nacionalidad = nacionalidad;
                this.estadoCivil = estadoCivil; 
             
            }


        }

        public override string ToString()
        {
            return $"Nombre:{nombre}, primerApellido:{primerApellido}, segundoApellido:{segundoApellido}, correo:{correo}, nacionalidad:{nacionalidad}, estadoCivil:{estadoCivil}";
        }

    }
}
