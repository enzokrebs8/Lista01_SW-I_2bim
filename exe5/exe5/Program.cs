namespace exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

            // Exemplo de uso
            gerenciador.AdicionarTarefa("Estudar para a prova", new DateTime(2024, 5, 13));
            gerenciador.AdicionarTarefa("Ir ao médico", new DateTime(2024, 5, 14));
            gerenciador.AdicionarTarefa("Enviar atividade", new DateTime(2024, 5, 17));

            gerenciador.ListarTarefas();
            gerenciador.ListarTarefasHoje();

            gerenciador.RemoverTarefa("Estudar para o exame");
            gerenciador.ListarTarefas();
        }
    }
}
