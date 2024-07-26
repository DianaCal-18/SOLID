using SegregacionInterfaces.Clases;
using SegregacionInterfaces.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        Document document = new Document { name = "Documento 666", description="Descripcion Doc"};

        /* Aqui se cumple tanto el principio de ISP (Segregacion de Interfaces) como el de SRP (Responsabilidad Unica).
       En primer lugar, el principio de ISP se cumple porque las clases solo implementan los metodos que van a utilizar.
       En segundo lugar, el principio de SRP se cumple porque la interfaz IPrint inicialmente tenia dos responsabilidades:
       imprimir y escanear. Al refactorizar la interfaz, cada una quedo con una unica responsabilidad.
       De esta manera, hemos cumplido dos principios que se estaban violando anteriormente. */

        //Probando metodo de la impresora simple
        IPrint simplePrinter = new SimplePrinter();
        simplePrinter.print(document);

        //Probando metodo de la impresora multifuncional
        MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
        multiFunctionPrinter.print(document);
        multiFunctionPrinter.scan(document);
    }
}