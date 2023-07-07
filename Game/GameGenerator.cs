using Spectre.Console;

namespace Game
{
    /// <summary>
    /// Provides various math games
    /// </summary>
    public class GameGenerator
    {
        private readonly Random _random;
        private int _firstNumber;
        private int _secondNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameGenerator"/> class.
        /// </summary>
        public GameGenerator()
        {
            _random = new Random();
            _firstNumber = _random.Next(1, 9);
            _secondNumber = _random.Next(1, 9);
        }

        /// <summary>
        /// Selects and starts a specific game based on the provided game name.
        /// </summary>
        /// <param name="game">The name of the game to select.</param>
        public void GameSelection(string game)
        {
            if (game == "Addition")
            {
                AdditionGame();
            }
            if (game == "Substraction")
            {
                SubstractionGame();
            }
            if (game == "Multiplication")
            {
                MultiplicationGame();
            }
            if (game == "Division")
            {
                DivisionGame();
            }
        }

        private void AdditionGame()
        {
            Console.WriteLine($"{_firstNumber} + {_secondNumber}");
            string? result = Console.ReadLine();

            ValidateInput(result);

            DisplayResult(int.Parse(result) == _firstNumber + _secondNumber);
        }

        private void SubstractionGame()
        {
            Console.WriteLine($"{_firstNumber} - {_secondNumber}");
            string? result = Console.ReadLine();

            ValidateInput(result);

            DisplayResult(int.Parse(result) == _firstNumber - _secondNumber);
        }

        private void MultiplicationGame()
        {
            Console.WriteLine($"{_firstNumber}  *  {_secondNumber}");
            string? result = Console.ReadLine();

            ValidateInput(result);

            DisplayResult(int.Parse(result) == _firstNumber * _secondNumber);
        }

        private void DivisionGame()
        {
            // Generate random numbers until a whole number division result is obtained
            do
            {
                _firstNumber = new Random().Next(1, 9);
                _secondNumber = new Random().Next(1, 9);
            }
            while (_firstNumber % _secondNumber != 0);

            Console.WriteLine($"{_firstNumber} / {_secondNumber}");
            string? result = Console.ReadLine();

            ValidateInput(result);

            DisplayResult(int.Parse(result) == _firstNumber / _secondNumber);
        }

        /// <summary>
        /// Validates user input and prompts for a valid whole number.
        /// </summary>
        /// <param name="input">The user input to validate.</param>
        /// <returns>The validated user input.</returns>
        private string ValidateInput(string? input)
        {
            while (string.IsNullOrEmpty(input) || !int.TryParse(input, out _))
            {
                AnsiConsole.Markup("[red]Invalid input.[/] Please enter a valid whole number.");
                input = Console.ReadLine();
            }
            return input;
        }

        /// <summary>
        /// Displays the result message based on the correctness of the answer.
        /// </summary>
        /// <param name="isCorrect">Indicates whether the answer is correct.</param>
        private void DisplayResult(bool isCorrect)
        {
            if (isCorrect)
            {
                AnsiConsole.Markup("[green]Correct[/], press a key to continue");
                Console.ReadLine();
            }
            else
            {
                AnsiConsole.Markup("[red]Incorrect[/], press a key to continue");
                Console.ReadLine();
            }
        }
    }
}