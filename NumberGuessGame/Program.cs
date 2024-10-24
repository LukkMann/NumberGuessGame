namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to number guessing game ...");
            Console.WriteLine("A number between 1 to 10 will be generated.");
            Console.WriteLine("if you guess the correct number, you win");
            while (!isCorrectGuess)
            {
                Console.WriteLine("enter your guess");
                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess > randomNum)
                {
                    Console.WriteLine("your gess to high");
                }
                else if(guess < randomNum)
                {
                    Console.WriteLine("your guess to low");
                }
                else
                {
                    Console.WriteLine("Correct");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("You won the game");

            Console.ReadLine();


        }
    }
}
