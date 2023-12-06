using System.Net.Http.Headers;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Net.Http.Json;
using Newtonsoft.Json;
using PokemonCatcherGame.Server.Data;
using Spectre.Console;
using static System.Console;

public class ProgramUI
{
    private readonly ApplicationDbContext? _dbContext;

    HttpClient httpClient = new HttpClient();
    private bool IsRunning = true;

    public void RunApplication()
    {
        Run();
    }

    public void Run()
    {
        while (IsRunning)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Pokemon Catcher Game!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Play Game");
            Console.WriteLine("2. Exit");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    PlayGame();
                    break;
                case "2":
                    IsRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }

    public void PlayGame()
    {
        Clear();
        ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("|===========================================|\n" +
                     "|                                           |\n" +
                     "|  Welcome to the World Of Pokémon          |\n" +
                     "|  A Game of Adventure and Destiny          |\n" +
                     "|       Made By: Brian Lane                 |\n" +
                     "|                                           |\n" +
                     "|===========================================|\n" +
                     "|  What Would You Like To Do?               |\n" +
                     "|                                           |");
            ConsoleKeyInfo key;
            int option = 1;
            bool isSelected = false;
            (int left, int top) = Console.GetCursorPosition();
            string color = "🐉\u001b[35m";
            
            while(!isSelected)
            {
                Console.SetCursorPosition(left, top);
                WriteLine($"|{(option == 1 ? color : "  ")}1. Play Game\u001b[32m                    |");
                WriteLine($"|{(option == 2 ? color : "  ")}2. Exit\u001b[32m                         |");
                WriteLine("|                                           |\u001b[32m");
                WriteLine("|===========================================|\u001b[32m");

                try
                {
                    key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            option = (option == 2 ? 1 : option + 1);
                            break;
                        
                        case ConsoleKey.UpArrow:
                            option = (option == 1 ? 2 : option - 1);
                            break;

                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;

                        default:
                            WriteLine("Invalid input. Please try again.");
                            PressAnyKeyToContinue();
                            break;
                    }
                }
                catch (System.Exception)
                {
                    WriteLine("Invalid input. Please try again.");
                    PressAnyKeyToContinue();
                }
                
            }

            try
            {
                var userInput = option;
                switch (userInput)
                {
                    case 1:
                        PlayGame();
                        break;
                    case 2:
                        IsRunning = ExitApplication();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
            catch (System.Exception)
            {
                WriteLine("Invalid input. Please try again.");
                PressAnyKeyToContinue();
            }
    }

    private bool ExitApplication()
    {
        return false;
    }

    private void PressAnyKeyToContinue()
    {
        WriteLine("Press any key to continue...");
        ReadKey();
    }
}
