internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"{Hello.Say()} {World.Say()}");
        Console.ReadKey();
    }
}