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
        public Stage1(Main game,GraphicsDevice graphicsDevice, ContentManager content, GSSManager stateManager) : base(game,graphicsDevice,content,stateManager)
        {

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public override void PostUpdate(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
