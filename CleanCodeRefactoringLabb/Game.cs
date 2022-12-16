
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
				
				int numberOfGuesses = 1;
				string goalCheck = Goals.checkBC(goal, guess);
				Console.WriteLine(goalCheck + "\n");
				while (goalCheck != "BBBB,")
				{
					numberOfGuesses++;
					guess = Console.ReadLine();
					Console.WriteLine(guess + "\n");
					goalCheck = Goals.checkBC(goal, guess);
					Console.WriteLine(goalCheck + "\n");
				}
				StreamWriter output = new StreamWriter("result.txt", append: true);
				output.WriteLine(name + "#&#" + numberOfGuesses);
				output.Close();
				TopList.showTopList();
				Console.WriteLine("Correct, it took " + numberOfGuesses + " guesses\nContinue? Press any key, else q to exit");
				answer = Console.ReadLine();
			} while(answer != "q");
        }
    }
}