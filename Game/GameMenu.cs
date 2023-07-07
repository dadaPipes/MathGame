using Spectre.Console;

namespace Game
{
    public class GameMenu
    {
        /// <summary>
        /// Prompts the user to select a game and returns the selected game as a string.
        /// </summary>
        /// <returns>The selected game as a string.</returns>
        public string GameChoise()
        {
            var selectedGame = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What [green]game[/] do you select?")
                    .PageSize(4)
                    .AddChoices(new[] {
                        "Addition", "Substraction", "Multiplication", "Division",
                    }));

            return selectedGame;
        }
    }
}