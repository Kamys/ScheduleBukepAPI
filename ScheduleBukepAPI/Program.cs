using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleBukepAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create(
              "https://my.bukep.ru:447/api/Schedule/GetFaculties?year=2016&idFilial=1000");

            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine("Status = " + ((HttpWebResponse)response).StatusDescription);

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
             
            Console.WriteLine(responseFromServer);
              
            reader.Close();
            response.Close();
        }
    }
}
