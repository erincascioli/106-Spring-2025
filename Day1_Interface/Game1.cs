using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Day1_Interface
{
    public class Game1 : Game
    {
        // Pre-generated fields
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Texture field
        private Texture2D myCupcakeImage;
        private Vector2 positionVec;
        private Rectangle positionRec;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            positionVec = new Vector2(100, 75);
         

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            // Load all images here in the LoadContent() method!
            // Field = Content.Load<Texture2D>("asset name");
            myCupcakeImage = Content.Load<Texture2D>("cupcake");

            // Do you have any fields that are dependent on an image's width and/or height?
            // Initialize it here!
            positionRec = new Rectangle(
                0, 
                0, 
                myCupcakeImage.Width/4, 
                myCupcakeImage.Height/4);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //System.Diagnostics.Debug.WriteLine("Debugging");

            // Move the image
            positionVec.Y += 1;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Always add this to your new projects!!!!!
            _spriteBatch.Begin();

            _spriteBatch.Draw(
                myCupcakeImage,         // Texture2D
                positionVec,            // (100, 75)
                Color.Firebrick);       // Reddish?

            _spriteBatch.Draw(
                myCupcakeImage,         // Texture2D
                positionRec,            // (0, 0) sized (200, 50)
                Color.Purple);          // 

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
