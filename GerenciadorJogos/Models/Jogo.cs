using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorJogos.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int Ano { get; set; }
        [DataType(DataType.Currency)]
        public decimal? Valor { get; set; }

        [Required(ErrorMessage = "A URL da capa é obrigatória.")]
        [Url(ErrorMessage = "A capa deve ser uma URL válida.")]
        public string Capa { get; set; }

        public List<JogoPlataforma>? JogoPlataformas { get; set; }
        public List<JogoGenero>? JogoGeneros { get; set; }
    }
}

