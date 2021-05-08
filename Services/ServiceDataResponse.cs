using System.IO;
using System.Net;
using ConsuminAPIDoNetMVCBootstrap.Models;
using Newtonsoft.Json;

namespace ConsuminAPIDoNetMVCBootstrap.Services
{
  public class ServiceDataResponse
  {
    public DataResponse GetDataResponse(string url)
    {
      var requestWeb = WebRequest.CreateHttp(url);
      requestWeb.Method = "GET";
      requestWeb.UserAgent = "RetirarDepois";
      DataResponse obj = new DataResponse();
      using(var response = requestWeb.GetResponse())
      {
        var streamDados = response.GetResponseStream();
        StreamReader reader = new StreamReader(streamDados);
        object objResponse = reader.ReadToEnd();
        obj = JsonConvert.DeserializeObject<DataResponse>(objResponse.ToString());
        streamDados.Close();
        response.Close();
      }
      return obj;
    }
  }
}