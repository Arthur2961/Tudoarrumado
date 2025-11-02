

namespace GerenciadorJogos.Models
{
    public class JogoGenero
    {
        public int Id { get; set; }
        public int JogoId { get; set; }
        public int GeneroId { get; set; }

        public Jogo Jogo { get; set; }
        public Genero Genero { get; set; }
    }
}