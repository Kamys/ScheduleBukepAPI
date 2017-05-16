using System.Collections.Generic;

namespace ScheduleBukepAPI.apiDTO
{
    public class Specialty
    {
        public IList<int> idsSpecialty { get; set; }
        public string nameSpeciality { get; set; }
        public string idLevelQualification { get; set; }
        public string nameLevelQualification { get; set; }
    }
}
