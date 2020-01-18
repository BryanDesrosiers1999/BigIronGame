using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;
using Stateless.Graph;
using System.IO;
using BigIron.Sates;

namespace BigIron
{
    public class GameStateManager
    {

        private Main _game;
        private enum State {Menu,Game,Paused,GameOver,Ending}
        private enum Trigger {StartGame,PauseGame,UnpauseGame,Lose,Win,ReturnToMenu}
        private readonly StateMachine<State,Trigger> _machine;
        private State previousPauseState;

        public GameStateManager(Main parentGame)
        {
            _game = parentGame;

            _machine = new StateMachine<State, Trigger>(State.Menu);

            _machine.Configure(State.Menu)
                .Permit(Trigger.StartGame, State.Game)
                .Permit(Trigger.PauseGame, State.Paused)
                .OnEntry(()=>previousPauseState = State.Menu);
            _machine.Configure(State.Game)
                .Permit(Trigger.PauseGame, State.Paused)
                .Permit(Trigger.Lose, State.GameOver)
                .Permit(Trigger.Win, State.Ending)
                .OnEntry(() => previousPauseState = State.Game)
                .OnEntryFrom(Trigger.StartGame,OnGameStart)
                .Ignore(Trigger.StartGame);                
            _machine.Configure(State.Paused)
                .Permit(Trigger.PauseGame, previousPauseState);
            _machine.Configure(State.GameOver)
                .Permit(Trigger.ReturnToMenu, State.Menu);
            _machine.Configure(State.Ending)
                .Permit(Trigger.ReturnToMenu, State.Menu);
            
            File.WriteAllText(@"Desktop", ToDotGraph());
        }
        private void OnGameStart()
        {
            _game.ChangeState(new GameState(_game, _game.GraphicsDevice, _game.Content, this));

        }
        private string ToDotGraph()
        {
            return UmlDotGraph.Format(_machine.GetInfo());
        }
        public void StartGame()
        {
            _machine.Fire(Trigger.StartGame);
        }
    }
}
