using System.IO;
using System.Net;
using ConsuminAPIDoNetMVCBootstrap.Models;
using Newtonsoft.Json;

namespace ConsuminAPIDoNetMVCBootstrap.Services
{
  public class ServiceLoterica
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

    public Datum GetDatum(string url)
    {
      var requestWeb = WebRequest.CreateHttp(url);
      requestWeb.Method = "GET";
      requestWeb.UserAgent = "RetirarDepois";
      Datum obj = new Datum();
      using(var response = requestWeb.GetResponse())
      {
        var streamDados = response.GetResponseStream();
        StreamReader reader = new StreamReader(streamDados);
        object objResponse = reader.ReadToEnd();
        obj = JsonConvert.DeserializeObject<Datum>(objResponse.ToString());
        streamDados.Close();
        response.Close();
      }
      return obj;
    }
    public ListaMunicipioUFGanhadore GetListaMunicipioUFGanhadore(string url)
    {
      var requestWeb = WebRequest.CreateHttp(url);
      requestWeb.Method = "GET";
      requestWeb.UserAgent = "RetirarDepois";
      ListaMunicipioUFGanhadore obj = new ListaMunicipioUFGanhadore();
      using(var response = requestWeb.GetResponse())
      {
        var streamDados = response.GetResponseStream();
        StreamReader reader = new StreamReader(streamDados);
        object objResponse = reader.ReadToEnd();
        obj = JsonConvert.DeserializeObject<ListaMunicipioUFGanhadore>(objResponse.ToString());
        streamDados.Close();
        response.Close();
      }
      return obj;
    }

    public ListaRateioPremio GetListaRateioPremio(string url)
    {
      var requestWeb = WebRequest.CreateHttp(url);
      requestWeb.Method = "GET";
      requestWeb.UserAgent = "RetirarDepois";
      ListaRateioPremio obj = new ListaRateioPremio();
      using(var response = requestWeb.GetResponse())
      {
        var streamDados = response.GetResponseStream();
        StreamReader reader = new StreamReader(streamDados);
        object objResponse = reader.ReadToEnd();
        obj = JsonConvert.DeserializeObject<ListaRateioPremio>(objResponse.ToString());
        streamDados.Close();
        response.Close();
      }
      return obj;
    }
  }
}