

namespace ConsoleApp1
{
    public class Eratosthenes
    {
        public List<int> firstNumbers { get; set; }

        public Eratosthenes(List<int> firstNumbers)
        {
            this.firstNumbers = firstNumbers;
        }

        public bool CzyPierwsza(int liczba)
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

        public void CheckAndShowingFirstNumbers(int n)
        {
            for (int i = 3; i < n; i++)
            {
                bool result = CzyPierwsza(i);
                if (result)
                {
                    firstNumbers.Add(i);
                    Console.WriteLine(i);
                }
            }
        }

        public void CreatingAndShowingPairs()
        {
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
        }

        public void CreatingAndShowingQUarters()
        {
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
        }
    }
}
