using SegregacionInterfaces.Clases;
using SegregacionInterfaces.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        Document document = new Document { name = "Documento 666", description="Descripcion Doc"};

        //Probando metodo de la impresora simple
        IPrint simplePrinter = new SimplePrinter();
        simplePrinter.print(document);

        //Probando metodo de la impresora multifuncional
        MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
        multiFunctionPrinter.print(document);
        multiFunctionPrinter.scan(document);
    }
}