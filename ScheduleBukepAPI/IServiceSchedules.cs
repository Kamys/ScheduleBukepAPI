using System.Collections.Generic;
using ScheduleBukepAPI;

interface IServiceSchedules
{
    List<GroupLessonDTO> getGroupLessons(string dateFrom, string dateTo, string idsSheduleGroup);
}