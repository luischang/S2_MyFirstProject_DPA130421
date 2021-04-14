using System;
using System.Collections.Generic;
using System.Linq;

namespace S2_MyFirstProject.ConsoleProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nombreCurso = "Desarrollo de Ambiente Web 2021-1";
            int edad = 20;
            double monto = 350.50;
            string salario = "Mil dólares";

            var nuevaEdad = "Veinte";

            string detalleEdad = String.Empty;

            List<Persona> listado = new List<Persona>();

            Persona per1 = new Persona();
            per1.dni = "12345678";
            per1.nombreCompleto = "Jefferon Farfan";
            per1.telefono = 54824545;

            Persona per2 = new Persona("77885544","Paolo Guerrero",998545844);

            listado.Add(per1);
            listado.Add(per2);
            listado.Add(new Persona("88556699", "Raul Ruidiaz", 5255211));

            detalleEdad = edad > 17 ? "Es mayor de edad" : "Es menor de edad";
           
            foreach (var item in listado)
            {
                Console.WriteLine(item.dni + " " + item.nombreCompleto + " " + item.telefono);
            }

            var busqueda = listado.Where(options=> options.dni== "12345678").FirstOrDefault();

            Console.WriteLine("La búsqueda encontró a: " + busqueda.nombreCompleto);
        }
    }
}
