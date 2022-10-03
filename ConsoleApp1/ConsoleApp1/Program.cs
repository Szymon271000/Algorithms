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
int n = int.Parse(Console.ReadLine());
for (int i = 3; i < n; i++)
{
    bool result = CzyPierwsza(i);
    if (result)
    {
        firstNumbers.Add(i);
        Console.WriteLine(i);
    }
}

Console.WriteLine("-------------------------------");
for (int i = 0; i < firstNumbers.Count; i++)
{
    bool result = CzyPierwsza(firstNumbers[i]);
    int secondFirstNumber = firstNumbers[i] + 2;
    bool secondResult = CzyPierwsza(secondFirstNumber);
    if (result && secondResult)
    {
        Console.WriteLine($"{secondFirstNumber - 2} {secondFirstNumber}");
    }
}
Console.WriteLine("-------------------------------");
for (int i = 0; i < firstNumbers.Count; i++)
{
    bool result = CzyPierwsza(firstNumbers[i]);
    int secondFirstNumber = firstNumbers[i] + 2;
    int thirdFirstNumber = firstNumbers[i] + 6;
    int fourthFirstNumber = firstNumbers[i] + 8;
    bool secondResult = CzyPierwsza(secondFirstNumber);
    bool thirdResult = CzyPierwsza(thirdFirstNumber);
    bool fourthResult = CzyPierwsza(fourthFirstNumber);
    if (result && secondResult && thirdResult && fourthResult)
    {
        Console.WriteLine($"{secondFirstNumber - 2} {secondFirstNumber} {thirdFirstNumber} {fourthFirstNumber}");
    }
}
