
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
            string input;
            do {
                display();
                input = _ui.GetString();
                if(input != "q") {
                    _ui.Clear();
                    _game.Play(input);
                }
            } while (input != "q");
        }

        public void display() {
            _ui.Clear();
            _ui.PutString(_game.Welcome());
        }
    }
}