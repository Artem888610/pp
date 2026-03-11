namespace Git
{
    class Git
    {
        static void Main(string[] args)
        {
           System.Console.Writeline("Enter your name: ");
           string name = Console.ReadLine();
           System.Console.Writeline(name.length); // debug line
           System.Console.Writeline($"Hello {name}!");
        }
    }
}