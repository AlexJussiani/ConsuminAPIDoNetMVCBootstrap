using System.Text.Json.Serialization;

namespace ConsuminAPIDoNetMVCBootstrap.Models
{
  public class ListaMunicipioUFGanhadore
  {
        [JsonPropertyName("posicao")]
        public int Posicao { get; set; }

        [JsonPropertyName("ganhadores")]
        public int Ganhadores { get; set; }

        [JsonPropertyName("municipio")]
        public string Municipio { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("nomeFatansiaUL")]
        public string NomeFatansiaUL { get; set; }

        [JsonPropertyName("serie")]
        public string Serie { get; set; }
    }
}