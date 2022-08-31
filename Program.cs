using Blight_Generator.Adventures;
using Blight_Generator.Game;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Blight_Generator
{
    class Program
    {
        private static GameService gameService = new GameService();
        static void Main(string[] args)
        {
            MakeTitle();
            MakeMainMenu();

        }

        private static void MakeTitle()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("******************************************************");
            Console.WriteLine("*       ___ _   ___ _  _ ___ _  _ ___ ___ ___        *");
            Console.WriteLine("*       |__`|   |__`|,/| |__`|`,|  |  | | |__|       *");
            Console.WriteLine("*       |__,|__,|__,|  | |__,|  |  |  |_| |  |       *");
            Console.WriteLine("*       ======================================       *");
            Console.WriteLine("******************************************************");
        }

        private static void MakeMainMenu()
        {
            MakeMenuOptions();
            var inputvalid = false;

            while (!inputvalid)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        gameService.StartGame();
                        inputvalid = true;
                        break;
                    case "C":
                        CreateCharacter();
                        inputvalid = true;
                        break;
                    case "L":
                        LoadGame();
                        inputvalid = true;
                        break;
                    default:
                        Console.WriteLine("Try again, Dreamer.");
                        MakeMenuOptions();
                        inputvalid = false;
                        break;
                }
            }
        }

        private static void MakeMenuOptions()
        {
            Console.WriteLine("\n\n(S)tart a new game");
            Console.WriteLine("(L)oad a game");
            Console.WriteLine("(C)reate new character");
        }

        private static void CreateCharacter()
        {

        }

        private static void LoadGame()
        {

        }

    }
}
