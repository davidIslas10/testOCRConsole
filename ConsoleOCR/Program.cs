using Google.Cloud.Vision.V1;
using System;

using System;
using System.IO;
using System.Text;

namespace GoogleCloudSamples
{
    public class QuickStart
    {
        public static void Main(string[] args)
        {
            
            string clave = "";
            string resultado = "";
            
            // Instantiates a client
            var client = ImageAnnotatorClient.Create();
            // Load the image file into memory
            var image = Image.FromFile("hrisife.jpg");
            // Performs label detection on the image file
            var response = client.DetectText(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    //Console.WriteLine(annotation.Description);
                
                    
            //Aqui se obtiene la clave de elector de la credencial        
                    clave = annotation.Description;

                    resultado = clave.Substring(
                    clave.IndexOf("CLAVE DE ELECTOR "),
                    35);
                    Console.WriteLine(resultado);
                    Console.ReadKey();
            }
        }
    }
}

