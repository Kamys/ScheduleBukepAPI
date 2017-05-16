﻿
using System.Collections.Generic;
using ScheduleBukepAPI.apiDTO;
using ScheduleBukepAPI;

class ServiceSchedules : IServiceSchedules
{
   

    public List<GroupLesson> GetGroupLessons(string idsSheduleGroup, string dateFrom, string dateTo)
    {
        HttpHelper httpHelper = new HttpHelper();
        var parameters = new Dictionary<string, string>();
        parameters.Add("dateFrom", dateFrom);
        parameters.Add("dateTo", dateTo);

        string json = httpHelper.ExecutePost("GetGroupLessons", parameters, idsSheduleGroup);
        return JSONConvert.ConvertJSONToDTO<GroupLesson>(json);
    }
}
