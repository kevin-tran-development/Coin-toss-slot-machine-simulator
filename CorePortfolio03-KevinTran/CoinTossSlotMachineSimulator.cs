/*
 * Purpose: To create a menu driven program that allows the user to select one of two following simulators to run or to quit the program. The first 
 * simulator is for tossing a coin multiple times and tracking the total number of heads and tails of the coin tosses. The second
 * simulator is for a functioning slot machine.
 * 
 * Input: Input for Coin Toss Machine: User input amount of coin tosses.
 * Input for Slot Machine Simulator: User input for the amount of money to enter into the slot machine.
 * 
 * Process: Process for Coin Toss Simulator: The Coin Toss simulator will randomize a specified number of times that the user has inputted. For each 
 * coin toss, it will display the toss number and the result of the coin toss of (head or tails).
 * Process for Slot Machine Simulator: The slot machine will randomize a selection of fruits (cherries,oranges,plums,bells,melons, and bars). If two
 * or more fruits matches, the user wins an amount of money that the slot machine dispenses back to the user.
 * 
 * Output: Output for Coin Toss Simulator: The output will display the coin toss number according to the amount of tosses the user inputted and the 
 * result of the tosses. Will also display the amount of heads and tails at the end.
 * Output for Slot Machine Simulator: The output will display three randomized fruits along with the results of whether or not if two or more fruits
 * match and a prompt asking if they would like to play again or not. If they choose No, it will display the total amount deposited, total amount won 
 * and the net gain/loss total. 
 * 
 * Author: Kevin Tran
 * 
 * Last Modified: 2019/10/23
 * 
*/
using System;

namespace CorePortfolio03_KevinTran
{
    class CoinTossSlotMachineSimulator
    {
        static int SimulatorMenu()
        {
            // -------- Creating the Simulator Program Menu --------

            // Declaring variables and asking for user input
            int displayMenu;
            string userInput;

            Console.WriteLine("\n|-----------------------------------------------------|");
            Console.WriteLine(String.Format("{0,-10} {1,29}", "| Simulator Program Menu ", "|"));
            Console.WriteLine("|-----------------------------------------------------|");
            Console.WriteLine(String.Format("{0,-10} {1,30}", "| 1. Run Coin Simulator ", "|"));
            Console.WriteLine(String.Format("{0,-10} {1,22}", "| 2. Run Slot Machine Simulator ", "|"));
            Console.WriteLine(String.Format("{0,-10} {1,36}", "| 0. Quit Program ", "|"));
            Console.WriteLine("|-----------------------------------------------------|");
            Console.Write("Enter your menu number choice: ");
            userInput = Console.ReadLine();
            displayMenu = int.Parse(userInput);

            // Checking if the user input is a valid menu number choice
            while(displayMenu != 1 && displayMenu != 2 && displayMenu != 0)
            {
                Console.WriteLine($"{displayMenu} is not a valid menu choice. Please try again.");
                Console.Write("\nEnter your menu number choice: ");
                userInput = Console.ReadLine();
                displayMenu = int.Parse(userInput);
            }

            return displayMenu;

        } // End of the simulator program menu

        static int CoinTossSimulator()
        {
            // -------- Creating the Coin Toss Simulator Game --------

            // Declaring variables and asking for user input
            int coinTosses;
            string userInput,
                   coinFlip;
            int headsCounter = 0;
            int tailsCounter = 0;

            Console.WriteLine("\n|-----------------------------------------------------|");
            Console.WriteLine(String.Format("{0,-10} {1,32}", "| Coin Toss Simulator ", "|"));
            Console.WriteLine("|-----------------------------------------------------|");
            Console.WriteLine("This program simulates tossing a coin multiple times.");
            Console.Write("\nHow many coin tosses would you like?: ");
            userInput = Console.ReadLine();
            coinTosses = int.Parse(userInput);

            // Generating and simulating a randomizer for the coin toss          
            for (int coinCounter = 1; coinCounter <= coinTosses; coinCounter += 1)
            {
                Random coin = new Random();
                int coinToss = coin.Next(1, 3);

                if (coinToss == 1)
                {
                    headsCounter += 1;
                    coinFlip = "Heads";
                }
                else
                {
                    tailsCounter += 1;
                    coinFlip = "Tails";
                }                           

                Console.WriteLine($"Toss #{coinCounter}: {coinFlip}");                              
            } // End of for loop

            // Displaying results of the coin tosses
            Console.WriteLine($"Total number of heads: {headsCounter}");
            Console.WriteLine($"Total number of tails: {tailsCounter}");

            return coinTosses;

        } // End of coin toss simulator method

        static double SlotMachineSimulator()
        {
            // -------- Creating the Slot Machine Simulator Game --------

            // Declaring variables and asking for user input
            double playerDeposit,
                   totalWinnings,                  
                   totalNetDifference,
                   playerDepositHolder;
            double totalDeposited = 0;
            double totalWinningsHolder = 0;
            bool winningsTracker = true;
            string userInput,
                   repeat,
                   slotImageOne,
                   slotImageTwo,
                   slotImageThree;

            Console.WriteLine("\n|-----------------------------------------------------|");
            Console.WriteLine(String.Format("{0,-10} {1,29}", "| Slot Machine Simulator ", "|"));
            Console.WriteLine("|-----------------------------------------------------|");
            Console.WriteLine("This program simulates a slot machine.\n");
            
            // Generating and simulating a randomizer for the slot machine
            do
            {
                Console.Write("Enter the amount that you would like to deposit into the slot machine: ");
                userInput = Console.ReadLine();
                playerDeposit = double.Parse(userInput);

                // Recording the amount of times the user deposits to be displayed later
                playerDepositHolder = playerDeposit;
                totalDeposited += playerDepositHolder;

                for (int slotCounter = 0; slotCounter < 1; slotCounter += 1)
                {
                    Random slot = new Random();
                    int slotRandomOne = slot.Next(0, 6);
                    int slotRandomTwo = slot.Next(0, 6);
                    int slotRandomThree = slot.Next(0, 6);

                    switch (slotRandomOne)
                    {
                        case 1:
                            slotImageOne = "Oranges";
                            break;
                        case 2:
                            slotImageOne = "Plums";
                            break;
                        case 3:
                            slotImageOne = "Bells";
                            break;
                        case 4:
                            slotImageOne = "Melons";
                            break;
                        case 5:
                            slotImageOne = "Bars";
                            break;
                        default:
                            slotImageOne = "Cherries";
                            break;
                    } // End of switch statement

                    switch (slotRandomTwo)
                    {
                        case 1:
                            slotImageTwo = "Oranges";
                            break;
                        case 2:
                            slotImageTwo = "Plums";
                            break;
                        case 3:
                            slotImageTwo = "Bells";
                            break;
                        case 4:
                            slotImageTwo = "Melons";
                            break;
                        case 5:
                            slotImageTwo = "Bars";
                            break;
                        default:
                            slotImageTwo = "Cherries";
                            break;
                    } // End of switch statement

                    switch (slotRandomThree)
                    {
                        case 1:
                            slotImageThree = "Oranges";
                            break;
                        case 2:
                            slotImageThree = "Plums";
                            break;
                        case 3:
                            slotImageThree = "Bells";
                            break;
                        case 4:
                            slotImageThree = "Melons";
                            break;
                        case 5:
                            slotImageThree = "Bars";
                            break;
                        default:
                            slotImageThree = "Cherries";
                            break;
                    } // End of switch statement

                    Console.Write($"{slotImageOne} {slotImageTwo} {slotImageThree} ");

                    // Determining if the user has won or not by using all of the possible winning combinations and testing them
                    if (slotImageOne == slotImageTwo || slotImageOne == slotImageThree || slotImageTwo == slotImageThree)
                    {
                        if (slotImageOne == slotImageTwo && slotImageOne == slotImageThree && slotImageTwo == slotImageThree)
                        {
                            totalWinnings = playerDepositHolder * 3;
                            totalWinningsHolder += totalWinnings;

                            if(totalWinningsHolder > totalDeposited)
                            {
                                totalNetDifference = totalWinningsHolder - totalDeposited;
                            }
                            else
                            {
                                totalNetDifference = totalDeposited - totalWinningsHolder;
                            }

                            Console.WriteLine("\nThree words match. You won 3x !");
                            Console.Write("Would you like to play again? (yes | no): ");
                            repeat = Console.ReadLine();

                            // Validating if the user response is valid or not
                            while (repeat != "yes" && repeat != "Yes" && repeat != "YES" && repeat != "no" && repeat != "No" && repeat != "NO")
                            {
                                Console.WriteLine($"\"{repeat}\" is not a valid choice. Please try again !");
                                Console.Write("Would you like to play again? (yes | no): ");
                                repeat = Console.ReadLine();
                            }

                            // When user decides to stop playing
                            if (repeat == "no" || repeat == "No" || repeat == "NO")
                            {
                                winningsTracker = false;
                                Console.WriteLine($"Total amount deposited: {totalDeposited:C}");
                                Console.WriteLine($"Total amount won: {totalWinningsHolder:C}");
                                Console.WriteLine($"Net gain/loss total: {totalNetDifference:C}");
                            } // End of if statement               
                        }
                        else
                        {
                            totalWinnings = playerDepositHolder * 2;
                            totalWinningsHolder += totalWinnings;

                            if (totalWinningsHolder > totalDeposited)
                            {
                                totalNetDifference = totalWinningsHolder - totalDeposited;
                            }
                            else
                            {
                                totalNetDifference = totalDeposited - totalWinningsHolder;
                            }

                            Console.WriteLine("\nTwo words match. You won 2x !");
                            Console.Write("Would you like to play again? (yes | no): ");
                            repeat = Console.ReadLine();

                            // Validating if the user response is valid or not
                            while (repeat != "yes" && repeat != "Yes" && repeat != "YES" && repeat != "no" && repeat != "No" && repeat != "NO")
                            {
                                Console.WriteLine($"\"{repeat}\" is not a valid choice. Please try again !");
                                Console.Write("Would you like to play again? (yes | no): ");
                                repeat = Console.ReadLine();
                            }

                            // When user decides to stop playing
                            if (repeat == "no" || repeat == "No" || repeat == "NO")
                            {
                                winningsTracker = false;
                                Console.WriteLine($"Total amount deposited: {totalDeposited:C}");
                                Console.WriteLine($"Total amount won: {totalWinningsHolder:C}");
                                Console.WriteLine($"Net gain/loss total: {totalNetDifference:C}");
                            } // End of if statement     
                        }
                    }
                    else
                    {
                        totalWinnings = 0;
                        totalWinningsHolder += totalWinnings;

                        if (totalWinningsHolder > totalDeposited)
                        {
                            totalNetDifference = totalWinningsHolder - totalDeposited;
                        }
                        else
                        {
                            totalNetDifference = totalDeposited - totalWinningsHolder;
                        }

                        Console.WriteLine("\nNo words match. You won $0");
                        Console.Write("Would you like to play again? (yes | no): ");
                        repeat = Console.ReadLine();

                        // Validating if the user response is valid or not
                        while (repeat != "yes" && repeat != "Yes" && repeat != "YES" && repeat != "no" && repeat != "No" && repeat != "NO")
                        {
                            Console.WriteLine($"\"{repeat}\" is not a valid choice. Please try again !");
                            Console.Write("Would you like to play again? (yes | no): ");
                            repeat = Console.ReadLine();
                        }

                        // When user decides to stop playing
                        if (repeat == "no" || repeat == "No" || repeat == "NO")
                        {
                            winningsTracker = false;
                            Console.WriteLine($"Total amount deposited: {totalDeposited:C}");
                            Console.WriteLine($"Total amount won: {totalWinningsHolder:C}");
                            Console.WriteLine($"Net gain/loss total: {totalNetDifference:C}");
                        } // End of if statement     

                    } // End of if-else test     
                    
                } // End of for loop                                                                        

            } while (winningsTracker == true);
            
            return totalDeposited;

        } // End of slot machine simulator method

        static void Main(string[] args)
        {
            // -------- Start of the Simulator Program Menu --------

            // Declaring variables and implementing the menu while using methods
            bool menuLoop = false;

            while (!menuLoop)
            {
                int simulatorMenu;
                simulatorMenu = SimulatorMenu();
                switch (simulatorMenu)
                {
                    case 1:
                        int coinTossSimulator;
                        coinTossSimulator = CoinTossSimulator();
                        break;
                    case 2:
                        double slotMachineSimulator;
                        slotMachineSimulator = SlotMachineSimulator();
                        break;
                    default:
                        Console.WriteLine("Good-bye and thanks for using the Simulator Program !");
                        menuLoop = true;
                        break;
                } // End of switch statement

            } // End of while loop      
            
        } // End of main method
    }
}
