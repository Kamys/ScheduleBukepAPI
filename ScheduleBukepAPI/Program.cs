using Newtonsoft.Json;
using ScheduleBukepAPI.apiDTO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleBukepAPI
{
    class Program
    {
        static  void Main(string[] args)
        {
            SchedulesAPI api = new SchedulesAPI();


            List<FacultyDTO> faculties = api.getFaculties("2016", "1000");
            faculties.ForEach(i => Console.Write("{0}\n", i.name));

            List<SpecialtyDTO> specialtys = api.getSpecialtys("2016", "1000", "9");
            specialtys.ForEach(i => Console.Write("{0}\n", i.nameSpeciality));

            List<CoursesDTO> courses = api.getCourses("2016", "1000", "9", "[387,1387]");
            courses.ForEach(i => Console.Write("{0}\n", i.nameCourse));
        }
    }
}
