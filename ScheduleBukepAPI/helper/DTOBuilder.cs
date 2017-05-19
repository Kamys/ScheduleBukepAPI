using System;
using Bukep.ShedulerApi.apiDTO;

namespace Bukep.ShedulerApi
{
    internal static class DTOBuilder
    {
        internal static Courses CreateCourses(string name)
        {
            return new Courses()
            {
                NameCourse = name
            };
        }

        internal static Faculty CreateFaculty(string name)
        {
            return new Faculty()
            {
                Name = name
            };
        }

        internal static GroupLesson CreateGroupLesson(string name)
        {
            return new GroupLesson()
            {
                NameLesson = name
            };
        }

        internal static Group CreateGroup(string name)
        {
            return new Group()
            {
                NameGroup = name
            };
        }

        internal static Specialty CreateSpecialty(string name)
        {
            return new Specialty()
            {
                NameSpeciality = name
            };
        }
    }
}