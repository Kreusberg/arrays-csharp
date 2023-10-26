using ArrayCollections.bytebank.Exceptions;
using ArrayCollections.bytebank.Util;
using bytebank.Modelos.Conta;
using System.ComponentModel.Design;

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
    for (int i = 0; i < idades.Length; i++)
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

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
        numerosOrdenados[meio] + numerosOrdenados[meio - 1] / 2;

    Console.WriteLine($"Com base na amostra, a mediana é igual a {mediana}");

}

double TestaMedia(Array amostra)
{

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
            somaTotal += (double)amostra.GetValue(i)!;
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

List<ContaCorrente> _listaDeContas = new List<ContaCorrente>(){
    new ContaCorrente(95, "123456-X"){Saldo=100,Titular = new Cliente{Cpf="11111",Nome ="Henrique"}},
    new ContaCorrente(95, "951258-X"){Saldo=200,Titular = new Cliente{Cpf="22222",Nome ="Pedro"}},
    new ContaCorrente(94, "987321-W"){Saldo=60,Titular = new Cliente{Cpf="33333",Nome ="Marisa"}}
};

#region Exemplos de Uso Do List
//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C")
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(951, "5679787-E"),
//    new ContaCorrente(321, "4456668-F"),
//    new ContaCorrente(719, "7781438-G")
//};

//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//var range = _listaDeContas3.GetRange(0, 1);

//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");

//    Console.WriteLine("\n\n");

//}

//_listaDeContas3.Clear();
//for (int i = 0; i < _listaDeContas3.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas3[i].Conta}]");
//}
#endregion

void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
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
            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }
            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverConta();
                    break;
                case '4':
                    OrdenarConta();
                    break;
                case '5':
                    PesquisarConta();
                    break;
                default:
                    Console.WriteLine("Opcao não implementada.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
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

void ListarContas()
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
        //Console.WriteLine("===  Dados da Conta  ===");
        //Console.WriteLine("Número da Conta : " + item.Conta);
        //Console.WriteLine("Saldo da Conta : " + item.Saldo);
        //Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        //Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        //Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(item.ToString());
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}

void RemoverConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===      REMOVER CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Informe o número da Conta: ");
    string numeroConta = Console.ReadLine();
    ContaCorrente conta = null;
    foreach (var item in _listaDeContas)
    {
        if (item.Conta.Equals(numeroConta))
        {
            conta = item;
        }
    }
    if (conta != null)
    {
        _listaDeContas.Remove(conta);
        Console.WriteLine("... Conta removida da lista! ...");
    }
    else
    {
        Console.WriteLine(" ... Conta para remoção não encontrada ...");
    }
    Console.ReadKey();
}

void OrdenarConta()
{
    _listaDeContas.Sort();
    Console.WriteLine("... Lista de contas ordenada ...");
    Console.ReadKey();
}

void PesquisarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    PESQUISAR CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Deseja pesquisar por (1) NÚMERO DA CONTA , (2) CPF TITULAR  ou (3) NÚMERO DA AGÊNCIA ? ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            {
                Console.Write("Informe o número da Conta: ");
                string _numeroConta = Console.ReadLine();
                ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                Console.WriteLine(consultaConta.ToString());
                Console.ReadKey();
                break;
            }
        case 2:
            {
                Console.Write("Informe o CPF do Titular: ");
                string _cpf = Console.ReadLine();
                ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                Console.WriteLine(consultaCpf.ToString());
                Console.ReadKey();
                break;
            }
        case 3:
            {
                Console.Write("Informe o N° da Agência: ");
                int _numeroAgencia = int.Parse(Console.ReadLine());
                var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
                ExibirListarDeContas(contasPorAgencia);
                Console.ReadKey();
                break;
            }

        default:
            Console.WriteLine("Opção não implementada.");
            break;
    }
}


ContaCorrente ConsultaPorCPFTitular(string? cpf)
{
    //ContaCorrente conta = null;
    //for (int i = 0; i < _listaDeContas.Count; i++)
    //{
    //    if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
    //    {
    //        conta = _listaDeContas[i];
    //    }
    //}
    //return conta;
    return _listaDeContas.Where(conta => conta.Titular.Cpf.Equals(cpf)).FirstOrDefault();
}

ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
{
    //ContaCorrente conta = null;
    //for (int i = 0; i < _listaDeContas.Count; i++)
    //{
    //    if (_listaDeContas[i].Conta.Equals(numeroConta))
    //    {
    //        conta = _listaDeContas[i];
    //    }
    //}
    //return conta;
    return _listaDeContas.Where(conta => conta.Conta.Equals(numeroConta)).FirstOrDefault();
}

List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
{
    var consulta = (
                         from conta in _listaDeContas
                         where conta.Numero_agencia == numeroAgencia
                         select conta).ToList();
    return consulta;
}

void ExibirListarDeContas(List<ContaCorrente> contasPorAgencia)
{
    if (contasPorAgencia == null)
    {
        Console.WriteLine("... A consulta não retornou dados ...");
    }
    else
    {
        foreach (var item in contasPorAgencia)
        {
            Console.WriteLine(item.ToString());

        }
    }

}

AtendimentoCliente();