using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bukep.ShedulerApi
{
    static class JSONConvert
    {
        public static List<T> ConvertJSONToDTO<T>(string json)
        {
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
