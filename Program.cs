﻿using System;

namespace Earncraft
{
    class Program
    {
        public static void Main(string[] args)
        {
            //gadaj coś 
            Console.WriteLine("Who are you, Stranger?");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Ok you are Stranger");
                name = "Stranger";
            }
            else if (name.ToLower() == "stranger")
            {
                Console.WriteLine("Ha! I knew it");
            }

            Console.WriteLine("Hello " + name + " where are you from?");
            string from = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(from))
            {
                Console.WriteLine("You are not to talkative, are you");
                name = "Nowhere";
            }
            Console.WriteLine($"Hey {name} from {from} to first version Earncraft");
            Console.WriteLine("Press click any key to continue");
            Console.ReadKey(true);

            string[] level = {
     "#########",
      "#    #  #",
      "#   ##  #",
      "#    #  #",
      "#    #  #",
      "#       #",
      "#    #  #",
      "#########"
    };
            string[] scroll = {
      "     _______________",
      "()==(              (@==()",
      "     '______________ '|",
      "       |             |",
      "       |             |",
      "     __)_____________|    ",
      "()==(               (@==()",
      "     '--------------'    ",
      "                      "
    };


            Console.Clear();
            Console.WriteLine("Wanna se the map? Press any key untill it is a revealed...");



            int scrollHalf = scroll.Length / 2;
            for (int i = 0; i < scrollHalf; i++)
            {
                Console.WriteLine(scroll[i]);

            }

            int nextmap = Console.CursorTop;
            foreach (string row in level)
            {
                Console.SetCursorPosition(0, nextmap);

                Console.WriteLine($"       |  {row}  |");

                for (int i = scrollHalf; i < scroll.Length; i++)
                {
                    Console.WriteLine(scroll[i]);
                }
                nextmap++;
                Console.ReadKey(true);

            }




        }
    }
}