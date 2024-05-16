using System;

public class Produto
{
    // Atributos
    private string nome;
    private double preco;
    private int quantidadeEmEstoque;

    // Construtor
    public Produto(string nome, double preco, int quantidadeEmEstoque)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantidadeEmEstoque = quantidadeEmEstoque;
    }

    // Método para adicionar itens ao estoque
    public void AdicionarAoEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            quantidadeEmEstoque += quantidade;
            Console.WriteLine($"{quantidade} unidades do produto {nome} adicionadas ao estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade a ser adicionada deve ser maior que zero.");
        }
    }

    // Método para remover itens do estoque
    public void RemoverDoEstoque(int quantidade)
    {
        if (quantidade > 0 && quantidade <= quantidadeEmEstoque)
        {
            quantidadeEmEstoque -= quantidade;
            Console.WriteLine($"{quantidade} unidades do produto {nome} removidas do estoque.");
        }
        else if (quantidade > quantidadeEmEstoque)
        {
            Console.WriteLine("Quantidade insuficiente em estoque.");
        }
        else
        {
            Console.WriteLine("A quantidade a ser removida deve ser maior que zero.");
        }
    }

    // Método para exibir informações do produto
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Produto: {nome}, Preço: R${preco}, Quantidade em estoque: {quantidadeEmEstoque}");
    }
}