
namespace CleanCodeRefactoringLabb
{
    public class GameController
    {
        private readonly Game _game;
        public GameController(Game game) {
            _game = game;
        }

        public void Run() {
            do {
                _game.Play();
            } while (true);
        }
    }
}