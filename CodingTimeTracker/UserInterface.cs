using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTimeTracker
{
    public class UserInterface
    {
        InputManager inputManager = new InputManager();

        public UserInterface()
        {
            MainMenuLoop();
        }

        public void MainMenuLoop()
        {
            Console.Clear();
            bool quitApp = false;
            while (quitApp == false)
            {
                Console.WriteLine("+---------------------------------------------+");
                Console.WriteLine("|                   MAIN MENU                 |");
                Console.WriteLine("+---------------------------------------------+");
                Console.WriteLine("|    Type 0 to quit app                       |");
                Console.WriteLine("|    Type 1 to VIEW all coding times records  |");
                Console.WriteLine("|    Type 2 to INSERT coding time record      |");
                Console.WriteLine("|    Type 3 to DELETE coding time record      |");
                Console.WriteLine("|    Type 4 to UPDATE coding time record      |");
                Console.WriteLine("+---------------------------------------------+");

                var input = Console.ReadLine();
                int option = -1;
                while (input == null)
                {
                    input = Console.ReadLine();
                }
                try
                {
                    option = int.Parse(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (option)
                {
                    case 0:
                        quitApp = true;
                        break;
                    case 1:
                        Console.Clear();
                        inputManager.GetData();
                        break;
                    case 2:
                        Console.Clear();
                        inputManager.InsertData();
                        break;
                    case 3:
                        Console.Clear();
                        inputManager.GetData();
                        inputManager.DeleteData();
                        break;
                    case 4:
                        Console.Clear();
                        inputManager.GetData();
                        inputManager.UpdateData();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("|       Choose option from menu!        |");
                        Console.WriteLine("-----------------------------------------");
                        break;
                }

            }
        }
    }
}
