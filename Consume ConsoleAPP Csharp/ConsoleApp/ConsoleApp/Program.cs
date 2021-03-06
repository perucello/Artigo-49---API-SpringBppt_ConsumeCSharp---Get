using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; //importar biblioteca Client
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Testando Console Basico
            Console.WriteLine("Testando C# - EducaCiencia FastCode");
            Console.ReadLine();
            */

            /*
            //GetAPI_Java
            GetAPI_Java();
            Console.ReadKey();
            */

            
            // GetAPI_Java_2
            GetAPI_Java_2();
            Console.ReadKey();

        }


        //Get API Java SpringBoot simples WebClient
        public static void GetAPI_Java()
        {
            string endpointGet = "http://localhost:8080/api/JPA/clientes/";
            WebClient api = new WebClient();
            string content = api.DownloadString(endpointGet); //insere o endpoint Java
            Console.WriteLine(content);
        }

        //Get API Java SpringBoot - WebRequest
        public static void GetAPI_Java_2()
        {
            string endpointGet_2 = "http://localhost:8080/api/JPA/clientes/";
            WebRequest request = WebRequest.Create(endpointGet_2);
            request.Method = "GET";
            var response = request.GetResponse();

            if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
            {
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader streamReader = new StreamReader(stream);
                    string content = streamReader.ReadToEnd();
                    Console.WriteLine("GET" + content);
                }
            }
            else
            {
                Console.WriteLine("GET Fail");
            }
        }

        
    }
}
