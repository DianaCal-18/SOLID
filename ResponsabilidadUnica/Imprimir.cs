﻿
namespace ResponsabilidadUnica
{ 
    
    public class Imprimir 
    {
        //metodo para imprimir datos
        public void ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"Dirección: {persona.Direccion}");
            Console.WriteLine($"Correo electrónico: {persona.CorreoElectronico}");
        }
    }
}
