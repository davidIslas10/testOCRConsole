using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace ConsoleOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\UDI005\source\Repos\PruebaOCR\PruebaOCR\getEdocuentaBajas.PNG";
            string text = "";
            try
            {
                using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                {
                    using(var imag = Pix.LoadFromFile(path))
                    {
                        using(var page = engine.Process(imag))
                        {
                            text = page.GetText();
                        }
                    }

                }                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
