using FactoryMethodPatternExample.Documents;
using FactoryMethodPatternExample.Factories;

namespace FactoryMethodPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordDocumentFactory();
            IDocument word = wordFactory.CreateDocument();
            word.Open();

            DocumentFactory pdfFactory = new PdfDocumentFactory();
            IDocument pdf = pdfFactory.CreateDocument();
            pdf.Open();

            DocumentFactory excelFactory = new ExcelDocumentFactory();
            IDocument excel = excelFactory.CreateDocument();
            excel.Open();

            Console.ReadKey();
        }
    }
}