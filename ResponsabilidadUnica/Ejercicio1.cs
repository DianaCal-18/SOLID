
namespace ResponsabilidadUnica
{
    public class Ejercicio1
    {
       // 1-  Identificar y explicar por que se esta violacioletando el principio de SRP.

       /* 
        * SRP Establece que la clase debe de tener una unica responsabilidad, en este caso esta
        violentado porque en una unica clase "persona" hay varias responsabilidades como almacenar los datos de la persona,
        metodo para enviar correos electronicos y metodo para imprimir datos.
       */
        public class Persona
        {
            private string nombre;
            private int edad;
            private string direccion;
            private string correoElectronico;

            public void EnviarCorreoElectronico(string mensaje)
            {
                // Lógica para enviar correo electrónico
            }

            public void ImprimirDatos()
            {
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Edad: {edad}");
                Console.WriteLine($"Dirección: {direccion}");
                Console.WriteLine($"Correo electrónico: {correoElectronico}");
            }
        }

    }
}
