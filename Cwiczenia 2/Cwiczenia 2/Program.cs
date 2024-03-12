// See https://aka.ms/new-console-template for more information

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
