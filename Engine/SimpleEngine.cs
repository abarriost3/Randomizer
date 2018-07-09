using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer
{
    public class SimpleEngine : Engine
    {
        public static SuperRandom rng;

        public SimpleEngine()
        {
            Console.WriteLine("Welcome to this program!");
            Console.WriteLine("Made by: abarrios3");
            Console.WriteLine("");
            Console.WriteLine("Loading Modules...");
            //loadModules();
            Console.WriteLine("Modules loaded successfuly!");
            Console.WriteLine("");
            Console.WriteLine("");

            rng = new SuperRandom();
            //Enters the main loop of the program
            mainLoop();
        }

        public void mainLoop()
        {
            String input = "";
            
            while(input != EngineCommandsEnum.EXIT.ToString())
            {
                input = readInput();

                manageInput(input);
            }
            
        }

        public int moduleCount()
        {
            return 0;
        }

        public string moduleList()
        {
            return "";
        }

        public string help()
        {
            String text = "\n";

            text = text + "List of available commands:\n";
            foreach (EngineCommandsEnum val in Enum.GetValues(typeof(EngineCommandsEnum)))
            {
                text = text + "\t -" + val + "\n";
            }

            text = text + "\n";

            return text;
        }

        /// <summary>
        /// Loads all the available modules
        /// </summary>
       /* private void loadModules()
        {
            String desc = "";

            //LottoModule
            try
            {
                desc = "Lotto Module";
                lottoModule = new LottoModule("Lotto", desc);
                System.Console.WriteLine("Lotto module loaded successfuly!");
            } catch(Exception e)
            {
                throw new Exception("ERROR: Module not found!");
            }
            
            

            

        }*/

        /// <summary>
        /// Manages the commands to execute according to the input
        /// </summary>
        /// <param name="input"></param>
        private void manageInput(string input)
        {
            switch (input)
            {
                case "EXIT":
                    break;

                case "HELP":
                    String output = help();
                    Console.Write(output);
                    break;

                //Spanish BonoLoto
                case "LOTTO":
                    LottoModule lotto = new LottoModule("Lotto", "a", 6, 1, 49, false, true);
                    lotto.generateNumbers();
                    System.Console.WriteLine(lotto.lottoNumbersToString());

                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Reads an input
        /// </summary>
        /// <returns>string</returns>
        private string readInput()
        {
            Console.Write("Enter your command: ");
            string input = Console.ReadLine();
            input = input.ToUpper();

            return input;
        }
        
    }
}
