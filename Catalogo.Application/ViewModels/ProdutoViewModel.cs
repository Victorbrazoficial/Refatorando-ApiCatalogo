
namespace Catalogo.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? ImagemUrl { get; set;}
        public float Estoque { get; set; }
    }
}