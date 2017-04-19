using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


class HttpHelper
{
    private const string urlApi = "https://my.bukep.ru:447/api/Schedule";

    public string executeGet(string nameMethod, Dictionary<string, string> parameter)
    {

        string urlParameter = createUrlParameter(parameter);
        string url = String.Format("{0}/{1}?{2}", urlApi, nameMethod, urlParameter);
        Console.WriteLine("URL = " + url);
        WebRequest request = WebRequest.Create(url);

        request.Credentials = CredentialCache.DefaultCredentials;
        WebResponse response = request.GetResponse();

        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string json = reader.ReadToEnd();

        reader.Close();
        response.Close();
        json = fixForArrayString(json);
        return json;
    }

    /// <summary>
    /// Fix json array value. Of "idsSpecialty": [407,1407] in "idsSpecialty": "[407,1407]".
    /// This need for correct parsing JSON.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    private string fixForArrayString(string json)
    {
        throw new NotImplementedException();
    }

    private string createUrlParameter(Dictionary<string, string> parameters)
    {
        StringBuilder urlParameter = new StringBuilder();
        foreach (string name in parameters.Keys)
        {
            string value = parameters[name];
            urlParameter.AppendFormat("{0}={1}&", name, value);
        }
        return urlParameter.ToString();
    }
}

