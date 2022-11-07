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
//int n = int.Parse(Console.ReadLine());
//eratosthenes.CheckAndShowingFirstNumbers(n);
//Console.WriteLine("-------------------------------");
//eratosthenes.CreatingAndShowingPairs();
//Console.WriteLine("-------------------------------");
//eratosthenes.CreatingAndShowingQUarters();


int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
Cubic cubic = new Cubic(a, b, c, d);
cubic.Calculate(cubic.A, cubic.B, cubic.C, cubic.D);

//FifthGrade fifthGrade = new FifthGrade(5,2,3,4,2,5);
//double result = fifthGrade.Calculate(-1000, 1000, 0.000001);
//Console.WriteLine(result);
