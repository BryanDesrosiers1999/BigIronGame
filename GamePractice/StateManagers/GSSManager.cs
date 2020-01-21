using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Media;
using Stateless;
using System.Timers;
using BigIron;

namespace GamePractice.StateManagers
{
    public class GSSManager
    {
        private GameStateManager _father;

        private Timer _timer;

        private int _elapsedTime;

        private enum GSState {Intro,Stage1,Stage2,Stage3,Death,Win}

        private enum GSTrigger {NextStage,Restart,Won}

        private StateMachine<GSState,GSTrigger> _machine;

        public GSSManager(GameStateManager father)
        {
            Initialize();
        }

        private void Initialize()
        {
            _timer = new Timer(1000);
            _timer.Elapsed += OnTimedEvent;
            _elapsedTime = 0;
            _timer.Enabled = true;

            _machine = new StateMachine<GSState, GSTrigger>(GSState.Stage1);
            _machine.Configure(GSState.Intro)
                .Permit(GSTrigger.NextStage, GSState.Stage1);
            _machine.Configure(GSState.Stage1)
                .Permit(GSTrigger.NextStage, GSState.Stage2);
            _machine.Configure(GSState.Stage2)
                .Permit(GSTrigger.NextStage, GSState.Stage3);
            _machine.Configure(GSState.Stage3)
                .Permit(GSTrigger.Won, GSState.Win);
            _machine.Configure(GSState.Win)
                .OnEntry(() => _father.WinGame());
            _machine.Configure(GSState.Death)
                .OnEntry(() => _father.Death());
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            _elapsedTime++;
            switch (_elapsedTime)
            {
                case 5:
                    _machine.Fire(GSTrigger.NextStage);
                    break;
                case 60:
                    _machine.Fire(GSTrigger.NextStage);
                    break;
                case 120:
                    _machine.Fire(GSTrigger.NextStage);
                    break;
                case 240:
                    _machine.Fire(GSTrigger.Won);
                    break;
            }                                     
        }

    }
}
