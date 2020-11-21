using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Greeter

{
    public string Name { get; set; }
    public string Hello(string name)
    {
        Name = name;

        Console.WriteLine($"Hello {name}.");

        return ($"Hello {name}.");

    }
    public string Farewell(string name)
    {
        Name = name;

       Console.WriteLine($"So long {name}. Nice to have met you.");
        return ($"So long {name}. Nice to have met you.");
    }
    public void TimeOfDay(string name, DateTime time)
    {
        int hour = time.Hour;

        if (hour > 4 && hour < 12)
        { Console.WriteLine($"Good Morning {name}"); }

        else if (hour >= 12 && hour < 18)
        { Console.WriteLine($"I hope you're Having a Good Afternoon {name}."); }

        else if ( hour >= 18 && hour < 12)
        { Console.WriteLine($"Are you having a good evening so far {name}?"); }

        else
        { Console.WriteLine($"What are you doing up {name}? You should be in bed."); }

    }

    static public void Main(String[] args)
    {
        Console.WriteLine("Please Input Your Name.");
        string name = Console.ReadLine();
        DateTime time = DateTime.Now;
        Greeter g = new Greeter();
        g.Hello(name);
        g.Farewell(name);
        g.TimeOfDay(name, time);
        Console.ReadLine();


    }



}
