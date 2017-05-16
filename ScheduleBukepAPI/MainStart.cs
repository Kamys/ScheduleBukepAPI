using Bukep.ShedulerApi.apiDTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bukep.ShedulerApi
{
    class MainStart
    {
        private static FacadeAPI api = new FacadeAPI();

        static void Main(string[] args)
        {
            Faculty selectedFaculty = SelectFaculty();
            Specialty selectedSpecialty = SelectedSpecialty(selectedFaculty);
            Courses selectedCourse = SelectedCourse(selectedFaculty, selectedSpecialty);
            Group selectedGroup = SelectedGroup(selectedFaculty, selectedSpecialty, selectedCourse);

            ShowGroupLessons(selectedGroup);
        }

        private static void ShowGroupLessons(Group selectedGroup)
        {
            List<GroupLesson> groupLessons = api.GetGroupLessons(
                            ConvertIdsToString(selectedGroup.IdsSchedulGroup),
                            "2017-05-15",
                            "2017-05-15"
                            );
            for (int i = 0; i < groupLessons.Count; i++)
            {
                GroupLesson groupLesson = groupLessons[i];
                Console.WriteLine("===========================================");
                Console.WriteLine(
                    "NameTypeShedule - " + groupLesson.NameTypeShedule + "\n" +
                    "NameTypeWeek - " + groupLesson.NameTypeWeek + "\n" +
                    "NameDay - " + groupLesson.NameDay + "\n" +
                    "NameLesson - " + groupLesson.NameLesson + "\n" +
                    "TypeLesson - " + groupLesson.TypeLesson + "\n" +
                    "DateLesson - " + groupLesson.DateLesson + "\n" +
                    "TimeStartLesson - " + groupLesson.TimeStartLesson + "\n" +
                    "TimeEndLesson - " + groupLesson.TimeEndLesson + "\n" +
                    "NameAuditory - " + groupLesson.NameAuditory + "\n" +
                    "IdTeacher - " + groupLesson.IdTeacher + "\n" +
                    "FioTeacher - " + groupLesson.FioTeacher + "\n" +
                    "NameDiscipline - " + groupLesson.NameDiscipline
                    );
            }
        }

        private static Group SelectedGroup(Faculty selectedFaculty, Specialty selectedSpecialty, Courses selectedCourse)
        {
            List<Group> groups = api.GetGroups(
                selectedFaculty.IdFaculty,
                selectedCourse.IdCourse,
                ConvertIdsToString(selectedSpecialty.IdsSpecialty)
                );
            for (int i = 0; i < groups.Count; i++)
            {
                Group group = groups[i];
                Console.WriteLine("{0}. {1} = {2}", i, group.NameGroup, ConvertIdsToString(group.IdsSchedulGroup));
            }

            int numberGroup = AskNumber();

            Group selectedGroup = groups[numberGroup];
            return selectedGroup;
        }

        private static Courses SelectedCourse(Faculty selectedFaculty, Specialty selectedSpecialty)
        {
            string IdsSpecialty = ConvertIdsToString(selectedSpecialty.IdsSpecialty);
            Console.WriteLine("IdsSpecialty = " + IdsSpecialty);

            List<Courses> courses = api.GetCourses(selectedFaculty.IdFaculty, IdsSpecialty);
            for (int i = 0; i < courses.Count; i++)
            {
                Courses course = courses[i];
                Console.WriteLine("{0}. {1} = {2}", i, course.NameCourse, course.IdCourse);
            }
            int numberCourses = AskNumber();

            Courses selectedCourse = courses[numberCourses];
            return selectedCourse;
        }

        private static Specialty SelectedSpecialty(Faculty selectedFaculty)
        {
            List<Specialty> specialtys = api.GetSpecialtys(selectedFaculty.IdFaculty);

            for (int i = 0; i < specialtys.Count; i++)
            {
                Specialty specialty = specialtys[i];
                string Ids = ConvertIdsToString(specialty.IdsSpecialty);
                Console.WriteLine("{0}. {1} id = {2}", i, specialty.NameSpeciality, Ids);
            }
            int number = AskNumber();
            Specialty selectedSpecialty = specialtys[number];
            return selectedSpecialty;
        }

        private static Faculty SelectFaculty()
        {

            List<Faculty> faculties = api.GetFaculties();
            for (int i = 0; i < faculties.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, faculties[i].Name);
            }

            int numberFaculty = AskNumber();

            return faculties[numberFaculty];
        }

        private static string ConvertIdsToString(IList<int> ids)
        {
            string result = string.Join(",", ids.ToArray());
            result = "[" + result + "]";
            return result;
        }

        private static int AskNumber()
        {
            Console.WriteLine("Введите число:");
            return System.Convert.ToInt32(Console.ReadLine());
        }
    }
}
