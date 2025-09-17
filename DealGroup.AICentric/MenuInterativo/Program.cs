using MenuInterativo.Models; // Importa o namespace do projeto (não usado ainda, mas pode ser útil futuramente)

// Declaração da variável que vai armazenar a opção digitada pelo usuário
string opcao;

// Estrutura de repetição infinita (só para quando o usuário escolher a opção de sair)
while (true)
{
    // Exibindo o menu de opções para o usuário
    Console.Clear(); // Limpa a tela do console
    Console.WriteLine("Digite sua opção:");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Clientes");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Sair");

    // Lendo a opção digitada
    opcao = Console.ReadLine();

    // Avaliando a opção com switch case
    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar Cliente");
            break;

        case "2":
            Console.WriteLine("Buscar Clientes");
            break;

        case "3":
            Console.WriteLine("Apagar Cliente");
            break;

        case "4":
            Console.WriteLine("Saindo do programa...");
            return; // Encerra o programa

        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

    // Linha em branco para separar visualmente o menu em cada repetição
    Console.WriteLine();
}
