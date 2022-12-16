using CleanCodeRefactoringLabb;

IUI ui = new ConsoleIO();
Game game = new Game();
GameController controller = new GameController(game, ui);
controller.Run();


