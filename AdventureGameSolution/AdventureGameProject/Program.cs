using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdventureGameProject
{
    public static class game
    {
        static int Scenarios = 3;
        static string CharacterName;

        static string[] PartOne = {
            "At the front of the imposing building you see a weathered old man with a cart.\nAs you near, you see the cart is filled with what looks like mostly junk and \nonly a few useful items. All you have on you is piece of a chalk.\nYou offer it to him, and he says he'll trade a flashlight or an umbrella for it.\nTo choose type either A for the flashlight, or B for the umbrella.",
            "The power in the building goes out - luckily you have a flashlight! \nYou move the light around and a large animal is frightened by the \nsudden brightness and takes off. As you move the light again, \nsomething glitters. You reach down and pick up a coin!",
            "The power in the building goes out! As you move down the hallway \nyou hear what sounds like a large animal nearby. You move the \numbrella in a widening arc in front of you to scare it, \nand the animal skitters off.",
            "The lights return and you move into a room at the end of the hall. \nThere is a vending machine.",
            "Luckily " + CharacterName + " you have that coin you found and you buy yourself a snack.",
            "Too bad you don't have a coin on you," + CharacterName + ",\nor you would have been able to get a snack.",
            "You begin to climb the stairs to the next floor."
        };
        static string[] PartTwo = {
            "Description of story part two ... and the choice A or B",
            "... part two - what happens if A is chosen...",
            "... part two - what happens if B is chosen...",
            "....more story.... .",
            "... part two, again - what happens if A is chosen...",
            "... part two again - what happens if B is chosen...",
            "You begin to climb the stairs to the next floor...."
        };
        static string[] PartThree = {
            "Description of story part three... and the choice A or B",
            "... part 3 - what happens if A is chosen...",
            "... part 3 - what happens if B is chosen...",
            "....more story.... .",
            "... part 3, again - what happens if A is chosen...",
            "... part 3 again - what happens if B is chosen...",
            "You begin to climb the stairs to the next floor...."
        };

        public static void StartGame()
        {
            GameTitle();
            Console.WriteLine("the gang of hoodrat muslim hippy terrioist girl scouts arrive at your work place");
            NameCharacter();
            Choice();
            GameTitle();
            EndGame();

        }
        public static void Choice()
        {
            for (int section = 1; section <= Scenarios; section++)
            {
                string input = "";

                switch (section)
                {
                    case 1:
                        //Part One

                        //same pattern for each of the sections. 1) print the first part of the section
                        Console.WriteLine(PartOne[0]);

                        //2)read in player's choice (a or b)
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();

                        //3) if a print the next part of the array, otherwise skip next and print 3rd
                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[1]);

                        }
                        else
                        {
                            Console.WriteLine(PartOne[2]);
                        }

                        //4) print next part of the section
                        Console.WriteLine(PartOne[3]);

                        //5) again if a print next, otherwise skip ahead
                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartOne[5]);
                        }

                        //6) print last piece of the section
                        Console.WriteLine(PartOne[6]);



                        break;

                    case 2:
                        //Part Two

                        Console.WriteLine(PartTwo[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();
                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[1]);

                        }
                        else
                        {
                            Console.WriteLine(PartTwo[2]);
                        }
                        Console.WriteLine(PartTwo[3]);
                        if (input == "a")
                        {
                            Console.WriteLine(PartTwo[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartTwo[5]);
                        }
                        Console.WriteLine(PartTwo[6]);

                        break;

                    case 3:
                        //Part Three
                        Console.WriteLine(PartThree[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter your choice: ");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        Console.ResetColor();
                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[1]);

                        }
                        else
                        {
                            Console.WriteLine(PartThree[2]);
                        }
                        Console.WriteLine(PartThree[3]);
                        if (input == "a")
                        {
                            Console.WriteLine(PartThree[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartThree[5]);
                        }
                        Console.WriteLine(PartThree[6]);
                        break;

                    default:
                        //default if section number does not match one of the above
                        break;
                }

                //let player advance when ready, then clear the screen
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
                Console.Clear();


            }

            }
            public static void NameCharacter()
        {
            Console.WriteLine("what is your girl scout slaying name ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("enter your girl scout name: ");

            CharacterName = Console.ReadLine();

            Console.ResetColor();
            Console.WriteLine("you have chosen the girl scout slaying name of  " + CharacterName + ".Good Luck! \n\n");
            Console.ReadKey();
        }

        
        static void GameTitle()
        {
            string Title = @"TheScoutsOfAutumn";
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //game title
            Console.WriteLine(Title);
            // game slogan/subtitle
            Console.WriteLine("an awsome adventure Game");
            Console.ResetColor();
            Console.WriteLine("press enter to start the slaying of girlscouts");
            Console.ReadKey();
            Console.Clear();
        }
        public static void EndGame()
        {
            //end of game text
            Console.WriteLine("this is the end of the Scouts");

            Console.WriteLine("press enter to end it");

        }
    }
    
    class item
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            game.StartGame();
            Console.ReadKey();

        }
    }
}
