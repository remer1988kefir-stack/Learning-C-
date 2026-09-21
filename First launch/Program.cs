Console.WriteLine("Как вас зовут?");
string name = Console.ReadLine();
while (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Ты ебень");
    name = Console.ReadLine();
}
Console.WriteLine("Сколько вам лет?");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("В каком городе вы живете?");
string city = Console.ReadLine();


Console.WriteLine("===== Информация о пользователе =====");
Console.WriteLine($"Имя:  {name}");
Console.WriteLine($"Возраст:  {age}");
Console.WriteLine($"Город:  {city}");
Console.WriteLine("=====================================");

if (age < 0 || age > 150)
{
    Console.WriteLine("Статус: Неправильное значение");
}
else if (age <= 12)
{
    Console.WriteLine("Статус: Ребенок");
}
else if (age >= 13 && age <= 17)
{
    Console.WriteLine("Статус: Подросток");
}
else
{
    Console.WriteLine("Статус: Взрослый");
}
