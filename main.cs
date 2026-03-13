namespace Git
{
    class Git
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
           System.Console.Writeline("Enter your name: ");
           string name = Console.ReadLine();
           System.Console.Writeline(name.length); // debug line
           System.Console.Writeline($"Hello, {name}!");
=======
           System.Console.Writeline("Enter your first name: "); 
           string first_name = Console.ReadLine();
           System.Console.Writeline("Now enter your last name: ")
           string last_name = Console.ReadLine();
           System.Console.Writeline($"Hello {first name} {last name}!");
>>>>>>> b0d8286ef5ef8239d8d49ef9ebcc9b6fe28382f7
        }
    }
}