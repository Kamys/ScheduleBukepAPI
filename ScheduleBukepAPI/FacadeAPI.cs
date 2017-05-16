using System.Collections.Generic;
using ScheduleBukepAPI.apiDTO;

namespace ScheduleBukepAPI
{
    public class FacadeAPI
    {
        private static ServiceFaculties serviceFaculties = new ServiceFaculties();
        private static ServiceSchedules serviceSchedules = new ServiceSchedules();

        private const string year = "2016";
        private const string idFilial = "1000";

        public List<Faculty> GetFaculties()
        {
            return serviceFaculties.GetFaculties(year, idFilial);
        }

        public List<Specialty> GetSpecialtys(string idFaculty)
        {
            return serviceFaculties.GetSpecialtys(year, idFilial, idFaculty);
        }

        public List<Group> GetGroups(string idFaculty, string idCourse, string idsSpecialty)
        {
            return serviceFaculties.GetGroups(year, idFilial, idFaculty, idCourse, idsSpecialty);
        }

        public List<Courses> GetCourses(string idFaculty, string idsSpecialty)
        {
            return serviceFaculties.GetCourses(year, idFilial, idFaculty, idsSpecialty);
        }

        public List<GroupLesson> GetGroupLessons(string idsSheduleGroup, string dateFrom, string dateTo)
        {
            return serviceSchedules.GetGroupLessons(idsSheduleGroup, dateFrom, dateTo);
        }
    }
}