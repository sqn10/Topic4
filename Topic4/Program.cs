namespace Topic4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a string variable that will store the username
            string userName, personName, pizzaTopping, itemName;
            int age;
            double price, discount, itemPrice, diameter, radius;
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
            discount = price * 0.20;
            Console.WriteLine("The 20% discount is: " + (price - discount).ToString("C"));
            discount = price * 0.50;
            Console.WriteLine("The 50% discount is: " + (price - discount).ToString("C"));

            Console.WriteLine();

            Console.WriteLine("Hello stranger! What is your name? TYPE it below, and when you are done, push ENTER on your keyboard...");
            personName = Console.ReadLine();
            Console.WriteLine("Hello, " + personName);
            Console.WriteLine();
            Console.WriteLine("Now that I know you're " + personName + ", I'd like to know your favourite pizza topping.");
            Console.WriteLine("Please TYPE your favourite pizza topping below.");
            pizzaTopping = Console.ReadLine();
            Console.WriteLine("No way, " + personName + ", my favourite pizza topping is " + pizzaTopping + " too!");

            Console.WriteLine();

            Console.WriteLine("So, " + personName + ", name any item. You're getting three of them!!");
            itemName = Console.ReadLine();
            Console.WriteLine("And please enter the price for one of your item: ");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out itemPrice));
            Console.WriteLine("The cost of three " + itemName + " is " + (itemPrice * 3).ToString("C") + ".");

            Console.WriteLine();

            Console.WriteLine("Please enter the diameter of a circle:");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out diameter));
            radius = diameter / 2.0;
            Console.WriteLine("The radius of your circle is: " + radius);
        }
    }
}
