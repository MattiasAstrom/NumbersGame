namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 21);
            int guessCount = 0;
            bool gameComplete = false;

            WriteToConsole("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            //Game loop
            while (!gameComplete)
            {
                if (guessCount >= 5)
                {
                    WriteToConsole($"Tyvärr, du lyckades inte gissa talet på fem försök! Det rätta talet var {randomNumber}.");
                    break;
                }

                guessCount++;

                WriteToConsole("Välj ett nummer mellan 1 och 20:");
                int guess;

                //Handle input and compare to random value.
                if (int.TryParse(Console.ReadLine(), out guess) && guess > 0)
                {
                    if (guess > randomNumber)
                        WriteToConsole("Tyvärr, du gissade för högt!");
                    else if (guess < randomNumber)
                        WriteToConsole("Tyvärr, du gissade för lågt!");
                    else
                    {
                        WriteToConsole("Wohoo! Du klarade det!");
                        gameComplete = true;
                    }
                }
                else
                    WriteToConsole("Ogiltig input. Välj ett nummer mellan 1 och 20.");
            }
            //Seperated write to its own function.
            void WriteToConsole(string msg)
            {
                Console.WriteLine(msg);
            }
        }
    }
}