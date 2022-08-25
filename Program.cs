namespace helloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string stg = "hello world";
            Console.WriteLine(stg);

            Console.WriteLine("Enter username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
            
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is " + age);
        }
    }
}

