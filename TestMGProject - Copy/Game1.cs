using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


// Erin Cascioli
// 1/27/25
// Demo: MonoGame Basics


namespace TestMGProjecr
{
    public class Game1 : Game
    {
        // Pre-defined fields
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        // ----------------------------------------------------------------
        // New fields!
        // If any data needs to be used between multiple methods, or the data
        //   must persist from frame-to-frame, declare that data as a field 
        //   of the class!
        // ----------------------------------------------------------------
        private Texture2D cupcakeTexture;
        private Vector2 positionVec;
        private Rectangle positionRec;
        private SpriteFont arial20Bold;
        private KeyboardState kbState;



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            // ----------------------------------------------------------------
            // Have any data that is not dependent on loaded content?  
            // Initialize the data right here!
            // ----------------------------------------------------------------
            positionVec = new Vector2(100, 75);


            // ----------------------------------------------------------------
            // Keep this base call as the LAST thing in your Initialize method!
            // ----------------------------------------------------------------
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // ----------------------------------------------------------------
            // Keep this as the first line of your LoadContent method!
            // ----------------------------------------------------------------
            _spriteBatch = new SpriteBatch(GraphicsDevice);


            // ----------------------------------------------------------------
            // Load all content needed in your game!
            // This includes Texture2Ds and SpriteFonts.
            // Remember: Referencing a field before it has been loaded will result
            //   in a thrown exception.
            // ----------------------------------------------------------------

            // Use the cupcake image in this project, and reference it via the Texture2D
            // field called "cupcakeTexture"
            cupcakeTexture = Content.Load<Texture2D>("cupcake");
            arial20Bold = Content.Load<SpriteFont>("arial-20-bold");

            // If a value is dependent on a loaded content (like getting
            // image boundaries), initialize the value here! 
            // If you try to initialize it BEFORE the content is loaded,
            // an error will occur.
            positionRec = new Rectangle(
                0, 
                0, 
                cupcakeTexture.Width/8, 
                cupcakeTexture.Height/8);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // ----------------------------------------------------------------
            // Debugging statements are completed with a call to Debug.WriteLine()
            // They appear in the Output window, not a Console window.
            // Can't find the Output window?
            // Go to View menu option > Output
            // ----------------------------------------------------------------
            System.Diagnostics.Debug.WriteLine("debugging");


            // ----------------------------------------------------------------
            // Anything that needs to be updated on a once-per-frame basis can
            //   occur here!
            // ----------------------------------------------------------------
            // Move the image down in the game window.
            positionVec.Y += 1;


            kbState = Keyboard.GetState();

            // ----------------------------------------------------------------
            // Keep this base call as the LAST thing in your Update method!
            // ----------------------------------------------------------------
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // ----------------------------------------------------------------
            // Feel free to clear to a different color
            // ----------------------------------------------------------------
            GraphicsDevice.Clear(Color.CornflowerBlue);


            // ----------------------------------------------------------------
            // ALWAYS add Begin() and End() to your projects!
            // ----------------------------------------------------------------
            _spriteBatch.Begin();


            // ----------------------------------------------------------------
            // All Draw calls must be between Begin() and End()
            // ----------------------------------------------------------------
            _spriteBatch.Draw(
                cupcakeTexture,         // Texture to render
                positionVec,            // Upper-left corner position
                Color.White);           // Color overlay (no color change)

            _spriteBatch.Draw(
                cupcakeTexture,         // Texture to render
                positionRec,            // Upper-left/Width/Height
                Color.HotPink);         // Color overlay (pink tint)

            if (kbState.IsKeyDown(Keys.Enter))
            {
                _spriteBatch.DrawString(
                    arial20Bold,            // Font to use
                    "Hi everyone!\nHi",     // String to draw
                    new Vector2(0, 0),      // Position
                    Color.Black);           // Color
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
