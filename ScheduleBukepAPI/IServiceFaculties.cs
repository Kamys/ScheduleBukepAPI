using System.Collections.Generic;
using ScheduleBukepAPI.apiDTO;

namespace ScheduleBukepAPI
{
    interface IServiceFaculties
    {
        List<Courses> getCourses(string year, string idFilial, string idFaculty, string idsSpecialty);
        List<Faculty> getFaculties(string year, string idFilial);
        List<GroupDTO> getGroups(string year, string idFilial, string idFaculty, string idCourse, string idsSpecialty);
        List<Specialty> getSpecialtys(string year, string idFilial, string idFaculty);
    }
}