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
            SchedulesAPI api = new SchedulesAPI();
            
            
            //List<FacultyDTO> faculties = api.getFaculties("2016","1000");
            //faculties.ForEach(i => Console.Write("{0}\n",i.name));

            List<SpecialtyDTO> specialtys = api.getSpecialtys("2016", "1000","9");
            specialtys.ForEach(i => Console.Write("{0}\n", i.nameSpeciality));
        }


        private static void showFaculty(FacultyDTO f)
        {
            Console.WriteLine("Faculty\n id = {0}\n name = {1}\n isActive = {2}", f.idFaculty, f.name, f.isActiveSchedule);
        }
    }
}
