using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using GamePractice.StateManagers;
using GamePractice.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace BigIron.States
{
    public class GameState : AState
    {

        private GSSManager gssManager;

        private Song _bigIron;

        public AGSS _currentGSS;



        public GameState(Main game, GraphicsDevice graphicsDevice,ContentManager content,GameStateManager stateManager) : base(game,graphicsDevice,content,stateManager)
        {
            _game = game;
            _graphicsDevice = graphicsDevice;
            _content = content;
            _stateManager = stateManager;

            gssManager = new GSSManager(stateManager,this,_graphicsDevice,_content);

            Initialize();

            _currentGSS = new Intro(this,graphicsDevice,content,gssManager);

        }

       

        private void Initialize()
        {
            
            _bigIron = _content.Load<Song>("Big Iron");
            MediaPlayer.Play(_bigIron); 
            MediaPlayer.Volume = .2f;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            _currentGSS.Draw(gameTime,spriteBatch);         
        }

        public override void PostUpdate(GameTime gameTime)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            _currentGSS.Update(gameTime);
        }

        public void ChangeState(AGSS state)
        {
            _currentGSS = state;
        }
    }
}
