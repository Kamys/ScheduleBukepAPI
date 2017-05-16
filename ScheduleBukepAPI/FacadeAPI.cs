using System.Collections.Generic;
using ScheduleBukepAPI.apiDTO;

namespace ScheduleBukepAPI
{
    public class FacadeAPI
    {
        private static ServiceFaculties serviceFaculties = new ServiceFaculties();
        private static ServiceSchedules serviceSchedules = new ServiceSchedules();

        public List<Courses> GetCourses(string year, string idFilial, string idFaculty, string idsSpecialty)
        {
            return serviceFaculties.GetCourses(year, idFilial, idFaculty, idsSpecialty);
        }

        public List<Faculty> GetFaculties(string year, string idFilial)
        {
            return serviceFaculties.GetFaculties(year, idFilial);
        }

        public List<GroupLesson> GetGroupLessons(string dateFrom, string dateTo, string idsSheduleGroup)
        {
            return serviceSchedules.GetGroupLessons(dateFrom, dateTo, idsSheduleGroup);
        }

        public List<Group> GetGroups(string year, string idFilial, string idFaculty, string idCourse, string idsSpecialty)
        {
            return serviceFaculties.GetGroups(year, idFilial, idFaculty, idCourse, idsSpecialty);
        }

        public List<Specialty> GetSpecialtys(string year, string idFilial, string idFaculty)
        {
            return serviceFaculties.GetSpecialtys(year, idFilial, idFaculty);
        }
    }
}