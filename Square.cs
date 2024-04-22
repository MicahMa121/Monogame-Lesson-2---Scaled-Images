using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Monogame_Lesson_2___Scaled_Images
{
    internal class Square
{
        private Texture2D _texture;
        private Rectangle _rect;
        private Color _color;
        public Square(Texture2D texture, Rectangle rect, Color color)
        {
            _texture = texture;
            _rect = rect;
            _color = color;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _rect, _color);
        }

    }
}
