using ConsoleApp5;
using System;

class Program
{
    static void Main()
    {
        
        Bear bear = new();
        bear.Name = "Bozayi";
        bear.Age = 6;
        bear.IsWild = true;
        bear.Eat();
        Console.WriteLine($"Bear Name:{bear.Name} Bear Age:{bear.Age} CanSwim:{bear.IsWild} {bear.Eat} ");
        Bird bird = new();
        bird.Name = "swallow";
        bird.Age = 1;
        bird.CanSwim = false;
        bird.Eat();
        bird.Fly();
        Console.WriteLine($"Bird Name:{bird.Name} Bird Age:{bird.Age} CanSwim:{bird.CanSwim} {bird.Eat} {bird.Fly}");

        Dog dog = new();
        dog.Name = "Alabay";
        dog.Age = 3;
        dog.HasTail = true;
        dog.Eat(); 
        dog.Bark(); 
        Console.WriteLine($"Dogs Name:{dog.Name} Dogs Age:{dog.Age} HasTail:{dog.HasTail} {dog.Eat} {dog.Bark}");
    }
}

