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


            List<Faculty> faculties = api.getFaculties("2016", "1000");
            faculties.ForEach(i => Console.WriteLine("{0}", i.name));

            List<Specialty> specialtys = api.getSpecialtys("2016", "1000", "9");
            foreach (Specialty specialty in specialtys)
            {
                Console.Write("{0}", specialty.nameSpeciality);
                string outId = string.Join(",", specialty.idsSpecialty.ToArray());
                Console.WriteLine(" id = " + outId);
            }

            List<Courses> courses = api.getCourses("2016", "1000", "9", "[387,1387]");
            courses.ForEach(i => Console.WriteLine("{0}", i.nameCourse));

            List<GroupDTO> groups = api.getGroups("2016", "1000", "10083", "3", "[1417]");
            groups.ForEach(i => Console.WriteLine("{0}", i.nameGroup));

            List<GroupLessonDTO> groupLessons = api.getGroupLessons("2017-02-10", "2017-02-10", "[5200,5201]");
            groupLessons.ForEach(i => Console.WriteLine("{0}", i.nameDiscipline));
        }
    }
}
