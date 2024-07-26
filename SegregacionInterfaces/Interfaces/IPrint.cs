using SegregacionInterfaces.Clases;

namespace SegregacionInterfaces.Interfaces
{
    /* Cree una interfaz llamada IPrint con el unico metodo que tenian en comun ambas clases,
      y en la clase MultiFunctionPrinter cree el metodo de scan, para que asi se cumpla el principio de ISP y
      no obligar a la clase SimplePrinter a tener un metodo que no va a utilizar.
     */
    public interface IPrint
    {
        void print(Document document);
    }
}
