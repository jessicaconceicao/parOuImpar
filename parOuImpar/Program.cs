//Verificar se a entrada é par ou ímpar
Console.WriteLine("Digite um número");
string numero = Console.ReadLine();
try
{
    int numeroInt = Convert.ToInt32(numero);
    if (numeroInt % 2 == 0)
    {
        Console.WriteLine("O número é par.");
    }
    else
    {
        Console.WriteLine("O número é impar.");
    }
}
catch (Exception)
{ 
    Console.WriteLine("Digite um número válido"); 
}
