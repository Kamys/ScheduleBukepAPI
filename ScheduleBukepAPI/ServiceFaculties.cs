using Bukep.ShedulerApi.apiDTO;
using System.Collections.Generic;

namespace Bukep.ShedulerApi
{
    class ServiceFaculties : IServiceFaculties
    {
        public List<Faculty> GetFaculties(string year, string idFilial)
        {
            var parameters = new Dictionary<string, string>
            {
                { "year", year },
                { "idFilial", idFilial }
            };
            string json = HttpRequstHelper.ExecuteGet("GetFaculties", parameters);
            return JSONConvert.ConvertJSONToDTO<Faculty>(json);
        }

        public List<Specialty> GetSpecialtys(string year, string idFilial, string idFaculty)
        {
            var parameters = new Dictionary<string, string>
            {
                { "year", year },
                { "idFilial", idFilial },
                { "idFaculty", idFaculty }
            };
            string json = HttpRequstHelper.ExecuteGet("GetSpecialtys", parameters);
            return JSONConvert.ConvertJSONToDTO<Specialty>(json);
        }

        public List<Courses> GetCourses(string year, string idFilial, string idFaculty, string idsSpecialty)
        {
            var parameters = new Dictionary<string, string>
            {
                { "year", year },
                { "idFilial", idFilial },
                { "idFaculty", idFaculty }
            };
            string json = HttpRequstHelper.ExecutePost("GetCourses", parameters, idsSpecialty);
            return JSONConvert.ConvertJSONToDTO<Courses>(json);
        }

        public List<Group> GetGroups(string year, string idFilial, string idFaculty, string idCourse, string idsSpecialty)
        {
            var parameters = new Dictionary<string, string>
            {
                { "year", year },
                { "idFilial", idFilial },
                { "idFaculty", idFaculty },
                { "idCourse", idCourse }
            };
            string json = HttpRequstHelper.ExecutePost("GetGroups", parameters, idsSpecialty);
            return JSONConvert.ConvertJSONToDTO<Group>(json);
        }
    }

}
