using ScheduleBukepAPI.apiDTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScheduleBukepAPI
{
    class MainStart
    {
        static  void Main(string[] args)
        {
            FacadeAPI api = new FacadeAPI();

            List<Faculty> faculties = api.GetFaculties();
            faculties.ForEach(i => Console.WriteLine("{0}", i.Name));

            List<Specialty> specialtys = api.GetSpecialtys("9");
            foreach (Specialty specialty in specialtys)
            {
                Console.Write("{0}", specialty.NameSpeciality);
                string outId = string.Join(",", specialty.IdsSpecialty.ToArray());
                Console.WriteLine(" id = " + outId);
            }

            List<Courses> courses = api.GetCourses("9", "[387,1387]");
            courses.ForEach(i => Console.WriteLine("{0}", i.NameCourse));

            List<Group> groups = api.GetGroups("10083", "3", "[1417]");
            groups.ForEach(i => Console.WriteLine("{0}", i.NameGroup));

            List<GroupLesson> groupLessons = api.GetGroupLessons("[5200,5201]", "2017-02-10", "2017-02-10");
            groupLessons.ForEach(i => Console.WriteLine("{0}", i.NameDiscipline));
        }
    }
}
