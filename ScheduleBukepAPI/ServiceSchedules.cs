﻿
using System.Collections.Generic;
using ScheduleBukepAPI.apiDTO;
using ScheduleBukepAPI;

class ServiceSchedules : IServiceSchedules
{
   

    public List<GroupLesson> getGroupLessons(string dateFrom, string dateTo, string idsSheduleGroup)
    {
        HttpHelper httpHelper = new HttpHelper();
        var parameters = new Dictionary<string, string>();
        parameters.Add("dateFrom", dateFrom);
        parameters.Add("dateTo", dateTo);

        string json = httpHelper.executePost("GetGroupLessons", parameters, idsSheduleGroup);
        return JSONConvert.convertJSONToDTO<GroupLesson>(json);
    }
}
