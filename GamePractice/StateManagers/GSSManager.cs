using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Media;
using Stateless;
using System.Timers;

namespace GamePractice.StateManagers
{
    public class GSSManager
    {
        private Timer _timer;

        private int _elapsedTime;

        public GSSManager()
        {
            _timer = new Timer(1000);
            _timer.Elapsed += OnTimedEvent;
            _elapsedTime = 0;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            _elapsedTime++;
        }
    }
}
