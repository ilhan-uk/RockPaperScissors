using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RockPaperScissorsApp
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("     Ilhan's Rock Paper Scissors Game   ");
            Console.WriteLine("****************************************");



            string computerSelect;
            string userInput;
            bool game = true;            
            bool tryAgain = true;

            List<int> total = new List<int>();
            List<string> weaponCount = new List<string>();
            
            while (tryAgain)
            {
                
                while (game)
                {
                           
                    Console.WriteLine("Write either Rock, Paper or Scissors and hit Enter:     ");
                    userInput = Console.ReadLine().ToLower();
                    var random = new Random();
                    int randomGen = random.Next(0, 4);


                    switch (randomGen)
                    {
                                                
                        case 1:
                            computerSelect = "Rock";
                            Console.WriteLine("The PC chose Rock");
                            if (userInput == "rock")
                            {
                                total.Add(1);
                                weaponCount.Add("Rock");
                                Console.WriteLine("You both chose Rock, draw!");
                                                                
                            }
                            else if (userInput == "paper")
                            {
                                weaponCount.Add("Paper");
                                total.Add(1);
                                Console.WriteLine($"You chose paper and won!  This game took {total.Count} turns  ");
                            }
                            else if (userInput == "scissors")
                            {
                                weaponCount.Add("Scissors");
                                total.Add(1);
                                Console.WriteLine("You chose Scissors, PC wins by choosing Rock");
                                
                            }
                            
                            break;
                        case 2:
                            computerSelect = "Paper";
                            Console.WriteLine("Computer chose Paper");
                            if (userInput == "paper")
                            {
                                weaponCount.Add("Paper");
                                total.Add(1);
                                Console.WriteLine("You both chose paper, draw");
                                
                            }
                            else if (userInput == "rock")
                            {
                                weaponCount.Add("Rock");
                                total.Add(1);
                                Console.WriteLine("PC wins by beating rock");
                                
                            }
                            else if (userInput == "scissors")
                            {
                                weaponCount.Add("Scissors");
                                Console.WriteLine($"Scissors beats paper you win! This game took {total.Count} turns ");
                                
                            }
                            

                            break;

                        case 3:
                            computerSelect = "Scissors";
                            Console.WriteLine("PC chose Scissors");
                            if (userInput == "scissors")
                            {
                                weaponCount.Add("Scissors");
                                total.Add(1);
                                Console.WriteLine("You both chose scissors, draw!");
                                
                            }
                            else if (userInput == "rock")
                            {
                                weaponCount.Add("Rock");
                                total.Add(1);
                                Console.WriteLine($"You chose rock and won! This game took {total.Count} turns ");
                            }
                            else if (userInput == "paper")
                            {
                                weaponCount.Add("Paper");
                                total.Add(1);
                                Console.WriteLine("PC chose scissors which beats your paper!");
                                
                            }
                            

                            break;

                            
                    }
                    var query = from name in weaponCount
                                group name by name into move
                                select new
                                {
                                    name = move.Key,
                                    count = move.Count()

                                };
                    foreach (var move in query)
                    {
                        Console.WriteLine($"Move {move.name} was used {move.count} times");
                    }
                    

                    Console.WriteLine("Do you want to play again?  Type Y or N and hit Enter:");
                    string playAgain = Console.ReadLine().ToLower();
                    
                    
                    if (playAgain == "y")
                    {
                        tryAgain = true;
                        
                    }
                    else if (playAgain == "n")
                    {
                        tryAgain = false;
                        
                        break;
                    }
                    
                }
            }
            
        }
                

    }

    
}
