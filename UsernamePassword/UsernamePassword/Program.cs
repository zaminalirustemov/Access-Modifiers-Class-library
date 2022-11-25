using ClassLibrary1;
using UsernamePassword;
namespace UsernamePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;
            bool check;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(">>>>>Welcome to console<<<<<");
            do
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("---Enter your username: ");
                Console.ForegroundColor = ConsoleColor.White;
                username = Console.ReadLine();
                if (username.Length >= 6 && username.Length <= 25)
                {
                    check = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***Error: Username must be between 6-25 characters.");
                    check = true;
                }
            } while (check);

            Console.WriteLine("-------------------------------------");

            User user = new User(username);
            username = user.UserName;
            password = user.Password;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("---Enter your password: ");
                Console.ForegroundColor = ConsoleColor.White;
                password = Console.ReadLine();
                if (password.Length >= 8 && password.Length <= 25 && user.HasDigit(password) && user.HasUpper(password) && user.HasLower(password))
                {
                    check = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***Error: Password must be set between 8-25 characters and \n          at least 1 uppercase, 1 lowercase letter and 1 number must be used.");
                    check = true;
                }
            } while (check);
            Console.ResetColor();

            Console.WriteLine("=====================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"     Your user information:\n      Username: {username}\n      Password: {password}");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}