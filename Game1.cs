using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Monogame_Lesson_2___Scaled_Images
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D rectangleTexture, circleTexture;
        List <Square> board = new List<Square>();
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            _graphics.PreferredBackBufferWidth = 640;
            _graphics.PreferredBackBufferHeight = _graphics.PreferredBackBufferWidth;
            _graphics.ApplyChanges();
            this.Window.Title = "Scaled Images";
            int count = 0;
            for (int i = 0 ; i < 8; i++)
            {
                for (int j = 0 ; j < 8; j++)
                {
                    int side = _graphics.PreferredBackBufferWidth / 8;
                    Rectangle rect = new Rectangle(0 + i * side, 0 + j * side, side, side);
                    if (count % 2 == 0)
                    {
                        Color color = Color.White; 
                        Square square = new Square(rectangleTexture, rect, color);
                        board.Add(square);
                    }
                    else 
                    {
                        Color color = Color.Black;
                        Square square = new Square(rectangleTexture, rect, color);
                        board.Add(square);
                    }
                    count++;
                }
                count++;
            }
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            //_spriteBatch.Draw(circleTexture, new Vector2(0, 0), Color.White);

            foreach (Square square in board)
            {
                square.Draw(_spriteBatch);
            }

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}