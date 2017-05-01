
using System.Collections.Generic;
using Newtonsoft.Json;
using ScheduleBukepAPI.apiDTO;
using ScheduleBukepAPI;

class ServiceSchedules
{
   

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
