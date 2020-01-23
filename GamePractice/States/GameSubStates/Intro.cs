using BigIron;
using BigIron.States;
using GamePractice.Panels;
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
    class Intro : AGSS
    {
        private TextPanel message1;
        private double totalSeconds;

        public Intro(GameState gameState, GraphicsDevice graphicsDevice, ContentManager content, GSSManager stateManager) : base(gameState, graphicsDevice, content, stateManager)
        {

            _gameState = gameState;
            _graphicsDevice = graphicsDevice;
            _content = content;
            _stateManager = stateManager;

            SpriteFont western = content.Load<SpriteFont>("Fonts/WesternTitle");

            message1 = new TextPanel(western)
            {
                Position = new Vector2(graphicsDevice.PresentationParameters.BackBufferWidth / 2 - 115, 50),
                Text = "TEST TEST TEST TEST TEST TEST",
            };

            totalSeconds = 0;

        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            _graphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            message1.Draw(gameTime, spriteBatch);
            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gameTime)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            totalSeconds += gameTime.ElapsedGameTime.TotalSeconds;
            if (totalSeconds > .05)
            {
                message1.Position = new Vector2(message1.Position.X, message1.Position.Y + 1);
                totalSeconds = 0;
            }

        }
    }
}
