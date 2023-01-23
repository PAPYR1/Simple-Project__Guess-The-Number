Random RNG = new Random();
int ComputerNumber = RNG.Next(1, 101);
while (true)
{
    Console.Write("Guess a number (1-100): ");
    string PlayerGuess = Console.ReadLine();
    bool isValid = int.TryParse(PlayerGuess, out int playerNumber);
    if (isValid)
    {
        if (playerNumber == ComputerNumber)
        {
            Console.WriteLine("You guessed it!");
            break;
        }
        else if (playerNumber > ComputerNumber)
        {
            Console.WriteLine("Too High");
        }
        else if (playerNumber < ComputerNumber)
        {
            Console.WriteLine("Too Low");
        }
    }
    else
    {
        Console.WriteLine("Invalid Input.");
    }
}