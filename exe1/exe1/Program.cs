using exe1;

namespace exe1
{
    internal class Program
    {
        class Programa
        {
            static void Main(string[] args)
            {
                // Exemplo de utilização da classe Produto
                Produto produto1 = new Produto("Camiseta", 29.99, 50);
                produto1.ExibirInformacoes(); // Exibir informações iniciais do produto

                produto1.AdicionarAoEstoque(20); // Adicionar 20 unidades ao estoque
                produto1.ExibirInformacoes(); // Exibir informações atualizadas do produto

                produto1.RemoverDoEstoque(10); // Remover 10 unidades do estoque
                produto1.ExibirInformacoes(); // Exibir informações atualizadas do produto

                produto1.RemoverDoEstoque(100); // Tentar remover mais unidades do que disponível no estoque
            }
        }
    }
}