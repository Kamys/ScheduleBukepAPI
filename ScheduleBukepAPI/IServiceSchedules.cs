using System.Collections.Generic;
using ScheduleBukepAPI.apiDTO;

namespace ScheduleBukepAPI
{
    interface IServiceSchedules
    {
        List<GroupLesson> getGroupLessons(string dateFrom, string dateTo, string idsSheduleGroup);
    }
}