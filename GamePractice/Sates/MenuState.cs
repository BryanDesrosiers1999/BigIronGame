using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigIron.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BigIron.Sates
{
    public class MenuState : AState
    {

        private List<Component> _components;

        public MenuState(Main game, GraphicsDevice graphicsDevice,ContentManager content,GameStateManager stateManager) : base(game, graphicsDevice,content,stateManager)
        {
            game.IsMouseVisible = true;

            Texture2D buttonTexture = _content.Load<Texture2D>("Controls/red_button13");
            
            SpriteFont buttonFont = _content.Load<SpriteFont>("Fonts/Western");

            var startGame = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(300, 200),
                Text = "Start Game",
            };

            var quitGame = new Button(buttonTexture, buttonFont)
            {
                Position = new Vector2(300, 300),
                Text = "Quit Game",
            };

            startGame.Click += StartGame_Click;
            quitGame.Click += QuitGame_Click;

            _components = new List<Component>
            {
                startGame,
                quitGame,
            };
        }

        private void QuitGame_Click(object sender, EventArgs e)
        {
            _game.Exit();
        }
        private void StartGame_Click(object sender, EventArgs e)
        {
            _stateManager.StartGame();

        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            _graphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            foreach (var component in _components)
                component.Draw(gameTime,spriteBatch);
            spriteBatch.End();
        }

        public override void PostUpdate(GameTime gameTime)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var component in _components)
                component.Update(gameTime);
        }
    }
}
