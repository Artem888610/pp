namespace Git
{
    class Git
    {
        static void Main(string[] args)
        {
           System.Console.Writeline("Enter your first name: "); 
           string first_name = Console.ReadLine();
           System.Console.Writeline("Now enter your last name: ")
           string last_name = Console.ReadLine();
           System.Console.Writeline($"Hello {first name} {last name}!");
        }
    }
}