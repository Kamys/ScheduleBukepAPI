
using System.IO;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using ScheduleBukepAPI.apiDTO;
using System;

class SchedulesAPI
{
    /// <summary>
    /// Use method GetFaculties for get JSON.
    /// </summary>
    /// <returns>JSON with faculties</returns>
    public List<FacultyDTO> getFaculties(string year, string idFilial)
    {
        HttpHelper httpHelper = new HttpHelper();
        var parameters = new Dictionary<string, string>();
        parameters.Add("year", year);
        parameters.Add("idFilial", idFilial);
        string json = httpHelper.executeGet("GetFaculties", parameters);
        return getAllFaculty<FacultyDTO>(json);
    }

    internal List<SpecialtyDTO> getSpecialtys(string year, string idFilial, string idFaculty)
    {
        HttpHelper httpHelper = new HttpHelper();
        var parameters = new Dictionary<string, string>();
        parameters.Add("year", year);
        parameters.Add("idFilial", idFilial);
        parameters.Add("idFaculty", idFaculty);
        string json = httpHelper.executeGet("GetSpecialtys", parameters);
        return getAllFaculty<SpecialtyDTO>(json);
    }

    internal List<CoursesDTO> getCourses(string year, string idFilial, string idFaculty, string idsSpecialty)
    {
        HttpHelper httpHelper = new HttpHelper();
        var parameters = new Dictionary<string, string>();
        parameters.Add("year", year);
        parameters.Add("idFilial", idFilial);
        parameters.Add("idFaculty", idFaculty);

        var parametersForPost = new Dictionary<string, string>();
        parametersForPost.Add("idsSpecialty", idsSpecialty);
        string json = httpHelper.executePost("GetCourses", parameters, parametersForPost);
        return getAllFaculty<CoursesDTO>(json);
    }

    //TODO: extract in DTOFactory.
    private static List<T> getAllFaculty<T>(string json)
    {
        return JsonConvert.DeserializeObject<List<T>>(json);
    }
}
