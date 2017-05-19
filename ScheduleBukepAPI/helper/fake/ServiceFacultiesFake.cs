using System;
using System.Collections.Generic;
using Bukep.ShedulerApi.apiDTO;

namespace Bukep.ShedulerApi
{
    internal class ServiceFacultiesFake : IServiceFaculties
    {
        public List<Courses> GetCourses(string year, string idFilial, string idFaculty, string idsSpecialty)
        {
            List<Courses> courses = new List<Courses>
            {
                DTOBuilder.CreateCourses("Courses 1"),
                DTOBuilder.CreateCourses("Courses 2"),
                DTOBuilder.CreateCourses("Courses 3"),
                DTOBuilder.CreateCourses("Courses 4")
            };
            return courses;
        }

        public List<Faculty> GetFaculties(string year, string idFilial)
        {
            List<Faculty> faculty = new List<Faculty>
            {
                DTOBuilder.CreateFaculty("Faculty 1"),
                DTOBuilder.CreateFaculty("Faculty 2"),
                DTOBuilder.CreateFaculty("Faculty 3"),
                DTOBuilder.CreateFaculty("Faculty 4")
            };
            return faculty;
        }

        public List<Group> GetGroups(string year, string idFilial, string idFaculty, string idCourse, string idsSpecialty)
        {
            List<Group> groups = new List<Group>
            {
                DTOBuilder.CreateGroup("Group 1"),
                DTOBuilder.CreateGroup("Group 2"),
                DTOBuilder.CreateGroup("Group 3"),
                DTOBuilder.CreateGroup("Group 4")
            };
            return groups;
        }

        public List<Specialty> GetSpecialtys(string year, string idFilial, string idFaculty)
        {
            List<Specialty> specialtys = new List<Specialty>
            {
                DTOBuilder.CreateSpecialty("Specialty 1"),
                DTOBuilder.CreateSpecialty("Specialty 2"),
                DTOBuilder.CreateSpecialty("Specialty 3"),
                DTOBuilder.CreateSpecialty("Specialty 4")
            };
            return specialtys;
        }
    }
}