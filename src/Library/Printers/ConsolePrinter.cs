using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(IPrintable objectToPrint)
        {
            Console.WriteLine(objectToPrint.GetTextToPrint());
        }
    }
}