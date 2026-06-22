using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample.Documents
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Excel Document...");
        }
    }
}