using System;

class Mainclass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите свой возраст:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите своё имя:");
        string name = Console.ReadLine();
        Console.WriteLine("Ваш возраст {0} и ваше имя {1}", age, name);

        Console.WriteLine("Какой ваш любимый день недели?");
        DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine("Ваш любимый день недели это {0}", day);
        
        Console.WriteLine("Введите дату своего рождения:");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Ваша дата рождения {0}", birthdate);

        Console.ReadLine();
       






    }
}
