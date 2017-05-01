using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleBukepAPI.apiDTO
{
    class Specialty
    {
        public IList<int> idsSpecialty { get; set; }
        public string nameSpeciality { get; set; }
        public string idLevelQualification { get; set; }
        public string nameLevelQualification { get; set; }
    }
}
