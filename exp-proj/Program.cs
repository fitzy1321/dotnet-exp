
Console.WriteLine("Hello, C# World. It's been awhile");

static void DoSomething()
{
    Console.WriteLine("Does this work?");
}

DoSomething();

var age = 23;
var joe = new Person("Joe", age);

Console.WriteLine(joe);

public record Person(string Name, int Age);
