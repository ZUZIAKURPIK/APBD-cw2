// See https://aka.ms/new-console-template for more information

static double GetAverage(int[] liczby)
{
    int suma = 0;
    foreach (var liczba in liczby)
    {
        suma += liczba;
    }

    double srednia = (double)suma / liczby.Length;

    return srednia;
}

static int GetMax(int[] inty)
{
    int max = 0;

    foreach (var wartosc in inty)
    {
        if (wartosc > max) max = wartosc;
    }
    
    return max;
}

int[] tab = { 1, 2, 3, 4, 5, 6, 7, 9999 };
int odp = GetMax(tab);
Console.WriteLine(odp);
