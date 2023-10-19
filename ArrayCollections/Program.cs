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

TestaArrayInt();