
using System.IO;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using ScheduleBukepAPI.apiDTO;
using System;
using ScheduleBukepAPI;

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
        return convertJSONToDTO<FacultyDTO>(json);
    }

    internal List<SpecialtyDTO> getSpecialtys(string year, string idFilial, string idFaculty)
    {
        HttpHelper httpHelper = new HttpHelper();
        var parameters = new Dictionary<string, string>();
        parameters.Add("year", year);
        parameters.Add("idFilial", idFilial);
        parameters.Add("idFaculty", idFaculty);
        string json = httpHelper.executeGet("GetSpecialtys", parameters);
        return convertJSONToDTO<SpecialtyDTO>(json);
    }

    internal List<CoursesDTO> getCourses(string year, string idFilial, string idFaculty, string idsSpecialty)
    {
        HttpHelper httpHelper = new HttpHelper();
        var parameters = new Dictionary<string, string>();
        parameters.Add("year", year);
        parameters.Add("idFilial", idFilial);
        parameters.Add("idFaculty", idFaculty);

        string json = httpHelper.executePost("GetCourses", parameters, idsSpecialty);
        return convertJSONToDTO<CoursesDTO>(json);
    }

    internal List<GroupLessonDTO> getGroupLessons(string dateFrom, string dateTo, string idsSheduleGroup)
    {
        HttpHelper httpHelper = new HttpHelper();
        var parameters = new Dictionary<string, string>();
        parameters.Add("dateFrom", dateFrom);
        parameters.Add("dateTo", dateTo);

        string json = httpHelper.executePost("GetGroupLessons", parameters, idsSheduleGroup);
        return convertJSONToDTO<GroupLessonDTO>(json);
    }

    internal List<GroupDTO> getGroups(string year, string idFilial, string idFaculty, string idCourse, string idsSpecialty)
    {
        HttpHelper httpHelper = new HttpHelper();
        var parameters = new Dictionary<string, string>();
        parameters.Add("year", year);
        parameters.Add("idFilial", idFilial);
        parameters.Add("idFaculty", idFaculty);
        parameters.Add("idCourse", idCourse);

        string json = httpHelper.executePost("GetGroups", parameters, idsSpecialty);
        return convertJSONToDTO<GroupDTO>(json);
    }

    //TODO: extract in DTOFactory.
    private static List<T> convertJSONToDTO<T>(string json)
    {
        return JsonConvert.DeserializeObject<List<T>>(json);
    }
}
