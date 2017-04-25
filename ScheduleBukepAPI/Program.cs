using ScheduleBukepAPI.apiDTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScheduleBukepAPI
{
    class Program
    {
        static  void Main(string[] args)
        {
            SchedulesAPI api = new SchedulesAPI();


            List<FacultyDTO> faculties = api.getFaculties("2016", "1000");
            faculties.ForEach(i => Console.WriteLine("{0}", i.name));

            List<SpecialtyDTO> specialtys = api.getSpecialtys("2016", "1000", "9");
            foreach(SpecialtyDTO specialty in specialtys)
            {
                Console.Write("{0}", specialty.nameSpeciality);
                string outId = string.Join(",", specialty.idsSpecialty.ToArray());
                Console.WriteLine(" id = " + outId);
            }

            List<CoursesDTO> courses = api.getCourses("2016", "1000", "9", "[387,1387]");
            courses.ForEach(i => Console.WriteLine("{0}", i.nameCourse));


        }
    }
}
