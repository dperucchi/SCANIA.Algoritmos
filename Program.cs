// See https://aka.ms/new-console-template for more information
Console.WriteLine(Somar());
Console.WriteLine(Multiplos());
Console.WriteLine(Fibonacci());


//soma numeros até 100
int Somar()
{
    int resultado = 0;
    for (int i = 1; i <= 100; i++)
        resultado += i;

    return resultado;
}

//exibir todos os multiplos de 7 menores que 100
string Multiplos()
{
    string multiplos = string.Empty;
    int valor = 7;
    int mult = 0;
    int i = 0;
    while (mult <= 100)
    {
        mult = i * valor;
        if (mult <= 100)
            multiplos += string.Format("{0} ,", mult);
        i++;
    }

    return multiplos;
}

//sequencia de fibonacci até 100
string Fibonacci()
{
    int num1 = 0;
    int num2 = 1;
    string sequencia = string.Format("{0} {1} ", num1, num2);
    int seq = num1 + num2;

    while (seq <= 100)
    {
        sequencia += string.Format("{0} ", seq);
        num1 = num2;
        num2 = seq;
        seq = num1 + num2;
    }

    return sequencia;
}