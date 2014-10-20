using System;
using System.Threading;
using System.Collections.Generic;

namespace FallingRocks
{
    struct Element
    {
        public int coordX;
        public int coordY;
        public char symbol;
        public ConsoleColor color;
    }
    class FallingRocks
    {
        static void PrintOnPosition(int coordX, int coordY, char symbol, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(coordX, coordY);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        static void PrintStringOnPosition(int coordX, int coordY, string str, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(coordX, coordY);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main()
        {
            int playfieldWidth = 27;
            int livesCount = 10;
            int score = 0;
            int speed = 0;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 50;
            Element dwarf = new Element();
            dwarf.coordX = 13;
            dwarf.coordY = Console.WindowHeight - 1;
            dwarf.symbol = 'O';
            dwarf.color = ConsoleColor.White;
            Random randomGenerator = new Random();
            List<Element> rocks = new List<Element>();


            while (true)
            {
                bool hitted = false;

                //Creating rocks
                {
                    Element newRock = new Element();
                    char[] symbol = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
                    int i = randomGenerator.Next(0, symbol.Length);
                    int assist = randomGenerator.Next(0, 100);
                    int rockLength;
                    if (assist < 70)
                    {
                        rockLength = 1;
                    }
                    else if (assist < 95)
                    {
                        rockLength = 2;
                    }
                    else
                    {
                        rockLength = 3;
                    }

                    newRock.coordX = randomGenerator.Next(0, playfieldWidth);
                    newRock.color = (ConsoleColor)randomGenerator.Next(9, 15);
                    newRock.coordY = 0;
                    newRock.symbol = symbol[i];

                    for (int j = 0; j < rockLength; j++)
                    {
                        newRock.coordX = newRock.coordX + 1;
                        if (newRock.coordX < playfieldWidth)
                        {
                            rocks.Add(newRock);
                        }

                    }
                }

                // Move dwarf (key pressed)
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.coordX - 1 >= 1)
                        {
                            dwarf.coordX--;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.coordX + 1 < playfieldWidth - 1)
                        {
                            dwarf.coordX++;
                        }
                    }
                }

                // Move rocks
                List<Element> newList = new List<Element>();

                for (int i = 0; i < rocks.Count; i++)
                {
                    Element oldRock = rocks[i];
                    Element newRock = new Element();
                    newRock.coordX = oldRock.coordX;
                    newRock.coordY = oldRock.coordY + 1;
                    newRock.symbol = oldRock.symbol;
                    newRock.color = oldRock.color;

                    // Check if rocks are hitting dwarf
                    if (((newRock.coordY == dwarf.coordY) && (newRock.coordX == (dwarf.coordX - 1))) ||
                        ((newRock.coordY == dwarf.coordY) && (newRock.coordX == dwarf.coordX)) ||
                        ((newRock.coordY == dwarf.coordY) && (newRock.coordX == (dwarf.coordX + 1))))
                    {
                        livesCount--;
                        hitted = true;

                    }

                    if (newRock.coordY < Console.WindowHeight)
                    {
                        newList.Add(newRock);
                    }
                    else
                    {
                        score++;
                    }

                }
                rocks = newList;



                // Clear the console
                Console.Clear();


                // Draw "Game over"
                if (livesCount <= 0)
                {
                    PrintStringOnPosition(17, 8, "GAME OVER !!!", ConsoleColor.Red);
                    PrintStringOnPosition(12, 16, "Your score is :" + score, ConsoleColor.Red);
                    PrintStringOnPosition(14, 24, "Press [Enter] to exit", ConsoleColor.Red);
                    Console.ReadLine();
                    return;

                }

                // Redraw playfield
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    PrintOnPosition(playfieldWidth, i, '|', ConsoleColor.White);
                }

                foreach (Element rock in rocks)
                {
                    PrintOnPosition(rock.coordX, rock.coordY, rock.symbol, rock.color);
                }

                if (hitted)
                {
                    PrintOnPosition(dwarf.coordX, dwarf.coordY, 'H', ConsoleColor.Red);
                    PrintOnPosition(dwarf.coordX - 1, dwarf.coordY, 'H', ConsoleColor.Red);
                    PrintOnPosition(dwarf.coordX + 1, dwarf.coordY, 'H', ConsoleColor.Red);
                    rocks.Clear();
                    PrintStringOnPosition(32, 3, "Press [Enter]", ConsoleColor.Green);
                    PrintStringOnPosition(33, 5, "to continue", ConsoleColor.Green);
                    speed = 0;
                    Console.ReadLine();
                }
                else
                {
                    PrintOnPosition(dwarf.coordX, dwarf.coordY, dwarf.symbol, dwarf.color);
                    PrintOnPosition(dwarf.coordX - 1, dwarf.coordY, '(', dwarf.color);
                    PrintOnPosition(dwarf.coordX + 1, dwarf.coordY, ')', dwarf.color);
                }


                // Draw info
                PrintStringOnPosition(35, 8, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringOnPosition(35, 16, "Speed: " + speed / 20, ConsoleColor.White);
                PrintStringOnPosition(33, 24, "Score: " + score, ConsoleColor.White);



                // Slow down program
                if (speed < 100)
                {
                    speed++;
                }
                Thread.Sleep(250 - speed);
            }
        }
    }
}