using BigIron;
using BigIron.States;
using GamePractice.StateManagers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePractice.States
{
    class Stage1 : AGSS
    {
        public Stage1(GameState game, GraphicsDevice graphicsDevice, ContentManager content, GSSManager stateManager) : base(game, graphicsDevice, content, stateManager)
        {

            _gameState = game;
            _graphicsDevice = graphicsDevice;
            _content = content;
            _stateManager = stateManager;

        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            _graphicsDevice.Clear(Color.AntiqueWhite);          
        }

        public override void PostUpdate(GameTime gameTime)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
