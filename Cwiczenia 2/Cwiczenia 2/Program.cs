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

    return (double)suma / liczby.Length;
}

int[] tablica = {3, 5, 6, 7, 1};
double avf = GetAverage(tablica);
Console.WriteLine(avf);