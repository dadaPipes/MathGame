using Spectre.Console;

namespace Game
{
    /// <summary>
    /// Test Class XML comment
    /// </summary>
    public class GameMenu
    {
        /// <summary>
        /// Test method XML comment
        /// </summary>
        /// <returns></returns>
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