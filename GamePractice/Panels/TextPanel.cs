using BigIron;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePractice.Panels
{
    public class TextPanel : Component
    {

        //TODO:: Implement Text Centering if there is no backround texture//

        #region Fields

        private Texture2D _texture;

        private SpriteFont _font;

        private bool _hasTexture;

        #endregion
        
        #region Properties

        public Color PenColour { get; set; }

        public Vector2 Position { get; set; }

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height);
            }
        }

        public string Text { get; set; }

        #endregion

        #region Methods

        public TextPanel(SpriteFont font)
        {

            _font = font;

            PenColour = Color.Black;

            _hasTexture = false;

        }
        public TextPanel(SpriteFont font, Texture2D texture)
        {
            
            _texture = texture;

            _font = font;

            PenColour = Color.Black;

            _hasTexture = true;

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var colour = Color.White;
            if (_hasTexture)
            {
                spriteBatch.Draw(_texture, Rectangle, colour);

                if (!string.IsNullOrEmpty(Text))
                {
                    var x = (Rectangle.X + (Rectangle.Width / 2)) - (_font.MeasureString(Text).X / 2);
                    var y = (Rectangle.Y + (Rectangle.Height / 2)) - (_font.MeasureString(Text).Y / 2);

                    spriteBatch.DrawString(_font, Text, new Vector2(x, y), PenColour);
                }
            }
            else
            {
                spriteBatch.DrawString(_font, Text, Position, PenColour);
            }
        }

        public override void Update(GameTime gameTime)
        {
            
        }

        #endregion
    }
}
