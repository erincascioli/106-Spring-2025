using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Erin Cascioli
// 2/10/25
// Demo: Rectangle class's Intersects method and Contains method


namespace IntersectsCollisionDemo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // --------------------------------------------------------------------
        // Fields specific to the demo
        // --------------------------------------------------------------------

        // Rectangles:
        private Rectangle rect1;
        private Rectangle rect2;
        private Rectangle rect3;

        // Needed for drawing:
        private Texture2D rectImage;
        private SpriteFont arial16;

        // Player input:
        private KeyboardState kbState;
        private MouseState mState;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // --------------------------------------------------------------------
            // Initialize the rectangles for the demo
            // --------------------------------------------------------------------
            rect1 = new Rectangle(50, 250, 100, 100);
            rect2 = new Rectangle(200, 200, 100, 100);
            rect3 = new Rectangle(500, 150, 50, 50);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // --------------------------------------------------------------------
            // Load content
            // --------------------------------------------------------------------
            rectImage = Content.Load<Texture2D>("square");
            arial16 = Content.Load<SpriteFont>("arial16");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || 
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // --------------------------------------------------------------------
            // Get current keyboard and mouse states
            // --------------------------------------------------------------------
            kbState = Keyboard.GetState();
            mState = Mouse.GetState();

            // --------------------------------------------------------------------
            // Change the position of the Rectangle when user presses Enter key
            // Reset to original position upon release
            // --------------------------------------------------------------------
            if (kbState.IsKeyDown(Keys.Enter))
            {
                rect1.X += 3;
            }
            else
            {
                rect1.X = 50;
                rect1.Y = 250;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // --------------------------------------------------------------------
            // All draw() calls should be after this line.
            // --------------------------------------------------------------------
            _spriteBatch.Begin();

            // --------------------------------------------------------------------
            // Draw instructions to the game window
            // --------------------------------------------------------------------
            _spriteBatch.DrawString(
                arial16,
                "Hold enter to move the blue rectangle.\n" + 
                "Release to reset its position.\n\n" + 
                "Mouse over the pink rectangle.",
                new Vector2(10, 10),
                Color.Black);

            // --------------------------------------------------------------------
            // Determine collision between the 2 Rectangles:
            //   If colliding, color the first Rectangle green
            //   No collision --> colored blue
            //   Always color second rectangle white
            // --------------------------------------------------------------------
            if (rect1.Intersects(rect2))
            {
                _spriteBatch.Draw(rectImage, rect1, Color.GreenYellow);
            }
            else
            {
                _spriteBatch.Draw(rectImage, rect1, Color.Blue);
            }

            _spriteBatch.Draw(rectImage, rect2, Color.White);

            // --------------------------------------------------------------------
            // Determine if the mouse coordinates are within the bounds of the 3rd rectangle
            // --------------------------------------------------------------------
            if (rect3.Contains(new Point(mState.X, mState.Y)))
            {
                _spriteBatch.Draw(rectImage, rect3, Color.Purple);
            }
            else
            {
                _spriteBatch.Draw(rectImage, rect3, Color.Pink);
            }

            // --------------------------------------------------------------------
            // All Draw() calls should be before this line.
            // --------------------------------------------------------------------
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
