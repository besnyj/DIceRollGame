using System;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

        bool xxx = guessingGame.Play();


        public class GuessingGame
        {
            private readonly Dice _dice;
            private const int InitialTries = 3;

            public GuessingGame(Dice dice)
            {
                _dice = dice;
            }

            public bool Play()
            {
                var diceRollResult = _dice.Roll();
                Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries. ");

                var triesLeft = InitialTries;
                while (triesLeft > 0)
                {
                    var guess = ConsoleReader.ReadInteger("Enter a number: ");
                    if (guess == diceRollResult)
                    {
                        return true;
                    }
                    --triesLeft;
                }
                return false;
            }
        }

        public static class ConsoleReader
        {
            public static int ReadInteger(string message)
            {
                int result;
                do
                {
                    Console.WriteLine(message);
                } while (!int.TryParse(Console.ReadLine(), out result));

                return result;
            }
        }

        public class Dice
        {
            private const int SidesCount = 6;
            private readonly Random _random;

            public Dice(Random random)
            {
                _random = random;
            }

            public int Roll() => _random.Next(1, SidesCount + 1);

        }
    }
