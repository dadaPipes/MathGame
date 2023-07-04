namespace Game
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            var meny = new GameMenu();
            string chosenGame = meny.GameChoise();

            var gameGenerator = new GameGenerator();
            gameGenerator.GameSelection(chosenGame);
        }
    }
}