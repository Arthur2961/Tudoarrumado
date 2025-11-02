namespace GerenciadorJogos.Models
{
    public class JogoPlataforma
    {
        public int Id { get; set; }
        public int JogoId { get; set; }
        public int PlataformaId { get; set; }
        public decimal Valor { get; set; }

        public Jogo Jogo { get; set; }
        public Plataforma Plataforma { get; set; }
    }
}