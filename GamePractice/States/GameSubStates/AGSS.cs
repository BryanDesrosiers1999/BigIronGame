﻿using GamePractice.StateManagers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigIron.States
{
    public abstract class AGSS
    {
        #region Fields
        protected ContentManager _content;
        protected GraphicsDevice _graphicsDevice;
        protected Main _game;
        protected GSSManager _stateManager;
        #endregion

        #region Methods

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        public abstract void PostUpdate(GameTime gameTime);

        public abstract void Update(GameTime gameTime);

        public AGSS(Main game, GraphicsDevice graphicsDevice, ContentManager content, GSSManager stateManager)
        {
            _content = content;
            _graphicsDevice = graphicsDevice;
            _game = game;
            _stateManager = stateManager;
        }
        #endregion

    }
}
