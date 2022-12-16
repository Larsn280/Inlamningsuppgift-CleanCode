
namespace CleanCodeRefactoringLabb
{
    public class Game
    {
		public string Welcome() {
			return "Enter your user name:\n";
		}

        public void Play(string name) {
            string answer;
			do {
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
				answer = Console.ReadLine();
			} while(answer != "q");
        }
    }
}