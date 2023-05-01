using TaskManagement.Common;
using TaskManagement.Database;

namespace TaskManagement
{
    //Encapsulaiton

    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("/register");
                Console.WriteLine("/login");
                Console.WriteLine("/update-language-preference");

                Console.Write("Add commands:");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/register":
                        RegisterCommand adminDashboard = new RegisterCommand();
                        adminDashboard.Handle();
                        break;
                    case "/login":
                        LoginCommand loginCommand = new LoginCommand();
                        loginCommand.Handle();
                        break;
                    case "/update-language-preference":
                        UpdateLanguagePreferenceCommand.Handle();
                        break;

                    case "/exit":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }
    }
}
