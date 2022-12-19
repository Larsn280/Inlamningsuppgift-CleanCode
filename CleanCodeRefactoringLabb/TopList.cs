
namespace CleanCodeRefactoringLabb
{
    public class TopList
    {
        public static void showTopList()
		{
			StreamReader input = new StreamReader("result.txt");
			List<PlayerData> results = new List<PlayerData>();

			string line;
			while ((line = input.ReadLine()) != null)
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
			results.Sort((player1, player2) => player1.Average().CompareTo(player2.Average()));
			Console.WriteLine("Player   games average");
			foreach (PlayerData player in results)
			{
				Console.WriteLine(string.Format("{0,-9}{1,5:D}{2,9:F2}", player.Name, player.NGames, player.Average()));
			}
			input.Close();
		}
    }
}