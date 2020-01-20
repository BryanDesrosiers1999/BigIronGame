using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace BigIron.States
{
    public class GameState : AState
    {
        private Song _bigIron;

        private int _elapsedTime;

        public GameState(Main game, GraphicsDevice graphicsDevice,ContentManager content,GameStateManager stateManager) : base(game,graphicsDevice,content,stateManager)
        {
            _game = game;
            _graphicsDevice = graphicsDevice;
            _content = content;
            _stateManager = stateManager;
            
            Initialize();
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _elapsedTime++;
            if(_elapsedTime > 5)
            {

            }
        }

        private void Initialize()
        {
            _elapsedTime = 0;
            _bigIron = _content.Load<Song>("Big Iron");
            MediaPlayer.Play(_bigIron);
            _timer.Enabled = true;            
            MediaPlayer.Volume = .2f;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            _graphicsDevice.Clear(Color.AntiqueWhite);
            spriteBatch.Begin();
            spriteBatch.End();
            
        }

        public override void PostUpdate(GameTime gameTime)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
