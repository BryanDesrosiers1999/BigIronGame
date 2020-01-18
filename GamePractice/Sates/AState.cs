using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigIron.Sates
{
    public abstract class AState
    {
        #region Fields
        protected ContentManager _content;
        protected GraphicsDevice _graphicsDevice;
        protected Main _game;
        protected GameStateManager _stateManager;
        #endregion

        #region Methods

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        public abstract void PostUpdate(GameTime gameTime);

        public abstract void Update(GameTime gameTime);

        public AState(Main game, GraphicsDevice graphicsDevice, ContentManager content,GameStateManager stateManager)
        {
            _content = content;
            _graphicsDevice = graphicsDevice;
            _game = game;
            _stateManager = stateManager;
        }
        #endregion

    }
}
