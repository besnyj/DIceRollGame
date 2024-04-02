// using System;
//
// Gaming.PlayGame();
//
// public class Dice
// {
//     private const int AmountOfSides = 6;
//     public readonly int DiceValue;
//
//     public Dice()
//     {
//         DiceValue = new Random().Next(1, AmountOfSides + 1);
//     }
// }
//
// public static class Gaming
// {
//     const int attempts = 3;
//     public static void PlayGame()
//     {
//         var dice = new Dice();
//         Printer.GameInitialized();
//         GamingHandler.Game(attempts, dice);
//         Printer.NeverGuessed();
//     }
// }
//
// public static class GamingHandler
// {
//     public static void Game(int attempts, Dice dice)
//     {
//         do
//         {
//             string userChoice = Console.ReadLine();
//
//
//             if (!int.TryParse(userChoice, out int number))
//             {
//                 Printer.NumberIsInvalid();
//             }
//             else if (number==dice.DiceValue)
//             {
//                 Printer.NumberIsCorrect();
//                 Environment.Exit(0);
//             }
//             else
//             {
//                 Printer.WrongNumber();
//                 attempts--;
//             }
//
//         } while (attempts>0);
//     }
// }
//
// public static class Printer
// {
//     public static void NumberIsInvalid()
//     {
//         Console.WriteLine("Incorrect input");
//         Console.WriteLine("Enter a number: ");
//     }
//
//     public static void NumberIsCorrect()
//     {
//         Console.WriteLine("You win");
//         Console.ReadKey();
//     }
//
//     public static void NeverGuessed()
//     {
//         Console.WriteLine("You Lose");
//         Console.ReadKey();
//     }
//
//     public static void GameInitialized()
//     {
//         Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
//         Console.WriteLine("Enter a number: ");
//     }
//
//     public static void WrongNumber()
//     {
//         Console.WriteLine("Wrong Number");
//         Console.WriteLine("Enter a number: ");
//     }
// }

// =-=-=-=-= Professor solution

using System;
using DiceRollGame.Game;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);


// class GuessingGame
// {
//     private readonly Dice _dice;
//     private const int InitialTries = 3;
//
//     public GuessingGame(Dice dice)
//     {
//         _dice = dice;
//     }
//
//     public GameResult Play()
//     {
//         var diceRollResult = _dice.Roll();
//         Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries. ");
//
//         var triesLeft = InitialTries;
//         while (triesLeft>0)
//         {
//             var guess = ConsoleReader.ReadInteger("Enter a number: ");
//             if (guess == diceRollResult)
//             {
//                 return GameResult.Victory;
//             }
//             Console.WriteLine("Wrong number. ");
//             --triesLeft;
//         }
//
//         return GameResult.Loss;
//     }
//
//     public static void PrintResult(GameResult gameResult)
//     {
//         string message;
//         if (gameResult == GameResult.Victory)
//         {
//             message = "You win";
//         }
//         else
//         {
//             message = "You lose";
//         }
//         Console.WriteLine(message);
//     }
// }
//
// // enum is a type that defines a set of named constants
// public enum GameResult
// {
//     Victory,
//     Loss
// }
//
//
// public static class ConsoleReader
// {
//
//     public static int ReadInteger(string message)
//     {
//         int result;
//         do
//         {
//             Console.WriteLine(message);
//         } while (!int.TryParse(Console.ReadLine(), out result));
//
//         return result;
//     }
// }
//
// public class Dice
// {
//     private readonly Random _random;
//     private const int SidesCount = 6;
//
//     public Dice(Random random)
//     {
//         _random = random;
//     }
//
//     public int Roll()
//     {
//         return _random.Next(1, SidesCount+1);
//     }
//
//     public void Describe() => Console.WriteLine($"This is a dice with {SidesCount} sides");
// }


// now, move the code to the given files