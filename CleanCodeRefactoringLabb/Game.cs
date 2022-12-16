
namespace CleanCodeRefactoringLabb
{
    public class Game
    {
        public void Play() {
            bool playOn = true;
			Console.WriteLine("Enter your user name:\n");
			string name = Console.ReadLine();

			while (playOn)
			{
				string goal = Goals.makeGoal();

				
				Console.WriteLine("New game:\n");
				//comment out or remove next line to play real games!
				Console.WriteLine("For practice, number is: " + goal + "\n");
				string guess = Console.ReadLine();
				
				int nGuess = 1;
				string bbcc = Goals.checkBC(goal, guess);
				Console.WriteLine(bbcc + "\n");
				while (bbcc != "BBBB,")
				{
					nGuess++;
					guess = Console.ReadLine();
					Console.WriteLine(guess + "\n");
					bbcc = Goals.checkBC(goal, guess);
					Console.WriteLine(bbcc + "\n");
				}
				StreamWriter output = new StreamWriter("result.txt", append: true);
				output.WriteLine(name + "#&#" + nGuess);
				output.Close();
				TopList.showTopList();
				Console.WriteLine("Correct, it took " + nGuess + " guesses\nContinue?");
				string answer = Console.ReadLine();
				if (answer != null && answer != "" && answer.Substring(0, 1) == "n")
				{
					playOn = false;
				}
			}
        }
    }
}