Random random = new Random();
int secretNumber = random.Next(1, 101);

Console.WriteLine("Попробуй угадать число от 1 до 100");
int guess = int.Parse(Console.ReadLine());
while (guess != secretNumber)
{
    if (guess > secretNumber)
    {
        Console.WriteLine("Попробуй меньше");
        guess = int.Parse(Console.ReadLine());
    }

    else if (guess < secretNumber)
    {
        Console.WriteLine("Попробуй больше");
        guess = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Ты угадал");