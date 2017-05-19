using System;
using System.Collections.Generic;
using Bukep.ShedulerApi.apiDTO;

namespace Bukep.ShedulerApi
{
    internal class ServiceSchedulesFake : IServiceSchedules
    {
        public List<GroupLesson> GetGroupLessons(string idsSheduleGroup, string dateFrom, string dateTo)
        {
            List<GroupLesson> groupLessons = new List<GroupLesson>
            {
                DTOBuilder.CreateGroupLesson("GroupLesson 1"),
                DTOBuilder.CreateGroupLesson("GroupLesson 2"),
                DTOBuilder.CreateGroupLesson("GroupLesson 3"),
                DTOBuilder.CreateGroupLesson("GroupLesson 4")
            };
            return groupLessons;
        }
    }
}