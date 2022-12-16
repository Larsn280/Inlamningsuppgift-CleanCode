
namespace CleanCodeRefactoringLabb
{
    public class GameController
    {
        private readonly Game _game;
        private readonly IUI _ui;
        public GameController(Game game, IUI ui) {
            _game = game;
            _ui = ui;
        }

        public void Run() {
            do {
                display();
                string name = _ui.GetString();
                _game.Play(name);
            } while (true);
        }

        public void display() {
            _ui.Clear();
            _ui.PutString(_game.Welcome());
        }
    }
}