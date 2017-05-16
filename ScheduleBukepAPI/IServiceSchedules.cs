using System.Collections.Generic;
using ScheduleBukepAPI.apiDTO;

namespace ScheduleBukepAPI
{
    interface IServiceSchedules
    {
        List<GroupLesson> GetGroupLessons(string dateFrom, string dateTo, string idsSheduleGroup);
    }
}