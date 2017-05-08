using System.Collections.Generic;
using ScheduleBukepAPI;

interface IServiceSchedules
{
    List<GroupLesson> getGroupLessons(string dateFrom, string dateTo, string idsSheduleGroup);
}