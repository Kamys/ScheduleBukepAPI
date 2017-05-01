using Newtonsoft.Json;
using System.Collections.Generic;

namespace ScheduleBukepAPI
{
    class JSONConvert
    {
        public static List<T> convertJSONToDTO<T>(string json)
        {
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
