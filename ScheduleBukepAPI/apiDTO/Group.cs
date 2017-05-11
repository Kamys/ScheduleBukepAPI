using System.Collections.Generic;

namespace ScheduleBukepAPI.apiDTO
{
    internal class Group
    {
        public IList<int> idsSchedulGroup { get; set; }
        public string nameGroup { get; set; }
        public string affixusNameGroup { get; set; }
        public string nameGroupOld { get; set; }
        public string idSemestr { get; set; }
        public string nameTypeShedule { get; set; }
        public string scheduleDateFrom { get; set; }
        public string scheduleDateTo { get; set; }
    }
}