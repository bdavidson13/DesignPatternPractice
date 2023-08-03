// See https://aka.ms/new-console-template for more information
using DesignPatternPractice.Patterns.Decorator;

Human human = new Human("Bob");
Walker human2 = new Walker(human);
Console.WriteLine(human.Action());
Console.WriteLine(human2.Walk());
