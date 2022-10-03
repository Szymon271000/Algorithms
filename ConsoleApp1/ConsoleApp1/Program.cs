using ConsoleApp1;

static bool CzyPierwsza(int liczba)
{
    for (int i = 2; i <= liczba / 2; i++)
    {
        if (liczba % i == 0)
        {
            return false;
        }
    }

    return true;
}

List<int> firstNumbers = new List<int>();
Eratosthenes eratosthenes = new Eratosthenes(firstNumbers);
int n = int.Parse(Console.ReadLine());
eratosthenes.CheckAndShowingFirstNumbers(n);
Console.WriteLine("-------------------------------");
eratosthenes.CreatingAndShowingPairs();
Console.WriteLine("-------------------------------");
eratosthenes.CreatingAndShowingQUarters();
