using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame_DefinedClasses.Content;

// Erin Cascioli
// 2/3/25
// Demo: Defining your own classes in a MonoGame project
//       Includes basic info about UI elements

namespace MonoGame_DefinedClasses
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // ------------------------------------------------------------------------------------
        // Fields needed for this demo
        // ------------------------------------------------------------------------------------
        private Texture2D cakeImage;
        private Cupcake myCake;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // ------------------------------------------------------------------------------------
            // Load necessary content for this demo
            // ------------------------------------------------------------------------------------
            cakeImage = Content.Load<Texture2D>("cupcake");

            // ------------------------------------------------------------------------------------
            // Ensure that any objects dependent on a Texture2D or a SpriteFont are initialized
            //   AFTER they are loaded.
            // ------------------------------------------------------------------------------------
            myCake = new Cupcake(250, 250, 200, 200, cakeImage, Color.BlueViolet);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || 
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // ------------------------------------------------------------------------------------
            // Call the class's Update method here
            // ------------------------------------------------------------------------------------
            myCake.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // ------------------------------------------------------------------------------------
            // Call the class's Draw method here
            // Ensure the calls are between Begin() and End()
            // ------------------------------------------------------------------------------------
            _spriteBatch.Begin();
            myCake.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
