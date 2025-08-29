
using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

List<string> tarefas = new List<string>();
List<bool> statusTarefas = new List<bool>();
void ExibirMenu()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("==== Assistente Pessoal ====");
    Console.WriteLine(" 1 - Adicionar tarefa");
    Console.WriteLine(" 2 - Listar tarefas");
    Console.WriteLine(" 3 - Marcar tarefa como concluida");
    Console.WriteLine(" 4 - Excluir tarefa");
    Console.WriteLine(" 5 - Exibir resumo das tarefas");
    Console.WriteLine(" 0 - Sair");
    Console.WriteLine("Escolha uma opcao ;)");
}

void CadastrarTarefa()
{
    Console.WriteLine("Digite uma nova tarefa");
    string novaTarefa = Console.ReadLine();

    tarefas.Add(novaTarefa);
    statusTarefas.Add(false);

    Console.WriteLine("Ebaaarrr tarefa adicionada com sucesso!");

}

void ListarTarefa()
{
    if (tarefas.Count == 0)
    {
        Console.WriteLine("nenhuma tarefa cadastrada :(");
        return;
    }

    Console.WriteLine("==== LISTA DE TAREFAS ===");

    for (int i = 0; i < tarefas.Count; i++)
    {
        bool status = statusTarefas[i];

        string check;

        if (status == true)
        {
            check = "[X]";
        }
        else
        {
            check = "[ ]";
        }

        Console.WriteLine($"  {check} - {tarefas[i]}");

    }
}

void MarcarComoConcluida()
{
    ListarTarefa();

    Console.WriteLine("Informe o numero da tarefa a ser concluida:");
    int numTarefa = int.Parse(Console.ReadLine()!) - 1;

    if (numTarefa >= 0 && numTarefa < tarefas.Count)
    {
        statusTarefas[numTarefa] = true;
        Console.WriteLine("Tarefa marcada como concluida!");
    }
    {
        Console.WriteLine("Numero invalido. Essa tarefa nao existe!  :(");
    }

}

void ExcluirTarefa()
{
    ListarTarefa();

    Console.WriteLine("Informe o numero da tarefa a ser excluida: ");
    int numTarefa = int.Parse(Console.ReadLine()!) - 1;


    if (numTarefa >= 0 && numTarefa <= tarefas.Count)
    {
        tarefas.RemoveAt(numTarefa);
        statusTarefas.RemoveAt(numTarefa);
        Console.WriteLine("Tarefa removida com sucesso!");
    }
    {
        Console.WriteLine("Numero invalido Essa tarefa nao existe");
    }
}

void ExibirResumo()
{
    int totalDeTarefas = tarefas.Count;
    int tarefasConcluidas = statusTarefas.Count;
    int tarefasPendentes = totalDeTarefas - tarefasConcluidas;

    Console.WriteLine("=== RESUMO ===");
    Console.WriteLine($"Total de tarefas: {totalDeTarefas} ");
    Console.WriteLine($"Total de tarefas concluidas: {tarefasConcluidas} ");
    Console.WriteLine($"Total de tarefas pendentes: {tarefasPendentes} ");
}

do
{
    ExibirMenu();
    string opcao = (Console.ReadLine())!;

    switch (opcao)
    {
        case "1":
            CadastrarTarefa();
            break;
        case "2":
            ListarTarefa();
            break;
        case "3":
            MarcarComoConcluida();
            break;
        case "4":
            ExcluirTarefa();
            break;
        case "5":
            ExibirResumo();
            break;
        case "0":
            Console.WriteLine("opcao selecionada e 0");
            break;
    }
} while (true);