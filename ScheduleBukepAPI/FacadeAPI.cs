﻿using System.Collections.Generic;
using ScheduleBukepAPI.apiDTO;

namespace ScheduleBukepAPI
{
    internal class FacadeAPI
    {
        private static ServiceFaculties serviceFaculties = new ServiceFaculties();
        private static ServiceSchedules serviceSchedules = new ServiceSchedules();

        public List<Courses> getCourses(string year, string idFilial, string idFaculty, string idsSpecialty)
        {
            return serviceFaculties.getCourses(year, idFilial, idFaculty, idsSpecialty);
        }

        public List<Faculty> getFaculties(string year, string idFilial)
        {
            return serviceFaculties.getFaculties(year, idFilial);
        }

        public List<GroupLesson> getGroupLessons(string dateFrom, string dateTo, string idsSheduleGroup)
        {
            return serviceSchedules.getGroupLessons(dateFrom, dateTo, idsSheduleGroup);
        }

        public List<Group> getGroups(string year, string idFilial, string idFaculty, string idCourse, string idsSpecialty)
        {
            return serviceFaculties.getGroups(year, idFilial, idFaculty, idCourse, idsSpecialty);
        }

        public List<Specialty> getSpecialtys(string year, string idFilial, string idFaculty)
        {
            return serviceFaculties.getSpecialtys(year, idFilial, idFaculty);
        }
    }
}