using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConsuminAPIDoNetMVCBootstrap.Models
{
public class Datum
    {
        [JsonPropertyName("tipoJogo")]
        public string TipoJogo { get; set; }

        [JsonPropertyName("nomeMunicipioUFSorteio")]
        public string NomeMunicipioUFSorteio { get; set; }

        [JsonPropertyName("dataApuracao")]
        public string DataApuracao { get; set; }

        [JsonPropertyName("valorArrecadado")]
        public double ValorArrecadado { get; set; }

        [JsonPropertyName("valorEstimadoProximoConcurso")]
        public int ValorEstimadoProximoConcurso { get; set; }

        [JsonPropertyName("valorAcumuladoProximoConcurso")]
        public double ValorAcumuladoProximoConcurso { get; set; }

        [JsonPropertyName("valorAcumuladoConcursoEspecial")]
        public double ValorAcumuladoConcursoEspecial { get; set; }

        [JsonPropertyName("valorAcumuladoConcurso_0_5")]
        public double ValorAcumuladoConcurso05 { get; set; }

        [JsonPropertyName("acumulado")]
        public bool Acumulado { get; set; }

        [JsonPropertyName("indicadorConcursoEspecial")]
        public int IndicadorConcursoEspecial { get; set; }

        [JsonPropertyName("dezenasSorteadasOrdemSorteio")]
        public List<string> DezenasSorteadasOrdemSorteio { get; set; }

        [JsonPropertyName("listaResultadoEquipeEsportiva")]
        public object ListaResultadoEquipeEsportiva { get; set; }

        [JsonPropertyName("numeroJogo")]
        public int NumeroJogo { get; set; }

        [JsonPropertyName("nomeTimeCoracaoMesSorte")]
        public string NomeTimeCoracaoMesSorte { get; set; }

        [JsonPropertyName("tipoPublicacao")]
        public int TipoPublicacao { get; set; }

        [JsonPropertyName("observacao")]
        public string Observacao { get; set; }

        [JsonPropertyName("localSorteio")]
        public string LocalSorteio { get; set; }

        [JsonPropertyName("dataProximoConcurso")]
        public string DataProximoConcurso { get; set; }

        [JsonPropertyName("numeroConcursoAnterior")]
        public int NumeroConcursoAnterior { get; set; }

        [JsonPropertyName("numeroConcursoProximo")]
        public int NumeroConcursoProximo { get; set; }

        [JsonPropertyName("valorTotalPremioFaixaUm")]
        public int ValorTotalPremioFaixaUm { get; set; }

        [JsonPropertyName("numeroConcursoFinal_0_5")]
        public int NumeroConcursoFinal05 { get; set; }

        [JsonPropertyName("listaMunicipioUFGanhadores")]
        public List<ListaMunicipioUFGanhadore> ListaMunicipioUFGanhadores { get; set; }

        [JsonPropertyName("listaRateioPremio")]
        public List<ListaRateioPremio> ListaRateioPremio { get; set; }

        [JsonPropertyName("listaDezenas")]
        public List<string> ListaDezenas { get; set; }

        [JsonPropertyName("listaDezenasSegundoSorteio")]
        public object ListaDezenasSegundoSorteio { get; set; }

        [JsonPropertyName("concurso")]
        public string Concurso { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}