using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class GameMenu
    {
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