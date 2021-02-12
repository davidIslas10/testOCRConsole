using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Google.Cloud.Vision.V1;
using Google.Protobuf;

using System;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GoogleCloudSamples
{
    public class QuickStart
    {
        public static void Main(string[] args)
        {
            var image = Image.FromFile("hrisife.jpg");
            string clave = "";
            string curp = "";
            
            string resultado = "";
            string resultado2 = "";
           

            // Instantiates a client
            var client = ImageAnnotatorClient.Create();
            // Load the image file into memory

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

                    //Aqui se obtiene la curp de la credencial        
                    curp = annotation.Description;

                    resultado2 = curp.Substring(
                    curp.IndexOf("CURP "),
                    24);



                    Console.WriteLine(resultado);
                    Console.WriteLine(resultado2);
               

                Console.ReadKey();
            }



        }
       
    }
}

