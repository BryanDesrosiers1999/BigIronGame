using System;
using BigIron.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Stateless;

namespace BigIron
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Main : Game
    {

        private AState _currentState;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GameStateManager stateManager;        

        public void ChangeState(AState state)
        {
            _currentState = state;         
        }

        public Main()
        {
            graphics = new GraphicsDeviceManager(this);
            stateManager = new GameStateManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {           
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _currentState = new MenuState(this, graphics.GraphicsDevice, Content, stateManager);
            spriteBatch = new SpriteBatch(GraphicsDevice);                    
        }

        protected override void UnloadContent()
        {
 
        }

        protected override void Update(GameTime gameTime)
        {
            if (IsActive)
            {
                _currentState.Update(gameTime);
                _currentState.PostUpdate(gameTime);
                base.Update(gameTime);
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            _currentState.Draw(gameTime, spriteBatch);           
            base.Draw(gameTime);
        }
    }
}
