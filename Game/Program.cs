namespace Game
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var gameMenu = new GameMenu();
            string chosenGame = gameMenu.GameChoise();

            var gameGenerator = new GameGenerator();
            gameGenerator.GameSelection(chosenGame);
        }
    }
}