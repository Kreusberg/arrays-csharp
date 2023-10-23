using ArrayCollections.bytebank.Util;
using bytebank.Modelos.Conta;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

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

ContaCorrente cc1 = new(874, "AA")
{
    Saldo = 100
};

ContaCorrente cc2 = new(874, "BB")
{
    Saldo = 200
};

ContaCorrente cc3 = new(874, "CC")
{
    Saldo = 65.9
};

ContaCorrente cc4 = new(874, "DD")
{
    Saldo = 78.1
};

ContaCorrente cc5 = new(874, "EE")
{
    Saldo = 10
};


void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(cc1);
    listaDeContas.Adicionar(cc2);
    listaDeContas.Adicionar(cc3);
    listaDeContas.Adicionar(cc4);
    listaDeContas.Adicionar(cc5);
    ContaCorrente cc = listaDeContas.MaiorSaldo();
    Console.WriteLine($"Conta com maior valor: {cc.Conta}");

}


Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);


//TestaArrayInt();
//TesteBuscarPalavra();
//testaMediana(amostra);
//TestaMedia(amostra);
TestaArrayDeContasCorrentes();