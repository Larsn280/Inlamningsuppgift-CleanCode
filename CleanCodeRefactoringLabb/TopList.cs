
namespace CleanCodeRefactoringLabb
{
    public class TopList
    {
		public static string WriteScore(string name, int numberOfGuesses) {
			StreamWriter output = new StreamWriter("result.txt", append: true);
			output.WriteLine(name + "#&#" + numberOfGuesses);
			output.Close();
			return "Score Added";
        }

        public static void ShowTopList()
		{
			StreamReader input = new StreamReader("result.txt");
			List<PlayerData> results = new List<PlayerData>();

			string line;
			while ((line = input.ReadLine()!) != null)
			{
				string[] nameAndScore = line.Split(new string[] { "#&#" }, StringSplitOptions.None);
				string name = nameAndScore[0];
				int guesses = Convert.ToInt32(nameAndScore[1]);
				PlayerData playerData = new PlayerData(name, guesses);
				int position = results.IndexOf(playerData);
				if (position < 0)
				{
					results.Add(playerData);
				}
				else
				{
					results[position].Update(guesses);
				}
			}
			ShowResults(results);
			input.Close();
		}

		public static void ShowResults(List<PlayerData> results) {
			results.Sort((play1, play2) => play1.Average().CompareTo(play2.Average()));
			Console.WriteLine(PlayerScoresString());
			foreach (var player in results)
			{
				Console.WriteLine(ResultFormatString(player.Name, player.NumberOfGames, player.Average()));
			}
        }

		public static string ResultFormatString(string name, int numberOfGames, double average) {
			return string.Format("{0,-9}{1,5:D}{2,9:F2}", name, numberOfGames, average);
        }

		public static string PlayerScoresString() {
			return "Player   games average";
		}
    }
}