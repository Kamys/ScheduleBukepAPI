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
        public string IdFaculty { get; set; }
        public string Name { get; set; }
        public bool IsActiveSchedule { get; set; }
    }
}
