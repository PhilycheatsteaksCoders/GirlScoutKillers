using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//by philip sekora (AKA Philycheatsteak)
//4-16-18
//S = start of dialog
//A = option A and what it will entail 
//B = option B and what it will entail
//C = continuation of the dialog
//E = end of said dialog and move into a new case or part


namespace AdventureGameProject
{
    public static class game
    {
        static int Scenarios = 3;
        static string CharacterName;

        static string[] PartOne = {
          /*S  0*/ "you get out of your hybrid suburu and start to walk towards banana mamas, (your local smoothie store) when your blinded for a split second by the glem of a couple metalic badges on a sash \n you remember your freind telling you about how pushy the girl scouts can be.\n you have a choice to make, continue into the store and walk by them or buy some of thier cookies \n press A to continue, or B to stop and buy cookies",
          /*A  1*/ "you continue past them and act as if you didnt hear them (this angers them, so watch out in the future) you grab a cup and walk to the smoothie machine and find a ten dollar bill \n you pick it up and pocket it ",
          /*B  2*/  "you break down and give into the inhuman persuassion of the girl scouts, they offer you your choice of smores, samoas, and thin mints \n Press A for smores, B for samoas, and C for thin mints",
          /*SPECIAL A3*/ "you chose smores but they tell you they are then out so you can only get samoas",
          /*SPECIAL B4*/ "you chose somoas and they tell you that you total will be ten dollars, too bad you only have a twenty and they have no change, so you buy two samoas and no longer have money for your daily smoothie",
          /*SPECIAL C5*/ " oh to bad" + CharacterName + "you chose thin mints and your immidiatly struck by lightning",
          /*C  6*/// "The lights return and you move into a room at the end of the hall. \nThere is a vending machine.",
          /*A  7*/ //"Luckily " + CharacterName + " you have that coin you found and you buy yourself a snack.",
          /*B  8*/  //"Too bad you don't have a coin on you," + CharacterName + ",\nor you would have been able to get a snack.",
          /*E  9 */// "You begin to climb the stairs to the next floor."

        };
        static string[] PartTwo = {
          /*S*/  "Description of story part two ... and the choice A or B",
          /*A*/  "... part two - what happens if A is chosen...",
          /*B*/ "... part two - what happens if B is chosen...",
          /*C*/ "....more story.... .",
          /*A*/  "... part two, again - what happens if A is chosen...",
          /*B*/  "... part two again - what happens if B is chosen...",
          /*E*/ "You begin to climb the stairs to the next floor...."
        };
        static string[] PartThree = {
          /*S*/ "Description of story part three... and the choice A or B",
          /*A*/"... part 3 - what happens if A is chosen...",
          /*B*/ "... part 3 - what happens if B is chosen...",
          /*C*/ "....more story.... .",
          /*A*/  "... part 3, again - what happens if A is chosen...",
          /*B*/ "... part 3 again - what happens if B is chosen...",
          /*E*/  "You begin to climb the stairs to the next floor...."
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
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Enter your choice: ");
                            input = Console.ReadLine();
                            input = input.ToLower();
                            Console.ResetColor();

                            if (input == "a")
                            {
                                Console.WriteLine(PartOne[4]);

                            }
                            else if (input == "b")
                            {
                                Console.WriteLine(PartOne[5]);
                            }

                            else
                            {
                                Console.WriteLine(PartOne[6]);
                                EndGame();
                            }
                        }
        

                        //6) print last piece of the section
                        Console.WriteLine(PartOne[7]);



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
