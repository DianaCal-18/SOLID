using SegregacionInterfaces.Interfaces;

namespace SegregacionInterfaces.Clases
{
    public class MultiFunctionPrinter : IPrint
    {
        public void print(Document document)
        {
            Console.WriteLine($"Imprimiendo {document.name} en impresora multifuncional");
        }

        public void scan (Document document)
        {
            Console.WriteLine($"Escaneando {document.name} en impresora multifuncional");
        }
    }
}
