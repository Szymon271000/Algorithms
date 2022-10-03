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


int n = int.Parse(Console.ReadLine());
for (int i = 2; i < n; i++)
{
    bool result = CzyPierwsza(i);
    if (result)
        Console.WriteLine(i);
}

