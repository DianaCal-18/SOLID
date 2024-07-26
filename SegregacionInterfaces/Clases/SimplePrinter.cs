using SegregacionInterfaces.Interfaces;

namespace SegregacionInterfaces.Clases
{
    public class SimplePrinter : IPrint
    {
        public void print(Document document)
        {
            Console.WriteLine($"Imprimiendo {document.name} en impresora simple");
        }
    }
}
