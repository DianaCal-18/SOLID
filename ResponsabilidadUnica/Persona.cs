
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ResponsabilidadUnica
{
    public class Persona
    {
        private string nombre { get; set; }
        private int edad { get; set; }
        private string direccion { get; set; }
        private string correoElectronico { get; set; }
        public string Nombre
        {
            get { return nombre; }
            private set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            private set { edad = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            private set { direccion = value; }
        }

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            private set { correoElectronico = value; }
        }
        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }

    }


}
