namespace Game
{
    internal class Program
    {
        // Test to see if workflow works after pushing to main branch
        private static void Main(string[] args)
        {
            var meny = new GameMenu();
            string chosenGame = meny.GameChoise();

            var gameGenerator = new GameGenerator();
            gameGenerator.GameSelection(chosenGame);
        }
    }
}