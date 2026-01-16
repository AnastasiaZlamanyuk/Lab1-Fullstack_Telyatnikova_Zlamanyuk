Console.WriteLine("Hello, World!");
Console.WriteLine("Нас зовут Телятникова Е.П. и Зламанюк А.А.");
Console.WriteLine(DateTime.Now);
Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");
Console.WriteLine(DateTime.Now.DayOfWeek);
Console.Write("Хотите продолжить? (y/n): ");
char? otvet = char.Parse(Console.ReadLine().ToLower());
while (otvet == 'y')
{
    Console.Write("Введите имя: ");
    string name1 = Console.ReadLine();
    Console.WriteLine($"Привет, {name1}!");
    Console.WriteLine(DateTime.Now.DayOfWeek);
    Console.Write("Хотите продолжить? (y/n): ");
    otvet = char.Parse(Console.ReadLine().ToLower());
}
Console.WriteLine("Пока!");
