using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConsuminAPIDoNetMVCBootstrap.Models
{
  public class DataResponse
      {
          [JsonPropertyName("success")]
          public bool Success { get; set; }

          [JsonPropertyName("data")]
          public List<Datum> Data { get; set; }
      }
}