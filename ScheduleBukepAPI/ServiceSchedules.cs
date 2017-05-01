
using System.Collections.Generic;
using Newtonsoft.Json;
using ScheduleBukepAPI.apiDTO;
using ScheduleBukepAPI;

class ServiceSchedules : IServiceSchedules
{
   

    public List<GroupLessonDTO> getGroupLessons(string dateFrom, string dateTo, string idsSheduleGroup)
    {
        HttpHelper httpHelper = new HttpHelper();
        var parameters = new Dictionary<string, string>();
        parameters.Add("dateFrom", dateFrom);
        parameters.Add("dateTo", dateTo);

        string json = httpHelper.executePost("GetGroupLessons", parameters, idsSheduleGroup);
        return convertJSONToDTO<GroupLessonDTO>(json);
    }

    //TODO: extract in DTOFactory.
    private static List<T> convertJSONToDTO<T>(string json)
    {
        return JsonConvert.DeserializeObject<List<T>>(json);
    }
}
