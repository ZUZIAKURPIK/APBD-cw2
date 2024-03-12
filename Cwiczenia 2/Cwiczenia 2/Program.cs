// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Uczę");
Console.WriteLine("Sie");
Console.WriteLine("GITA");

static double GetAverage(int[] liczby)
{
    int suma = 0;
    foreach (var liczba in liczby)
    {
        suma += liczba;
    }

    double avg = (double)suma / liczby.Length;

    return avg;
}