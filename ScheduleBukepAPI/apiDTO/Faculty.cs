using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleBukepAPI.apiDTO
{
    /// <summary>
    ///  DTO from API method GetFaculties.
    /// </summary>
    public class Faculty
    {
        public string idFaculty { get; set; }
        public string name { get; set; }
        public bool isActiveSchedule { get; set; }
    }
}
