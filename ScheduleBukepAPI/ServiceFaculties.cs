using ScheduleBukepAPI.apiDTO;
using System.Collections.Generic;

namespace ScheduleBukepAPI
{
    class ServiceFaculties : IServiceFaculties
    {
        public List<Faculty> GetFaculties(string year, string idFilial)
        {
            HttpHelper httpHelper = new HttpHelper();
            var parameters = new Dictionary<string, string>
            {
                { "year", year },
                { "idFilial", idFilial }
            };
            string json = httpHelper.ExecuteGet("GetFaculties", parameters);
            return JSONConvert.ConvertJSONToDTO<Faculty>(json);
        }

        public List<Specialty> GetSpecialtys(string year, string idFilial, string idFaculty)
        {
            HttpHelper httpHelper = new HttpHelper();
            var parameters = new Dictionary<string, string>
            {
                { "year", year },
                { "idFilial", idFilial },
                { "idFaculty", idFaculty }
            };
            string json = httpHelper.ExecuteGet("GetSpecialtys", parameters);
            return JSONConvert.ConvertJSONToDTO<Specialty>(json);
        }

        public List<Courses> GetCourses(string year, string idFilial, string idFaculty, string idsSpecialty)
        {
            HttpHelper httpHelper = new HttpHelper();
            var parameters = new Dictionary<string, string>
            {
                { "year", year },
                { "idFilial", idFilial },
                { "idFaculty", idFaculty }
            };
            string json = httpHelper.ExecutePost("GetCourses", parameters, idsSpecialty);
            return JSONConvert.ConvertJSONToDTO<Courses>(json);
        }

        public List<Group> GetGroups(string year, string idFilial, string idFaculty, string idCourse, string idsSpecialty)
        {
            HttpHelper httpHelper = new HttpHelper();
            var parameters = new Dictionary<string, string>
            {
                { "year", year },
                { "idFilial", idFilial },
                { "idFaculty", idFaculty },
                { "idCourse", idCourse }
            };
            string json = httpHelper.ExecutePost("GetGroups", parameters, idsSpecialty);
            return JSONConvert.ConvertJSONToDTO<Group>(json);
        }
    }

}
