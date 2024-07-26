using SegregacionInterfaces.Interfaces;

namespace SegregacionInterfaces.Clases
{
    public class MultiFunctionPrinter : IPrint
    {
        
        public void print(Document document)
        {
            Console.WriteLine($"Imprimiendo {document.name} en impresora multifuncional");
        }

        /* Este metodo (hablando de Scan) se pudo implementar de dos maneras:
           1. Como se hizo aqui, creando el metodo directamente en la clase donde se va a utilizar,
              evitando asi que otras clases tengan que implementarlo de manera innecesaria.
           2. Creando otra interfaz llamada IScan y haciendo que la clase MultiFunctionPrinter herede de ambas interfaces, 
              IPrint y IScan. De esta manera, cada clase solo implementa las interfaces relevantes a sus funcionalidades. */
        public void scan (Document document)
        {
            Console.WriteLine($"Escaneando {document.name} en impresora multifuncional");
        }
    }
}
