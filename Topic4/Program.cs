namespace Topic4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a string variable that will store the username
            string userName;
            int age;
            double price;
            // We always provide a prompt explaining to the user what to type
            Console.Write("Enter username: ");
            userName = Console.ReadLine();
            // Print the value of the variable (username) in a nice sentence
            Console.WriteLine("Your username is: " + userName);

            Console.WriteLine();

            Console.WriteLine("Enter your age:");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("Your age is: " + age);

            Console.WriteLine();

            Console.WriteLine("What is the price?");
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("The price is " + price.ToString("C"));
        }
    }
}
