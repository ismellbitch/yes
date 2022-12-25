using ConsoleApp32;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите часы: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Введите минуты: ");
        int minutes = int.Parse(Console.ReadLine());
        Console.Write("Введите секунды: ");
        int seconds = int.Parse(Console.ReadLine());

        TimeOnly EnteredTime = new TimeOnly(hours, minutes, seconds);
        TimeOnly MathStart = new TimeOnly(9, 0, 0);
        TimeOnly MathEnd = new TimeOnly(10, 20, 0);
        TimeOnly PhysicsStart = new TimeOnly(10, 30, 0);
        TimeOnly PhysicsEnd = new TimeOnly(11, 50, 0);
        TimeOnly EnglishStart = new TimeOnly(12, 20, 0);
        TimeOnly EnglishEnd = new TimeOnly(13, 40, 0);

        if (EnteredTime >= MathStart && EnteredTime < MathEnd) { Time mathematics = new Mathematics(hours, minutes, seconds); Console.WriteLine(mathematics.GetDiscipline()); }
        else if (EnteredTime >= PhysicsStart && EnteredTime < PhysicsEnd) { Time physics = new Physics(hours, minutes, seconds); Console.WriteLine(physics.GetDiscipline()); }
        else if (EnteredTime >= EnglishStart && EnteredTime < EnglishEnd) { Time english = new English(hours, minutes, seconds); Console.WriteLine(english.GetDiscipline()); }
        else { Time time = new(hours, minutes, seconds); Console.WriteLine(time.GetDiscipline()); }
    }
}