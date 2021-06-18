using System;

namespace DatosPersona 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.Write("Ingrese el número de cedula: ");
            string cedula = Console.ReadLine();
            int cedula1 = int.Parse(cedula);
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            var apellido = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);
            Console.Write("Ingrese su sexo: ");
            var sexo = Console.ReadLine();
            Console.Write("Ingrese su estatura: ");
            string estatura = Console.ReadLine();
            float estatura1 = float.Parse(estatura);
            Console.Write("Ingrese la ciudad de nacimiento: ");
            var ciudadNacimiento = Console.ReadLine();
            Console.Write("Ingrese la ciudad de residencia: ");
            var ciudadResidencia = Console.ReadLine();
            Console.Write("Ingrese número de celular: ");
            string celular = Console.ReadLine();
            int celular1 = int.Parse(celular);
            Console.Write("Ingrese el correo: ");
            var correo = Console.ReadLine();

            var persona = new Persona();

            persona.cedula = cedula1;
            persona.nombre = nombre;
            persona.apellido = apellido;
            persona.edad = edad1;
            persona.sexo = sexo;
            persona.estatura = estatura1;
            persona.ciudadNacimiento = ciudadNacimiento;
            persona.ciudadResidencia = ciudadResidencia;
            persona.celular = celular1;
            persona.correo = correo;

            Console.WriteLine("Datos ingresados");
            Console.Write("Cedula: " + persona.cedula + "\n");
            Console.Write("Nombre: " + persona.nombre + "\n");
            Console.Write("Apellido: " + persona.apellido + "\n");
            Console.Write("Edad: " + persona.edad + "\n");
            Console.Write("Sexo: " + persona.sexo + "\n");
            Console.Write("Estatura: " + persona.estatura + "\n");
            Console.Write("Ciudad de nacimiento: " + persona.ciudadNacimiento + "\n");
            Console.Write("Ciudad de residencia" + persona.ciudadResidencia + "\n");
            Console.Write("Número de celular: " + persona.celular + "\n");
            Console.Write("Correo electrónico: " + persona.correo + "\n");
            Console.Write("Gracias por su participacion... Digite cualquier tecla para finalizar. ");
            Console.ReadKey();
        }
    }
}
