using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class GameGenerator
    {
        Random _random;
        int _firstNumber;
        int _secondNumber;
        string _result;

        public GameGenerator()
        {
            _random = new Random();
            _firstNumber = _random.Next(1, 9);
            _secondNumber = _random.Next(1, 9);
        }
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
            _result = Console.ReadLine();

            while (string.IsNullOrEmpty(_result) || !int.TryParse(_result, out _))
            {
                AnsiConsole.Markup("[red]Invalid input.[/] Please enter a valid whole number., press a key to continue");
                _result = Console.ReadLine();
            }

            if (int.Parse(_result) == _firstNumber + _secondNumber)

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

        private void SubstractionGame()
        {
            Console.WriteLine($"{_firstNumber} - {_secondNumber}");
            _result = Console.ReadLine();


            while (string.IsNullOrEmpty(_result) || !int.TryParse(_result, out _))
            {
                AnsiConsole.Markup("[red]Invalid input.[/] Please enter a valid whole number., press a key to continue");
                _result = Console.ReadLine();
            }

            if (int.Parse(_result) == _firstNumber + _secondNumber)
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

        private void MultiplicationGame()
        {
            Console.WriteLine($"{_firstNumber}  *  {_secondNumber}");
            _result = Console.ReadLine();

            while (string.IsNullOrEmpty(_result) || !int.TryParse(_result, out _))
            {
                AnsiConsole.Markup("[red]Invalid input.[/] Please enter a valid whole number., press a key to continue");
                _result = Console.ReadLine();
            }

            if (int.Parse(_result) == _firstNumber + _secondNumber)
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

        private void DivisionGame()
        {
            int firstNumber;
            int secondNumber;
            int divisionResult;

            // Generate random numbers until a whole number division result is obtained
            do
            {
                firstNumber = new Random().Next(1, 9);
                secondNumber = new Random().Next(1, 9);
            }
            while (firstNumber % secondNumber != 0);

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            string result = Console.ReadLine();

            while (string.IsNullOrEmpty(result) || !int.TryParse(result, out _))
            {
                AnsiConsole.Markup("[red]Invalid input.[/] Please enter a valid whole number., press a key to continue");
                result = Console.ReadLine();
            }

            if (int.Parse(result) == firstNumber / secondNumber)
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
