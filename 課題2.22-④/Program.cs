using System;
interface IWorkable
{
    void Work();
}
interface IEatable
{
    void Eat();
}
class Robot : IWorkable
{
    public void Work()
    {
        Console.WriteLine("[Robot]:働く");
    }
}

class Human : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("[Human]:働く");
    }
    public void Eat()
    {
        Console.WriteLine("[Human]:食べる");
    }
}
class Program
{
    static void Main()
    {
        IWorkable robot = new Robot();
        robot.Work();

        IWorkable humanWorker = new Human();
        humanWorker.Work();

        IEatable humanEater = new Human();
        humanEater.Eat();
    }
}
