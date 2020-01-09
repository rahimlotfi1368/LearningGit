namespace ConsoleAppGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Rahim",
                Age = 31,
            };
            string result = $"(master)hello world {person.Name}";
            System.Console.WriteLine(result);
            System.Console.ReadKey();
        }
    }
}
