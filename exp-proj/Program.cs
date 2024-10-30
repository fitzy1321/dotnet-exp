internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("OH SHIT, NO MORE CLASSES EVERYWHERE?");

        void DoSomething()
        {
            Console.WriteLine("Does this work?");
        }

        DoSomething();

        var age = 23;
        var joe = new Person("Joe", age);

        Console.WriteLine(joe);
    }
}

public record Person(string Name, int Age);
