namespace Game
{
    internal class Program
    {
        /// <summary>
        /// Test with XML comments
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var meny = new GameMenu();
            string chosenGame = meny.GameChoise();

            var gameGenerator = new GameGenerator();
            gameGenerator.GameSelection(chosenGame);
        }
    }
}