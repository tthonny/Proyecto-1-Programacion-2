using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    public class Factura
    {


        public int materiasCan { get; set; }
        public string tipodePAGO { get; set; }

        DateTime date1 = new DateTime(2024, 6, 30);


        public void Calculofactura()
        {
            int precioMateria = 50000;


            int subtotal = materiasCan * precioMateria;

            double iva = 0.13 * subtotal;

            double total = iva + subtotal;

            Console.Clear();

            Console.WriteLine("Precio por materia es de:  $"+ precioMateria);
            Console.WriteLine("Precio por las materias ingresadas sin Iva es de $"+ subtotal);
            Console.WriteLine("Iva del 13% es igual a  $"+ iva);
            Console.WriteLine("Precio total  por las materias ingresadas es de = $" + total);
            Console.WriteLine("El metodo de pago ingresado es=  " + tipodePAGO);
            Console.WriteLine(date1.ToString());



        }

    }
}
