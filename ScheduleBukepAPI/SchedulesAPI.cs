
using System.IO;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using ScheduleBukepAPI.apiDTO;

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
        return getAllFaculty(json);
    }

    //TODO: extract in DTOFactory.
    private static List<FacultyDTO> getAllFaculty(string json)
    {
        return JsonConvert.DeserializeObject<List<FacultyDTO>>(json);
    }
}
