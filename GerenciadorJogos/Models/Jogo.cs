using System.Collections.Generic;

namespace GerenciadorJogos.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public int Ano { get; set; }
        public decimal Valor { get; set; }
        public string Capa { get; set; }

        public List<JogoPlataforma>? JogoPlataformas { get; set; }
        public List<JogoGenero>? JogoGeneros { get; set; }
    }
}

