using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace BigIron.Sates
{
    public class GameState : AState
    {
        private Song bigIron;

        public GameState(Main game, GraphicsDevice graphicsDevice,ContentManager content,GameStateManager stateManager) : base(game,graphicsDevice,content,stateManager)
        {
            _game = game;
            _graphicsDevice = graphicsDevice;
            _content = content;
            _stateManager = stateManager;
            Initialize();
        }

        private void Initialize()
        {
            bigIron = _content.Load<Song>("Big Iron");
            MediaPlayer.Play(bigIron);
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
