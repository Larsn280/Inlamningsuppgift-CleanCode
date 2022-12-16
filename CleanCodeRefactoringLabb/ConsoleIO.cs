
namespace CleanCodeRefactoringLabb
{
    public class ConsoleIO : IUI
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Exit()
        {
            System.Environment.Exit(0);
        }

        public string GetString()
        {
            return Console.ReadLine();
        }

        public void PutString(string s)
        {
            Console.WriteLine(s);
        }
    }
}