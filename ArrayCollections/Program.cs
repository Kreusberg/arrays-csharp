using ArrayCollections.bytebank.Util;
using bytebank.Modelos.Conta;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Arrays em C#
void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array: {idades.Length}");

    int acumulador = 0;
    for( int i = 0; i < idades.Length; i++ )
    {
        int idade = idades[i];
        acumulador += idade;
        Console.WriteLine($"Índice [{i}] = {idade}");
    }
    int media = acumulador / idades.Length;
        Console.WriteLine($"Média de idades: {media}");
}

void TesteBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i + 1}ª palavra: ");
        arrayDePalavras[i] = Console.ReadLine();

    }

    Console.Write("Digite a palavra a ser buscada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
    }
}

void testaMediana(Array array)
{
    if (array == null || array.Length == 0)
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[]) array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
        numerosOrdenados[meio] + numerosOrdenados[meio - 1] / 2;

    Console.WriteLine($"Com base na amostra, a mediana é igual a {mediana}");

}

double TestaMedia(Array amostra) {

    if ((amostra == null) || (amostra.Length == 0))
    {
        Console.WriteLine("Amostra de dados nula ou vazia.");
        return 0;
    }
    else
    {
        double somaTotal = 0;
        for (int i = 0; i < amostra.Length; i++)
        {
            somaTotal += (double) amostra.GetValue(i)!;
        }

        double media = somaTotal / amostra.Length;
        Console.WriteLine($"Com base na amostra, a média é igual a {media.ToString("#.##")}");
        return media;

    }

}

void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(799, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(134, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(758, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "1234567-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("==============");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Índice [{i}] = {conta.Conta} / {conta.Numero_agencia}");
    }

}


Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//TestaArrayDeContasCorrentes();
#endregion

ArrayList _listaDeContas = new ArrayList();

void AtendimentoCliente()
{
    char opcao = '0';
    while (opcao!= '6')
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("===       Atendimento        ===");
        Console.WriteLine("=== 1 - Cadastrar Conta      ===");
        Console.WriteLine("=== 2 - Listar Contas        ===");
        Console.WriteLine("=== 3 - Remover Conta        ===");
        Console.WriteLine("=== 4 - Ordenar Contas       ===");
        Console.WriteLine("=== 5 - Pesquisar Conta      ===");
        Console.WriteLine("=== 6 - Sair do Sistema      ===");
        Console.WriteLine("================================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        opcao = Console.ReadLine()[0];
        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;
            case '2':
                ListarConta();
                break;
            default:
                Console.WriteLine("Opcao não implementada.");
                break;
        }
    }
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);
    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}

void ListarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");

    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }

    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Saldo da Conta : " + item.Saldo);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}

AtendimentoCliente();