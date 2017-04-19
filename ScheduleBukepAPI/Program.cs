using Newtonsoft.Json;
using ScheduleBukepAPI.apiDTO;
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
            List<FacultyDTO> Faculties = getAllFaculty();
            foreach (FacultyDTO f in Faculties)
            {
                showFaculty(f);
            }
        }

        /// <summary>
        /// Use method GetFaculties for get JSON.
        /// </summary>
        /// <returns>JSON with faculties</returns>
        private static string getJsonFromAPI()
        {
            WebRequest request = WebRequest.Create(
                          "https://my.bukep.ru:447/api/Schedule/GetFaculties?year=2016&idFilial=1000");

            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string json = reader.ReadToEnd();

            reader.Close();
            response.Close();

            return json;
        }

        private static List<FacultyDTO> getAllFaculty()
        {
            string json = getJsonFromAPI();

            return JsonConvert.DeserializeObject<List<FacultyDTO>>(json);
        }

        private static void showFaculty(FacultyDTO f)
        {
            Console.WriteLine("Faculty\n id = {0}\n name = {1}\n isActive = {2}", f.idFaculty, f.name, f.isActiveSchedule);
        }
    }
}
