using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class HttpHelper
{
    private const string urlApi = "https://my.bukep.ru:447/api/Schedule";

    public string executeGet(string nameMethod, Dictionary<string, string> parameters)
    {
        string url = createURL(nameMethod, parameters);
        Console.WriteLine("URL = " + url);
        WebRequest request = WebRequest.Create(url);

        request.Credentials = CredentialCache.DefaultCredentials;
        WebResponse response = request.GetResponse();

        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string json = reader.ReadToEnd();

        reader.Close();
        response.Close();
        return json;
    }

    private string createURL(string nameMethod, Dictionary<string, string> parameter)
    {
        string urlParameter = createUrlParameter(parameter);
        string url = String.Format("{0}/{1}?{2}", urlApi, nameMethod, urlParameter);
        return url;
    }

    internal string executePost(string nameMethod, Dictionary<string, string> parameters,
        String bodyForPost)
    {
        string url = createURL(nameMethod, parameters);
        Console.WriteLine("URL = " + url);
        WebRequest request = WebRequest.Create(url);


        var dataForPost = Encoding.ASCII.GetBytes(bodyForPost);

        request.Method = "POST";
        request.ContentType = "application/json";
        request.ContentLength = dataForPost.Length;

        Stream stream =  request.GetRequestStream();
        stream.Write(dataForPost, 0, dataForPost.Length);
        stream.Close();

        request.Credentials = CredentialCache.DefaultCredentials;
        WebResponse response = request.GetResponse();

        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string json = reader.ReadToEnd();
        reader.Close();

        response.Close();
        return json;
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

