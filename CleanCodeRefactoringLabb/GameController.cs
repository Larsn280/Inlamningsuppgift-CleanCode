
namespace CleanCodeRefactoringLabb
{
    public class GameController
    {
        private readonly Game _game;
        private readonly IUI _ui;
        private Dictionary<string, Action> commands;
        public GameController(Game game, IUI ui) {
            _game = game;
            _ui = ui;
        }

        public void Run() {
            do {
                display();
                string input = _ui.GetString();
                _game.Play(input);
            } while (true);
        }

        public void display() {
            _ui.Clear();
            _ui.PutString(_game.Welcome());
        }
    }
}