Console.WriteLine("RA: 2025106346 - Anelise Ferreira Alves");



string RetornarPalavraAleatória()
{
    string[] palavras = new string[10];
    palavras[0] = "Abobora";
    palavras[1] = "Banana";
    palavras[2] = "Texto";
    palavras[3] = "Dados";
    palavras[4] = "Linha";
    palavras[5] = "Dardo";
    palavras[6] = "Ler";
    palavras[7] = "Tela";
    palavras[8] = "Teste";
    palavras[9] = "Morder";
    int indicie = new Random().Next(0, 9);
    return palavras[indicie];
}

void Iniciar()
{
    string palavra = RetornarPalavraAleatória();
    int tentativa = palavra.Length*2;
    for (int i = 0; i < palavra.Length; i++)
    {
        Console.Write("_");
    }
    Console.WriteLine($"Você tem {tentativa} tentativas!");

   
    for (int i = 0; i < tentativa; i++)
    {
        char letraDigita= RetornarPalavra();
        foreach (char letra in palavra)
        {
            if( letraDigita == letra)
            {
                Console.Write(letra);
            }
            else
            {
                Console.Write("_");
            }
        }
    }
}
char RetornarPalavra()
{
    Console.WriteLine("Digite uma letra");
    string texto = Console.ReadLine().Trim();
    return texto[0];
}

void EscreverPalavra()
{
    
}

Iniciar();